using System;
using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public float CostoTotalPesos { get; set; }
        public float DolarProveedor { get; set; }
        public List<LineaCompra> LineasCompra { get; set; }
        public Proveedor Proveedor { get; set; }

        public float ObtenerTotal()
        {
            float total = 0;

            foreach (var lineaCompra in LineasCompra)
            {
                total += lineaCompra.PrecioActual;
            }

            return total;
        }
    }
}
