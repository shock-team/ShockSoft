namespace ShockSoft.Dominio
{
    public class LineaVenta
    {
        public int Cantidad { get; set; }
        public float PrecioActual { get; set; }
        public Producto Producto { get; set; }
    }
}
