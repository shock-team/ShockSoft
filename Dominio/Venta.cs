using System;
using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public List<LineaVenta> Lineas { get; set; }
        public MetodoPago MetodoPago { get; set; }

        public float ObtenerTotal()
        {
            float total = 0;
            foreach (LineaVenta linea in Lineas)
            {
                total += linea.Cantidad * linea.PrecioActual;
            }
            return total * MetodoPago.Valor;
        }
    }
}
