﻿using ZonaSoft.Dominio;
using ZonaSoft.Excepciones;
using ZonaSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace ZonaSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Producto
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorProductos
    {
        private static ControladorProductos _instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorProductos ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorProductos();
            }

            return _instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo producto y agregarlo al repositorio.
        /// </summary>
        /// <param name="pDescripcion">La descripción del nuevo producto.</param>
        /// <param name="pPrecioBaseDolar">El precio base en dólares del nuevo producto.</param>
        /// <param name="pGanancia">El porcentaje de ganancia del nuevo producto.</param>
        /// <param name="pIVA">El ID del IVA asociado al nuevo producto.</param>
        /// <param name="pMarca">El ID de la marca asociada al nuevo producto.</param>
        /// <param name="pRubro">El ID del rubro asociado al nuevo producto.</param>
        public void AgregarProducto(string pDescripcion, string pComentarios, float pPrecioBaseDolar, float pGanancia, int pIVA, int pMarca, int pRubro)
        {
            Producto producto = new Producto();
            producto.Descripcion = pDescripcion;
            producto.Comentarios = pComentarios;
            producto.Cantidad = 0;
            producto.PrecioBaseDolar = pPrecioBaseDolar;
            producto.EnVenta = true;
            producto.PorcentajeGanancia = pGanancia;

            if (pIVA == 0 || pMarca == 0 || pRubro == 0)
            {
                throw new DatosFaltantesException();
            }

            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Parametro iva = bUoW.RepositorioParametro.Obtener(pIVA);
                    producto.Parametro = iva;
                    Marca marca = bUoW.RepositorioMarca.Obtener(pMarca);
                    producto.Marca = marca;
                    Rubro rubro = bUoW.RepositorioRubro.Obtener(pRubro);
                    producto.Rubro = rubro;
                    bUoW.RepositorioProducto.Agregar(producto);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los productos 
        /// presentes en el repositorio, según distintos filtros.
        /// </summary>
        /// <param name="pDescripcion">La descripción del producto.</param>
        /// <param name="pDeBaja">Si el producto no está en venta.</param>
        /// <param name="pSinStock">Si no se posee stock del producto.</param>
        /// <param name="pId">El ID del producto.</param>
        /// <param name="pDesde">El índice a partir del cual obtener los productos.</param>
        /// <param name="pCantidad">La cantidad de productos a devolver.</param>
        /// <param name="pIdMarca">El ID de la marca asociada al producto.</param>
        /// <param name="pIdRubro">El ID del rubro asociado al producto.</param>
        /// <returns></returns>
        public List<Producto> ListarProductos(string pDescripcion, bool pDeBaja, bool pSinStock, string pId, int pDesde, int pCantidad, int pIdMarca, int pIdRubro)
        {
            List<Producto> listaProductos = new List<Producto>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    if (string.IsNullOrEmpty(pId))
                    {
                        listaProductos = bUoW.RepositorioProducto.ObtenerProductos(pDeBaja, pSinStock, pDescripcion, pDesde, pCantidad, pIdMarca,pIdRubro).ToList();
                    }
                    else
                    {
                        Producto producto = bUoW.RepositorioProducto.ObtenerProducto(int.Parse(pId)) ?? new Producto { };
                        producto.Marca = bUoW.RepositorioMarca.Obtener(producto.IdMarca) ?? new Marca { };
                        listaProductos.Add(producto);
                    }
                }
            }
            return listaProductos;
        }

        /// <summary>
        /// Este método se encarga de modificar los datos de un producto existente
        /// en el repositorio
        /// </summary>
        /// <param name="pDescripcion">La nueva descripción del producto</param>
        /// <param name="pPrecioBaseDolar">El nuevo precio base en dólares del producto</param>
        /// <param name="pGanancia">El nuevo porcentaje de ganancia del producto</param>
        /// <param name="pIVA">El ID del nuevo IVA asociado al producto</param>
        /// <param name="idProducto">El ID del producto a modificar</param>
        public void ModificarProducto(string pDescripcion, string pComentarios, float pPrecioBaseDolar, float pGanancia, int pIVA, int idProducto)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Producto producto = bUoW.RepositorioProducto.Obtener(idProducto);
                    producto.Descripcion = pDescripcion;
                    producto.Comentarios = pComentarios;
                    producto.PrecioBaseDolar = pPrecioBaseDolar;
                    producto.PorcentajeGanancia = pGanancia;
                    Parametro iva = bUoW.RepositorioParametro.Obtener(pIVA);
                    producto.Parametro = iva;
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de invertir el estado de venta de un producto y devolver en qué estado quedó.
        /// </summary>
        /// <param name="idProducto">El ID del producto</param>
        public bool InvertirEstadoDeVenta(int idProducto)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Producto producto = bUoW.RepositorioProducto.Obtener(idProducto);

                    bool estado = producto.EnVenta ? producto.EnVenta = false : producto.EnVenta = true;

                    bUoW.GuardarCambios();

                    return estado;
                }
            }
        }

        /// <summary>
        /// Este método se encarga de obtener y devolver la instancia de un producto
        /// que se encuentra almacenada en la base de datos.
        /// </summary>
        /// <param name="pId">El Id del producto que se desea obtener</param>
        /// <returns></returns>
        public Producto ObtenerProducto(int pId)
        {
            Producto producto = new Producto();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    producto = bUoW.RepositorioProducto.ObtenerProducto(pId);
                }
            }
            return producto;
        }

        /// <summary>
        /// Este método se encarga de devolver la cantidad de productos presentes
        /// en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeProductos()
        {
            int cantidad = 0;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    cantidad = bUoW.RepositorioProducto.CantidadFilas();
                }
            }
            return cantidad;
        }
    }
}