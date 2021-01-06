using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShockSoft.Dominio;
using ShockSoft.Presentacion.Controladores;
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion.ABMC
{
    public partial class Form_AMMetodoDePago : Form
    {
        ControladorMetodosPago controlador = ControladorMetodosPago.ObtenerInstancia();

        public Form_AMMetodoDePago(int pIdMetodoPago = 0)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblShock.Text = $"{Properties.Settings.Default.AppName}: {this.Text}";

            txtIdMetodoPago.Text = pIdMetodoPago.ToString();
            if (pIdMetodoPago != 0)
            {
                lblNuevoMetodoPago.Visible = false;
                MetodoPago metodoPago = controlador.ObtenerMetodoDePago(pIdMetodoPago);
                txtDescripcion.Text = metodoPago.Descripcion;
                txtValorMuliplicador.Text = metodoPago.MultiplicadorInteres.ToString();
            }
            else
            {
                lblIdMetodoPago.Visible = false;
                txtIdMetodoPago.Visible = false;
            }
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

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtIdMetodoPago.Text == "0")
            {
                controlador.AgregarMetodoDePago(txtDescripcion.Text, float.Parse(txtValorMuliplicador.Text));
                MessageBox.Show("Método de pago agregado correctamente", "Éxito");
            }
            else
            {
                controlador.ModificarMetodoDePago(txtDescripcion.Text, float.Parse(txtValorMuliplicador.Text), int.Parse(txtIdMetodoPago.Text));
                MessageBox.Show("Método de pago modificado correctamente", "Éxito");
            }
            this.Close();
        }

        private void TxtValorMuliplicador_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (caracter == 46 && txtValorMuliplicador.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(caracter) && caracter != 8 && caracter != 44)
            {
                e.Handled = true;
            }
        }
    }
}
