using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
    public class CuentaCorriente
    {
        public int idCuenta { get; set; }
        public List<Pago> iPagos { get; set; }
        public List<Venta> iVentas { get; set; }

        public float ObtenerSaldo()
        {
            float total = 0;
            for (int i = 0; i < iPagos.Count; i++)
            {
                total += iPagos[i].iMonto;
            }
            for (int i = 0; i < iVentas.Count; i++)
            {
                total -= iVentas[i].ObtenerTotal();
            }
            return total;
        }

        public void AgregarPago(Pago pPago)
        {
            iPagos.Add(pPago);
        }
    }
}