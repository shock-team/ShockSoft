using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class MetodoPago
    {
        //Atributos
        public int IdMetodoPago { get; set; }
        public float MultiplicadorInteres { get; set; }
        public string Descripcion { get; set; }

        //Fluent API
        public ICollection<Venta> Ventas { get; set; }
        public ICollection<Reparacion> Reparaciones { get; set; }
    }
}
