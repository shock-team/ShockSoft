using ShockSoft.Dominio;
using ShockSoft.Persistencia.EntityFramework;
using System.Collections.Generic;
using System.Linq;

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
        public List<Venta> ListarVentas(int pCliente, int pProducto)
        {
            List<Venta> listaVentas;
            using (var bDbContext = new ShockDbContext())
            {
                using (UnitOfWork bUoW = new UnitOfWork(bDbContext))
                {
                    listaVentas = bUoW.RepositorioVenta.ObtenerTodos().ToList();
                }
            }
            return listaVentas;
        }
    }
}
