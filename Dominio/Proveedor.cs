using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class Proveedor
    {
        //Atributos
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }

        //Fluent API
        public ICollection<Compra> Compras { get; set; }
    }
}
