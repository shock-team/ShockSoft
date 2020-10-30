using System.Collections.Generic;


namespace ShockSoft.Dominio
{
    public class Cliente
    {
        //Atributos
        public int IdCliente { get; set; }
        public string DNI { get; set; }
        public string CUIT { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Localidad Localidad { get; set; }
        public ICollection<Pago> Pagos { get; set; } = new List<Pago>();
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();

        //Fluent API
        public int IdLocalidad { get; set; }
        public ICollection<Reparacion> Reparaciones { get; set; }

        //Métodos
        public float ObtenerSaldo()
        {
            float total = 0;
            foreach (Pago pago in Pagos)
            {
                total += pago.Monto;
            }
            foreach (Venta venta in Ventas)
            {
                total -= venta.ObtenerTotal();
            }
            foreach (Reparacion reparacion in Reparaciones)
            {
                total -= reparacion.Precio;
            }
            return total;
        }

        public void RegistrarPago(Pago pPago)
        {
            Pagos.Add(pPago);
        }

        public void AgregarVenta(Venta pVenta)

        {
            Ventas.Add(pVenta);
        }

    }
}
