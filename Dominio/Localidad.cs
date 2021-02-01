using System.Collections.Generic;

namespace ZonaSoft.Dominio
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
