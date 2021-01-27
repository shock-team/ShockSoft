using System;
using System.Collections.Generic;
using System.Linq;

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

            total = LineasCompra.Sum(x => x.ObtenerSubtotal());

            return total;
        }
    }
}
