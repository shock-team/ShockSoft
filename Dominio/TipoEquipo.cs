using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class TipoEquipo
    {
        //Atributos
        public int IdTipoEquipo { get; set; }
        public string Descripcion { get; set; }

        //Fluent API
        public ICollection<Reparacion> Reparaciones { get; set; }
    }
}
