using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
    public class LineaCompra
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioActual { get; set; }
    }
}
