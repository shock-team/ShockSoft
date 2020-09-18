using System.Windows.Forms;
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    public partial class Form_DatosCliente : Form
    {
        public Form_DatosCliente(Cliente pCliente)
        {
            InitializeComponent();
            txtId.Text = pCliente.IdCliente.ToString();
            txtDNI.Text = pCliente.DNI;
            txtCUIT.Text = pCliente.CUIT;
            txtNombre.Text = pCliente.Nombre;
            txtApellido.Text = pCliente.Apellido;
            txtTelefono.Text = pCliente.Telefono;
            txtDireccion.Text = pCliente.Direccion;
            foreach (Localidad localidad in ControladorLocalidades.ObtenerInstancia().ListarLocalidades())
            {
                comboLocalidad.Items.Add(localidad);
                if (localidad.Equals(pCliente.Localidad))
                {
                    comboLocalidad.SelectedItem = localidad;
                }
            }
            comboLocalidad.ValueMember = "IdLocalidad";
            comboLocalidad.DisplayMember = "Nombre";
            txtSaldo.Text = pCliente.CuentaCorriente.ObtenerSaldo().ToString();
        }

        private void BtnAceptar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnModificar_Click(object sender, System.EventArgs e)
        {
            Localidad localidad = (Localidad)comboLocalidad.SelectedItem;
            ControladorClientes.ObtenerInstancia().ModificarCliente(txtDNI.Text, txtCUIT.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, localidad.IdLocalidad, int.Parse(txtId.Text));
            MessageBox.Show("Datos modificados con éxito");
        }

        private void BtnAgregarPago_Click(object sender, System.EventArgs e)
        {
            Form_RegistrarPago formRegistrarPago = new Form_RegistrarPago();
            formRegistrarPago.Show();
        }
    }
}
