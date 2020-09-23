using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class Localidad
    {
        //Atributos
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }

        //Fluent API
        public ICollection<Cliente> Clientes { get; set; }
    }
}
