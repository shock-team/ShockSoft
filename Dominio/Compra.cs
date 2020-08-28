using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
    public class Compra
    {
        public int idCompra { get; set; }
        public DateTime iFecha { get; set; }
        public float iCostoTotalPesos { get; set; }
        public float iDolarProveedor { get; set; }

    }
}
