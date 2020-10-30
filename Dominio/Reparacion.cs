using System;
using System.Collections.Generic;

namespace ShockSoft.Dominio
{
    public class Reparacion
    {
        //Atributos
        public int IdReparacion { get; set; }
        public string Problema { get; set; }
        public string Solucion { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaReparacion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public float Precio { get; set; }
        public bool Entregado { get; set; }
        public bool Cobrado { get; set; }
        public bool Cargador { get; set; }
        public bool Cables { get; set; }
        public Rubro TipoEquipo { get; set; }
        public Cliente Cliente { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public Marca Marca { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }

        //Fluent API
        public int IdCliente { get; set; }
        public int IdRubro { get; set; }
        public int IdMarca { get; set; }
        public int IdMetodoPago { get; set; }

        public Reparacion()
        {
            this.Productos = new HashSet<Producto>();
        }

        //Métodos
        public float getPrecioTotal()
        {
            float total = Precio;
            foreach (var Producto in Productos)
            {
                total += Producto.ObtenerPrecioDeVenta();
            }
            return total;
        }

    }
}
