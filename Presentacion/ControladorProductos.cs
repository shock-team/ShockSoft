using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Producto
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorProductos
    {
        public static ControladorProductos instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorProductos ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorProductos();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear el nuevo producto y agregarlo al repositorio
        /// </summary>
        /// <param name="pDescripcion">La descripción del nuevo producto</param>
        /// <param name="pPrecioBaseDolar">El precio base en dólares del nuevo producto</param>
        /// <param name="pGanancia">El porcentaje de ganancia del nuevo producto</param>
        /// <param name="pIVA">El ID del IVA asociado al nuevo producto</param>
        /// <param name="pMarca">El ID de la marca asociada al nuevo producto</param>
        public void AgregarProducto(string pDescripcion, float pPrecioBaseDolar, float pGanancia, int pIVA, int pMarca)
        {
            Producto producto = new Producto();
            producto.Descripcion = pDescripcion;
            producto.Cantidad = 0;
            producto.PrecioBaseDolar = pPrecioBaseDolar;
            producto.EnVenta = true;
            producto.PorcentajeGanancia = pGanancia;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Parametro iva = bUoW.RepositorioParametro.Obtener(pIVA);
                    producto.Parametro = iva;
                    Marca marca = bUoW.RepositorioMarca.Obtener(pMarca);
                    producto.Marca = marca;
                    bUoW.RepositorioProducto.Agregar(producto);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todos los productos 
        /// presentes en el repositorio, según distintos filtros
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarProductos(string pDescripcion, bool pDeBaja, bool pSinStock, int pId)
        {
            IEnumerable<Producto> listaProductosPorStock;
            IEnumerable<Producto> listaProductosPorEnVenta;
            IEnumerable<Producto> listaProductosPorDescripcion;
            List<Producto> listaProductos = new List<Producto>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    if (pId != -1)
                    {
                        listaProductosPorStock = bUoW.RepositorioProducto.ObtenerConStock(pSinStock);
                        listaProductosPorEnVenta = bUoW.RepositorioProducto.ObtenerEnVenta(pDeBaja);
                        listaProductosPorDescripcion = bUoW.RepositorioProducto.ObtenerPorDescripcion(pDescripcion);
                        listaProductos = listaProductosPorStock.Intersect(listaProductosPorEnVenta).Intersect(listaProductosPorDescripcion).ToList();
                    }
                    else
                    {
                        listaProductos.Add(bUoW.RepositorioProducto.Obtener(pId));
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
        public void ModificarProducto(string pDescripcion, float pPrecioBaseDolar, float pGanancia, int pIVA, int idProducto)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Producto producto = bUoW.RepositorioProducto.Obtener(idProducto);
                    producto.Descripcion = pDescripcion;
                    producto.PrecioBaseDolar = pPrecioBaseDolar;
                    producto.PorcentajeGanancia = pGanancia;
                    Parametro iva = bUoW.RepositorioParametro.Obtener(pIVA);
                    producto.Parametro = iva;
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de dar de baja un producto existente
        /// </summary>
        /// <param name="idProducto">El ID del producto</param>
        public void DarDeBaja(int idProducto)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    Producto producto = bUoW.RepositorioProducto.Obtener(idProducto);
                    producto.EnVenta = false;
                    bUoW.GuardarCambios();
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
                    producto = bUoW.RepositorioProducto.Obtener(pId);
                }
            }
            return producto;
        }
    }
}