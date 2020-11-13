using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Venta
    /// y las clases de dominio. Esta clase aplica el patrón de diseño Singleton.
    /// </summary>
    public class ControladorVentas
    {
        public static ControladorVentas instancia;

        /// <summary>
        /// Obtiene la instancia del controlador
        /// </summary>
        /// <returns></returns>
        public static ControladorVentas ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ControladorVentas();
            }
            return instancia;
        }

        /// <summary>
        /// Este método se encarga de crear la nueva venta y agregarla al repositorio
        /// </summary>
        /// <param name="idCliente">ID del cliente correspondiente a la venta</param>
        /// <param name="pListaLineaVenta">Lista de líneas de venta asociadas a la venta</param>
        /// <param name="idMetodoPago">ID del método de pago correspondiente a la venta</param>
        public void AgregarVenta(int idCliente, List<LineaVenta> pListaLineaVenta, int idMetodoPago)
        {
            Venta venta = new Venta();
            venta.Lineas = pListaLineaVenta;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    MetodoPago metodoPago = bUoW.RepositorioMetodoPago.Obtener(idMetodoPago);
                    venta.MetodoPago = metodoPago;
                    Cliente cliente = bUoW.RepositorioCliente.Obtener(idCliente);
                    cliente.AgregarVenta(venta);
                    bUoW.GuardarCambios();
                }
            }
        }

        /// <summary>
        /// Este método se encarga de devolver una lista de todas las marcas presentes
        /// en el repositorio, según distintos filtros
        /// </summary>
        /// <param name="pCliente">El cliente asociado a las ventas</param>
        /// <param name="pProducto">El producto vendido en las ventas</param>
        /// <returns></returns>
        public List<Venta> ListarVentas(int pCliente, int pProducto, int pDesde, int pCantidad)
        {
            List<Venta> listaVentas;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaVentas = bUoW.RepositorioVenta.ObtenerVentas(pCliente, pProducto, pDesde, pCantidad).ToList();
                }
            }
            return listaVentas;
        }

        /// <summary>
        /// Genera una lista de instancias de la clase LineaVenta a partir de los datos conocidos
        /// por la vista.
        /// </summary>
        /// <param name="pFilas">Las filas de la tabla de la vista</param>
        /// <returns></returns>
        public List<LineaVenta> GenerarLineasDeVenta(DataGridViewRowCollection pFilas)
        {
            List<LineaVenta> lineasDeVenta = new List<LineaVenta>();
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    for (int i = 0; i < pFilas.Count; i++)
                    {
                        LineaVenta lineaDeVenta = new LineaVenta();
                        lineaDeVenta.IdProducto = (int)pFilas[i].Cells[0].Value;
                        lineaDeVenta.Cantidad = (int)pFilas[i].Cells[3].Value;
                        Producto producto = bUoW.RepositorioProducto.Obtener((int)pFilas[i].Cells[0].Value);
                        lineaDeVenta.Producto = producto;
                        lineaDeVenta.PrecioActual = producto.PrecioBaseDolar;
                    }
                }
            }
            return lineasDeVenta;
        }

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
    }
}
