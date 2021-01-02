using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShockSoft.Presentacion.Controladores;
using ShockSoft.Presentacion;
using ShockSoft.Dominio;
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion.ABMC
{
    public partial class Form_ConsultarMetodoDePago : Form
    {
        ControladorMetodosPago controlador = ControladorMetodosPago.ObtenerInstancia();

        public Form_ConsultarMetodoDePago()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;
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
        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadDeMetodosDePago());
            ActualizarTabla();
        }

        private void DgMetodosDePago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idMetodoPago = (int)dgMetodosDePago.CurrentRow.Cells[0].Value;
            Form_AMMetodoDePago form_AMMetodoDePago = new Form_AMMetodoDePago(idMetodoPago);

            this.Hide();
            form_AMMetodoDePago.ShowDialog();
            this.Show();

            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;

            lblPaginaActual.Text = "1";

            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dgMetodosDePago.Rows.Clear();

            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;

            int CANTIDAD_POR_PAGINA = 15;
            List<MetodoPago> listaDeMetodos = controlador.ListarMetodosDePago(CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);

            if (listaDeMetodos.Count <= CANTIDAD_POR_PAGINA)
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }

            foreach (MetodoPago metodoPago in listaDeMetodos)
            {
                dgMetodosDePago.Rows.Add(metodoPago.IdMetodoPago, metodoPago.Descripcion, metodoPago.MultiplicadorInteres);
            }
        }
    }
}
