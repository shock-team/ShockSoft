using System.Collections.Generic;

namespace ZonaSoft.Dominio
{
    public class Producto
    {
        //Atributos
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float PrecioBaseDolar { get; set; }
        public bool EnVenta { get; set; }
        public float PorcentajeGanancia { get; set; }
        public string Comentarios { get; set; }
        public Marca Marca { get; set; }
        public Parametro Parametro { get; set; }
        public Rubro Rubro { get; set; }

        //Fluent API
        public virtual ICollection<LineaReparacion> LineasReparaciones { get; set; }
        public virtual ICollection<LineaVenta> LineasVenta { get; set; }
        public virtual ICollection<LineaCompra> LineasCompra { get; set; }
        public int IdMarca { get; set; }
        public int IdParametro { get; set; }
        public int IdRubro { get; set; }

        //Métodos
        public float ObtenerPrecioDeVenta()
        {
            return PrecioBaseDolar
                + (PrecioBaseDolar * PorcentajeGanancia / 100) //Ganancia
                * Parametro.Valor; //IVA
        }
    }
}
