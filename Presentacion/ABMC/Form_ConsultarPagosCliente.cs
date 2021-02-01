using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZonaSoft.Dominio;
using ZonaSoft.Presentacion.Controladores;
using System.Runtime.InteropServices;

namespace ZonaSoft.Presentacion.ABMC
{
    public partial class Form_ConsultarPagosCliente : Form
    {
        ControladorClientes controlador = ControladorClientes.ObtenerInstancia();
        Cliente clienteActual;

        public Form_ConsultarPagosCliente(int pIdCliente)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblShock.Text = $"{Properties.Settings.Default.AppName}: {this.Text}";

            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;

            clienteActual = controlador.ObtenerCliente(pIdCliente);
            txtIdCliente.Text = pIdCliente.ToString();
            txtNombreCliente.Text = FormsHelper.NameFormatter(clienteActual.Nombre, clienteActual.Apellido);
            txtSaldo.Text = clienteActual.ObtenerSaldo().ToString();
            ActualizarTabla();
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

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizarTabla()
        {
            int CANTIDAD_POR_PAGINA = 15;
            dgPagos.Rows.Clear();

            clienteActual = controlador.ObtenerCliente(int.Parse(txtIdCliente.Text));
            IEnumerable<Pago> listaDePagos = clienteActual.Pagos.OrderBy(x => x.Fecha).Skip(CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1)).Take(CANTIDAD_POR_PAGINA);

            if (listaDePagos.Count() < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }

            foreach (Pago pago in listaDePagos)
            {
                dgPagos.Rows.Add(pago.IdPago, pago.Fecha, pago.Descripcion, pago.Monto);
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Cliente clienteActual = controlador.ObtenerCliente(int.Parse(txtIdCliente.Text));
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, clienteActual.Pagos.Count());
            ActualizarTabla();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }
    }
}
