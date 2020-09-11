namespace ShockSoft.Dominio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float PrecioBaseDolar { get; set; }
        public bool EnVenta { get; set; }
        public float PorcentajeGanancia { get; set; }
        public Marca Marca { get; set; }
        public IVA IVA { get; set; }

        public float ObtenerPrecioDeVenta()
        {
            return PrecioBaseDolar
                + (PrecioBaseDolar * PorcentajeGanancia / 100) //Ganancia
                * IVA.Valor; //IVA
        }
    }
}
