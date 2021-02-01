using System;
using System.Collections.Generic;

namespace ZonaSoft.Dominio
{
    public class Venta
    {
        //Atributos
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<LineaVenta> Lineas { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public Cliente Cliente { get; set; }

        //Fluent API
        public int IdCliente { get; set; }
        public int IdMetodoPago { get; set; }

        //Métodos
        public float ObtenerTotal()
        {
            float total = 0;
            foreach (LineaVenta linea in Lineas)
            {
                total += linea.Cantidad * linea.PrecioActual;
            }
            return total;
        }
    }
}
