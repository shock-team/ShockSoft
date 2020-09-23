using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class Marca
    {
        //Atributos
        public int IdMarca { get; set; }
        public string Descripcion { get; set; }

        //Fluent API
        public ICollection<Reparacion> Reparaciones { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
