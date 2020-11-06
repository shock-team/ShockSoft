using ShockSoft.Dominio;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShockSoft.Excepciones;

namespace ShockSoft.Presentacion
{
    public partial class Form_DatosCliente : Form
    {
        ControladorClientes controlador = ControladorClientes.ObtenerInstancia();

        public Form_DatosCliente(int idCliente)
        {
            InitializeComponent();
            Cliente cliente = controlador.ObtenerCliente(idCliente);
            txtId.Text = idCliente.ToString();
            txtDNI.Text = cliente.DNI;
            txtCUIT.Text = cliente.CUIT;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtDireccion.Text = cliente.Direccion;
            ActualizarComboBox();
            txtSaldo.Text = cliente.ObtenerSaldo().ToString();
        }


        private void BtnModificar_Click(object sender, System.EventArgs e)
        {
            string dniActual = txtDNI.Text;
            string cuitActual = txtCUIT.Text;
            try
            {
                Localidad localidad = (Localidad)comboLocalidad.SelectedItem;
                controlador.VerificarDatos(txtDNI.Text, txtCUIT.Text);
                controlador.ModificarCliente(txtDNI.Text, txtCUIT.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, localidad.IdLocalidad, int.Parse(txtId.Text));
                MessageBox.Show("Datos modificados correctamente", "Éxito");
            }
            catch (DatosRepetidosException)
            {
                MessageBox.Show("Ya existe un cliente con ese DNI o CUIT. Intente nuevamente", "Error");
                txtDNI.Text = dniActual;
                txtCUIT.Text = cuitActual;
            }
        }

        private void BtnAgregarPago_Click(object sender, System.EventArgs e)
        {
            Form_RegistrarPago formRegistrarPago = new Form_RegistrarPago(int.Parse(txtId.Text));
            formRegistrarPago.Show();
        }

        // Deslizar ventana desde el panel de control
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnTamano_Click(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnNuevaLocalidad_Click(object sender, System.EventArgs e)
        {
            Form_AltaLocalidad formAltaLocalidad = new Form_AltaLocalidad();
            this.Hide();
            formAltaLocalidad.ShowDialog();
            this.Show();
            ActualizarComboBox();
        }

        private void ActualizarComboBox()
        {
            comboLocalidad.Items.Clear();
            foreach (Localidad localidad in ControladorLocalidades.ObtenerInstancia().ListarLocalidades())
            {
                Cliente cliente = controlador.ObtenerCliente(int.Parse(txtId.Text));
                comboLocalidad.Items.Add(localidad);
                if (localidad.IdLocalidad == cliente.IdLocalidad)
                {
                    comboLocalidad.SelectedItem = localidad;
                }
            }
            comboLocalidad.ValueMember = "IdLocalidad";
            comboLocalidad.DisplayMember = "Nombre";
            comboLocalidad.SelectedIndex = comboLocalidad.Items.Count - 1;
        }
    }
}
