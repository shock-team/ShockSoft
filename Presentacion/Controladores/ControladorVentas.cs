using ZonaSoft.Dominio;
using ZonaSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;

namespace ZonaSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Venta
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorVentas
    {
        private static ControladorVentas _instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorVentas ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new ControladorVentas();
            }

            return _instancia;
        }

        /// <summary>
        /// Este método se encarga de crear la nueva venta y agregarla al repositorio
        /// </summary>
        /// <param name="idCliente">ID del cliente correspondiente a la venta</param>
        /// <param name="idMetodoPago">ID del método de pago correspondiente a la venta</param>
        /// <param name="pFecha">La fecha en que se efectuó la venta</param>
        public int AgregarVenta(int idCliente, int idMetodoPago, DateTime pFecha)
        {
            Venta venta = new Venta();
            venta.Fecha = pFecha;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    MetodoPago metodoPago = bUoW.RepositorioMetodoPago.Obtener(idMetodoPago);
                    venta.MetodoPago = metodoPago;
                    Cliente cliente = bUoW.RepositorioCliente.Obtener(idCliente);
                    cliente.AgregarVenta(venta);
                    bUoW.GuardarCambios();
                    return venta.IdVenta;
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las ventas presentes
        /// en el repositorio, según distintos filtros
        /// </summary>
        /// <param name="pCliente">El cliente asociado a las ventas</param>
        /// <param name="pProducto">El producto vendido en las ventas</param>
        /// <param name="pDesde">El índice a partir del cual traer las ventas.</param>
        /// <param name="pCantidad">La cantidad de ventas a traer.</param>
        /// <returns></returns>
        public List<Venta> ListarVentas(int pCliente, int pProducto, int pDesde, int pCantidad)
        {
            List<Venta> listaVentas;
            List<Venta> listaDeVentas = new List<Venta>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaVentas = bUoW.RepositorioVenta.ObtenerVentas(pCliente, pProducto, pDesde, pCantidad).ToList();
                }
            }

            foreach (Venta venta in listaVentas)
            {
                if (!(listaDeVentas.Contains(venta)) && ((venta.IdCliente == pCliente) || (pCliente == 0)))
                {
                    listaDeVentas.Add(venta);
                }
            }
            return listaDeVentas;
        }


        /// <summary>
        /// Genera una lista de instancias de la clase LineaVenta a partir de los datos conocidos
        /// por la vista.
        /// </summary>
        /// <param name="pFilas">Las filas de la tabla de la vista</param>
        /// <param name="pIdVenta">El ID de la venta.</param>
        /// <param name="pIdMetodoPago">El ID del método de pago de la venta.</param>
        /// <returns></returns>
        public List<LineaVenta> GenerarLineasDeVenta(DataGridViewRowCollection pFilas, int pIdVenta, int pIdMetodoPago)
        {
            List<LineaVenta> lineasDeVenta = new List<LineaVenta>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    MetodoPago metodoPago = bUoW.RepositorioMetodoPago.Obtener(pIdMetodoPago);
                    for (int i = 0; i < pFilas.Count; i++)
                    {
                        if (pFilas[i].Cells[0].Value != null)
                        {
                            LineaVenta lineaDeVenta = new LineaVenta();
                            lineaDeVenta.IdProducto = int.Parse(pFilas[i].Cells[0].Value.ToString());
                            lineaDeVenta.Cantidad = int.Parse(pFilas[i].Cells[3].Value.ToString());

                            Producto producto = bUoW.RepositorioProducto.ObtenerProducto(int.Parse(pFilas[i].Cells[0].Value.ToString()));
                            producto.Cantidad -= lineaDeVenta.Cantidad;
                            lineaDeVenta.Producto = producto;
                            lineaDeVenta.PrecioActual = producto.ObtenerPrecioDeVenta()
                                                        * bUoW.RepositorioParametro.ObtenerPrecioDolar().Valor
                                                        * metodoPago.MultiplicadorInteres;
                            lineaDeVenta.IdVenta = pIdVenta;
                            bUoW.RepositorioLineasDeVentas.Agregar(lineaDeVenta);
                        }
                    }
                    bUoW.GuardarCambios();
                }
            }
            return lineasDeVenta;
        }

        /// <summary>
        /// Este método se utiliza para obtener la cantidad de instancias de la clase Venta presentes
        /// en la base de datos.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeVentas()
        {
            int cantidadDeVentas = 0;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    cantidadDeVentas = bUoW.RepositorioVenta.CantidadFilas();
                }
            }
            return cantidadDeVentas;
        }

        /// <summary>
        /// Este método se utiliza para obtener una instancia específica de la clase Venta presente en
        /// la base de datos a partir de su ID.
        /// </summary>
        /// <param name="pIdVenta">El ID de la venta a traer.</param>
        /// <returns></returns>
        public Venta ObtenerVenta(int pIdVenta)
        {
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    return bUoW.RepositorioVenta.ObtenerVentaPorId(pIdVenta);
                }
            }
        }
    }
}
