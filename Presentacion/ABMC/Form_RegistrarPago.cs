using ZonaSoft.Dominio;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ZonaSoft.Excepciones;

namespace ZonaSoft.Presentacion
{
    public partial class Form_RegistrarPago : Form
    {
        public Form_RegistrarPago(int pIdCliente)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblShock.Text = $"{Properties.Settings.Default.AppName}: {this.Text}";

            Cliente cliente = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombreYApellido.Text = cliente.Apellido + ", " + cliente.Nombre;
            txtID.Text = cliente.IdCliente.ToString();
        }

        private float VerificarFloat(string pTxtMonto)
        {
            float parsedValue;
            if (!float.TryParse(pTxtMonto, out parsedValue))
            {
                throw new DatosInvalidosException("El monto tiene que ser un valor numérico!");
            }
            return parsedValue;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ControladorClientes.ObtenerInstancia().RegistrarPago(int.Parse(txtID.Text), VerificarFloat(txtMonto.Text), dtpFecha.Value, txtDescripcion.Text);
                MessageBox.Show("El pago ha sido registrado correctamente", "Éxito");
                this.Close();
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtMonto.Clear();
            }
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
    }
}
