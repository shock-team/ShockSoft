namespace ShockSoft.Dominio
{
    public class LineaCompra
    {
        //Atributos
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioActual { get; set; }
        public Compra Compra { get; set; }

        //Fluent API
        public int IdProducto { get; set; }
        public int IdLineaCompra { get; set; }
        public int IdCompra { get; set; }
    }
}
