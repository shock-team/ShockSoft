using System;

namespace ShockSoft.Dominio
{
    public class Pago
    {
        //Atributos
        public int IdPago { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public string Descripcion { get; set; }
        public Cliente Cliente { get; set; }

        //Fluent API
        public int IdCliente { get; set; }
    }
}
