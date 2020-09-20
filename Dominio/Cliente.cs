namespace ShockSoft.Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string DNI { get; set; }
        public string CUIT { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Localidad Localidad { get; set; }
        public CuentaCorriente CuentaCorriente { get; set; }

        //Fluent API
        public int IdLocalidad { get; set; }

        public void RegistrarPago(Pago pPago)
        {
            CuentaCorriente.AgregarPago(pPago);
        }
    }
}
