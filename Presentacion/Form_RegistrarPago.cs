using System;
using System.Windows.Forms;
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    public partial class Form_RegistrarPago : Form
    {
        public Form_RegistrarPago(int pIdCliente)
        {
            InitializeComponent();
            Cliente cliente = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombreYApellido.Text = cliente.Apellido + ", " + cliente.Nombre;
            txtID.Text = cliente.IdCliente.ToString();
            calendarFecha = new MonthCalendar();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //ControladorClientes.ObtenerInstancia().RegistrarPago(int.Parse(txtID.Text), float.Parse(txtMonto.Text), calendarFecha.Se)
        }
    }
}
