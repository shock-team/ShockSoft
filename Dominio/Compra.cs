using System;
using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class Compra
    {
        //Atributos
        public int IdCompra { get; set; }
        public DateTime Fecha { get; set; }
        public float CostoTotalPesos { get; set; }
        public float DolarProveedor { get; set; }
        public List<LineaCompra> LineasCompra { get; set; }
        public Proveedor Proveedor { get; set; }

        //FluentAPI
        public int IdProveedor { get; set; }

        //Métodos
        public float ObtenerTotal()
        {
            float total = 0;

            foreach (var lineaCompra in this.LineasCompra)
            {
                total += lineaCompra.PrecioActual;
            }

            return total;
        }
    }
}
