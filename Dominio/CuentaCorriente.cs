using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
    public class CuentaCorriente
    {
        public int IdCuenta { get; set; }
        public List<Pago> Pagos { get; set; }
        public List<Venta> Ventas { get; set; }

        public float ObtenerSaldo()
        {
            float total = 0;
            foreach (Pago pago in Pagos)
            {
                total += pago.Monto;
            }
            foreach (Venta venta in Ventas)
            {
                total -= venta.ObtenerTotal();
            }
            return total;
        }

        public void AgregarPago(Pago pPago)
        {
            Pagos.Add(pPago);
        }
    }
}