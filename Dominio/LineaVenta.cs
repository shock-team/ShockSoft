namespace ShockSoft.Dominio
{
    public class LineaVenta
    {
        //Atributos
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioActual { get; set; }

        //Fluent API
        public Venta Venta { get; set; }
        public int IdLineaVenta { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

        //Métodos
        public double ObtenerSubtotal()
        {
            return this.PrecioActual * this.Cantidad;
        }
    }
}
