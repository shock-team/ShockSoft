using System.Collections.Generic;

namespace ZonaSoft.Dominio
{
    public class Rubro
    {
        //Atributos
        public int IdRubro { get; set; }
        public string Descripcion { get; set; }

        //Fluent API
        public ICollection<Reparacion> Reparaciones { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
