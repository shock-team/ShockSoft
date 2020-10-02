using ShockSoft.Dominio;
using System.Windows.Forms;

namespace ShockSoft.Presentacion
{
    public partial class Form_DatosCliente : Form
    {
        ControladorClientes controlador = ControladorClientes.ObtenerInstancia();

        public Form_DatosCliente(int idCliente)
        {
            InitializeComponent();
            Cliente cliente = controlador.ObtenerCliente(idCliente);
            txtId.Text = cliente.IdCliente.ToString();
            txtDNI.Text = cliente.DNI;
            txtCUIT.Text = cliente.CUIT;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;
            foreach (Localidad localidad in ControladorLocalidades.ObtenerInstancia().ListarLocalidades())
            {
                comboLocalidad.Items.Add(localidad);
                if (localidad.Equals(cliente.Localidad))
                {
                    comboLocalidad.SelectedItem = localidad;
                }
            }
            comboLocalidad.ValueMember = "IdLocalidad";
            comboLocalidad.DisplayMember = "Nombre";
            txtSaldo.Text = cliente.ObtenerSaldo().ToString();
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
            Form_RegistrarPago formRegistrarPago = new Form_RegistrarPago(0);
            formRegistrarPago.Show();
        }

        private void btnModificar_Click(object sender, System.EventArgs e)
        {

        }
    }
}
