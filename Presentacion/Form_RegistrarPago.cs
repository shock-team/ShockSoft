using ShockSoft.Dominio;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
