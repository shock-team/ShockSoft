using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion
{
    public partial class Form_ConsultarReparaciones : Form, IBusquedaDeClientes
    {
        ControladorReparaciones controlador = new ControladorReparaciones();
        public Form_ConsultarReparaciones()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void AgregarCliente(int pIdCliente)
        {
            txtIdCliente.Text = pIdCliente.ToString();
            Cliente clienteActual = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombreCliente.Text = FormsHelper.NameFormatter(clienteActual.Nombre, clienteActual.Apellido);
        }

        private void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgReparaciones.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;

            int idCliente;
            if (txtIdCliente.TextLength > 0)
            {
                idCliente = int.Parse(txtIdCliente.Text);
            }
            else
            {
                idCliente = 0;
            }
            
            List<Reparacion> listaDeReparaciones = controlador.ListarReparaciones(idCliente, cbReparado.Checked, cbEntregado.Checked,cbCobrado.Checked, CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);

            if (listaDeReparaciones.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Reparacion rep in listaDeReparaciones)
            {
                dgReparaciones.Rows.Add(rep.IdReparacion, rep.FechaIngreso, FormsHelper.NameFormatter(rep.Cliente.Nombre, rep.Cliente.Apellido), rep.Rubro.Descripcion, rep.Problema, rep.Entregado );
            }
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form_ConsultarClientes form_ConsultarClientes = new Form_ConsultarClientes();
            form_ConsultarClientes.Owner = this;
            this.Hide();
            form_ConsultarClientes.ShowDialog();
            this.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadReparaciones());
            ActualizarTabla();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e) => ActualizarTabla();
        private void cbReparado_CheckedChanged(object sender, EventArgs e) => ActualizarTabla();
        private void cbCobrado_CheckedChanged(object sender, EventArgs e) => ActualizarTabla();
        private void cbEntregado_CheckedChanged(object sender, EventArgs e) => ActualizarTabla();

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            txtIdCliente.Clear();
            txtNombreCliente.Clear();
            cbCobrado.Checked = false;
            cbEntregado.Checked = false;
            cbReparado.Checked = false;
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

        private void DgReparaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int reparacionSeleccionada = (int)dgReparaciones.CurrentRow.Cells[0].Value;
            Form_AMReparacion form_DatosReparacion = new Form_AMReparacion(reparacionSeleccionada);
            this.Hide();
            form_DatosReparacion.ShowDialog();
            this.Show();
        }
    }
}
