using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShockSoft.Dominio
{
	public class Reparacion
	{
        public int Id { get; set; }
        public string Problema { get; set; }
        public string Solucion { get; set; }
        public string Contraseña { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaReparacion { get; set; }
        public float Precio { get; set; }
        public bool Entregado { get; set; }
        public bool Cargador { get; set; }
        public bool Cables { get; set; }
        public TipoEquipo TipoEquipo { get; set; }
        public Cliente Cliente { get; set; }
        public CuentaCorriente CuentaCorriente { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public Marca MarcaEquipo { get; set; }
        public List<Producto> Productos { get; set; }

        public float getPrecioTotal()
        {
            float total = Precio;
            foreach (var Producto in Productos)
            {
                total += Producto.ObtenerPrecioDeVenta();
            }
        }

    }
}
