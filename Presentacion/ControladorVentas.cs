using ShockSoft.Dominio;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    /// <summary>
    /// Esta clase se encarga de funcionar como intermediaria entre la
    /// GUI correspondiente a los casos de uso asociados a la clase Venta
    /// y las clases de dominio
    /// </summary>
    public class ControladorVentas
    {
        /// <summary>
        /// Este método se encarga de crear la nueva venta y agregarla al repositorio
        /// </summary>
        /// <param name="idCuentaCorriente">ID de la cuenta corriente asociada a la venta</param>
        /// <param name="pListaLineaVenta">Lista de líneas de venta asociadas a la venta</param>
        /// <param name="idMetodoPago">ID del método de pago correspondiente a la venta</param>
        public void AgregarVenta(int idCuentaCorriente, List<LineaVenta> pListaLineaVenta, int idMetodoPago)
        {
            Venta venta = new Venta();
            venta.Lineas = pListaLineaVenta;
            MetodoPago metodoPago = new MetodoPago();
            venta.MetodoPago = metodoPago;
            CuentaCorriente cuentaCorriente = new CuentaCorriente();
            cuentaCorriente.AgregarVenta(venta);

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
            List<Venta> listaVentas = new List<Venta>();
            return listaVentas;
        }
    }
}
