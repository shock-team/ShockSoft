using ShockSoft.Dominio;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShockSoft.Excepciones;
using System.Drawing;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarCliente : Form
    {
        ControladorClientes controlador;

        public Form_AgregarCliente()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            controlador = ControladorClientes.ObtenerInstancia();
            ActualizarComboBox();
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AltaCliente(txtDNI.Text, txtCUIT.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, ((Localidad)comboLocalidad.SelectedItem).IdLocalidad);
                MessageBox.Show("El cliente se ha agregado correctamente", "Exito");

                txtDNI.Clear();
                txtTelefono.Clear();
                txtCUIT.Clear();
                txtDireccion.Clear();
                txtApellido.Clear();
                txtNombre.Clear();
                comboLocalidad.SelectedIndex = 0;
            }
            catch (DatosFaltantesException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (DatosRepetidosException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNuevaLocalidad_Click(object sender, EventArgs e)
        {
            Form_AgregarLocalidad formAltaLocalidad = new Form_AgregarLocalidad();
            this.Hide();
            formAltaLocalidad.ShowDialog();
            this.Show();
            ActualizarComboBox();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarComboBox()
        {
            comboLocalidad.Items.Clear();
            foreach (Localidad localidad in ControladorLocalidades.ObtenerInstancia().ListarLocalidades())
            {
                comboLocalidad.Items.Add(localidad);

                if (localidad.Nombre == "Urdinarrain")
                {
                    comboLocalidad.SelectedIndex = comboLocalidad.Items.Count - 1;
                }
            }
            comboLocalidad.ValueMember = "IdLocalidad";
            comboLocalidad.DisplayMember = "Nombre";
        }
    }
}
