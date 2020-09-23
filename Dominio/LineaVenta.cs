namespace ShockSoft.Dominio
{
    public class LineaVenta
    {
        //Atributos
        public int Cantidad { get; set; }
        public float PrecioActual { get; set; }
        public Producto Producto { get; set; }
        public Venta Venta { get; set; }

        //Fluent API
        public int IdLineaVenta { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }
    }
}
