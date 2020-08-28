using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
    class Venta
    {
        public int idVenta { get; set; }
        public DateTime iFecha { get; set; }
        public List<LineaVenta> iLineas { get; set; }
        public MetodoPago iMetodoPago { get; set; }

        public float ObtenerTotal()
        {
            float total = 0;
            for (int i = 0; i < iLineas.Count; i++)
            {
                total += iLineas[i].iCantidad * iLineas[i].iPrecioActual;
            }
            return total * iMetodoPago.iValor;
        }
    }
}
