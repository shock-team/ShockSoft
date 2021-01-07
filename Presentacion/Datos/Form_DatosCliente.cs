using ShockSoft.Dominio;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShockSoft.Excepciones;
using ShockSoft.Presentacion.ABMC;
using System;
using System.Drawing;

namespace ShockSoft.Presentacion
{
    public partial class Form_DatosCliente : Form
    {
        ControladorClientes controlador = ControladorClientes.ObtenerInstancia();
        
        Cliente _cliente;
        string initDNI;
        string initCUIT;

        public Form_DatosCliente(int idCliente)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblShock.Text = $"{Properties.Settings.Default.AppName}: {this.Text}";
            controlador.OnPagoRegistradoEvent += Controlador_OnPagoRegistradoEvent;

            _cliente = controlador.ObtenerCliente(idCliente);
            txtId.Text = idCliente.ToString();
            txtDNI.Text = _cliente.DNI;
            initDNI = _cliente.DNI;
            txtCUIT.Text = _cliente.CUIT;
            initCUIT = _cliente.CUIT;
            txtNombre.Text = _cliente.Nombre;
            txtApellido.Text = _cliente.Apellido;
            txtTelefono.Text = _cliente.Telefono;
            txtDireccion.Text = _cliente.Direccion;
            ActualizarComboBox();
            txtSaldo.Text = String.Format("{0:C2}",_cliente.ObtenerSaldo());
        }

        private void Controlador_OnPagoRegistradoEvent(object sender, EventArgs e)
        {
            _cliente = controlador.ObtenerCliente(_cliente.IdCliente);
            txtSaldo.Text = String.Format("{0:C2}", _cliente.ObtenerSaldo());
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Localidad localidad = (Localidad)comboLocalidad.SelectedItem;
                if (initDNI != txtDNI.Text)
                {
                    controlador.VerificarDNI(txtDNI.Text);
                }

                if (initCUIT != txtCUIT.Text)
                {
                    controlador.VerificarCUIT(txtCUIT.Text);
                }

                controlador.ModificarCliente(txtDNI.Text, txtCUIT.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, localidad.IdLocalidad, int.Parse(txtId.Text));
                MessageBox.Show("Datos modificados correctamente", "Éxito");

                initDNI = txtDNI.Text;
                initCUIT = txtCUIT.Text;
            }
            catch (DatosRepetidosException)
            {
                MessageBox.Show("Ya existe un cliente con ese DNI o CUIT. Intente nuevamente", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnAgregarPago_Click(object sender, EventArgs e)
        {
            Form_RegistrarPago formRegistrarPago = new Form_RegistrarPago(int.Parse(txtId.Text));
            formRegistrarPago.Show();
        }

        // Deslizar ventana desde el panel de control
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTamano_Click(object sender, EventArgs e)
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnNuevaLocalidad_Click(object sender, EventArgs e)
        {
            Form_AgregarLocalidad formAltaLocalidad = new Form_AgregarLocalidad();
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
                comboLocalidad.Items.Add(localidad);
            }

            comboLocalidad.ValueMember = "IdLocalidad";
            comboLocalidad.DisplayMember = "Nombre";

            foreach (Localidad localidad in comboLocalidad.Items)
            {
                if (localidad.IdLocalidad == _cliente.IdLocalidad)
                {
                    comboLocalidad.SelectedItem = localidad;
                }
            }
        }

        private void BtnHistorialDePagos_Click(object sender, EventArgs e)
        {
            Form_ConsultarPagosCliente form_ConsultarPagosCliente = new Form_ConsultarPagosCliente(int.Parse(txtId.Text));
            this.Hide();
            form_ConsultarPagosCliente.ShowDialog();
            this.Show();
        }
    }
}
