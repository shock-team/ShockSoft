using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
    public class Producto
    {
        public int idProducto { get; set; }
        public string iDescripcion { get; set; }
        public int iCantidad { get; set; }
        public float iPrecioBaseDolar { get; set; }
        public bool iEnVenta { get; set; }
        public float iPorcentajeGanancia { get; set; }

        public float ObtenerPrecioDeVenta()
        {
            
        }
    }
}
