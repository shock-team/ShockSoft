using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZonaSoft.Dominio
{
    public class LineaReparacion
    {
        //Atributos
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioActual { get; set; }

        //Fluent API
        public Reparacion Reparacion { get; set; }
        public int IdLineaReparacion { get; set; }
        public int IdProducto { get; set; }
        public int IdReparacion { get; set; }

        //Métodos
        public float ObtenerSubtotal()
        {
            return this.PrecioActual * this.Cantidad;
        }
    }
}
