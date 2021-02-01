namespace ZonaSoft.Dominio
{
    public class LineaCompra
    {
        //Atributos
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioActual { get; set; }

        //Fluent API
        public Compra Compra { get; set; }
        public int IdProducto { get; set; }
        public int IdLineaCompra { get; set; }
        public int IdCompra { get; set; }

        //Métodos
        public float ObtenerSubtotal()
        {
            return this.PrecioActual * this.Cantidad;
        }
    }
}
