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

namespace ShockSoft.Presentacion.ABMC
{
    public partial class Form_AMCLocalidad : Form
    {
        ControladorLocalidades controlador;
        public Form_AMCLocalidad()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblShock.Text = $"{Properties.Settings.Default.AppName}: {this.Text}";

            controlador = ControladorLocalidades.ObtenerInstancia();
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

        public void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgLocalidades.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;

            List<Localidad> listaDeLocalidades = controlador.ListarLocalidades(
                CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1),
                CANTIDAD_POR_PAGINA + 1
                );

            if (listaDeLocalidades.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }

            foreach (Localidad localidad in listaDeLocalidades)
            {
                dgLocalidades.Rows.Add(localidad.IdLocalidad, localidad.Nombre);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadDeLocalidades());
            ActualizarTabla();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarLocalidad(txtAñadirLocalidad.Text);
                ActualizarTabla();
                MessageBox.Show($"La localidad {txtAñadirLocalidad.Text} se ha añadido correctamente", "Aviso");
                txtAñadirLocalidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.ModificarLocalidad(int.Parse(txtModificarID.Text), txtModificarNombre.Text);
                ActualizarTabla();
                MessageBox.Show($"Se ha cambiado el nombre del proveedor a {txtModificarNombre.Text}", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                txtModificarID.Clear();
                txtModificarNombre.Clear();
            }
        }

        private void dgLocalidades_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtModificarID.Text = dgLocalidades.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtModificarNombre.Text = dgLocalidades.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
