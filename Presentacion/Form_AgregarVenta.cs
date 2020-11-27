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
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarVenta : Form, IBusquedaDeClientes, IAgregarLinea
    {
        ControladorVentas controlador = ControladorVentas.ObtenerInstancia();

        public Form_AgregarVenta()
        {
            InitializeComponent();
            foreach (MetodoPago metodoDePago in ControladorMetodosPago.ObtenerInstancia().ListarMetodosDePago())
            {
                comboMetodoPago.Items.Add(metodoDePago);
            }
            comboMetodoPago.DisplayMember = "Descripcion";
            comboMetodoPago.ValueMember = "IdMetodoPago";
        }



        public void AgregarLinea(string pIdProducto, string pDescripcion, string pPrecioActual, int pCantidad)
        {
            dglineasDeVenta.Rows.Add(pIdProducto, pDescripcion, pPrecioActual, pCantidad, double.Parse(pPrecioActual)*pCantidad);
            double total = 0;
            foreach (DataGridViewRow fila in dglineasDeVenta.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    total += (double)fila.Cells[4].Value;
                }
            }
            txtTotal.Text = total.ToString();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idVenta = controlador.AgregarVenta(int.Parse(txtId.Text), ((MetodoPago)comboMetodoPago.SelectedItem).IdMetodoPago, dtpFechaVenta.Value);
            controlador.GenerarLineasDeVenta(dglineasDeVenta.Rows, idVenta);
            MessageBox.Show("La venta se ha registrado exitosamente", "Éxito");
            this.Close();
        }

        public void AgregarCliente(int pIdCliente)
        {
            txtId.Text = pIdCliente.ToString();
            Cliente clienteActual = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombre.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
        }

        private void btnAgregarLinea_Click(object sender, EventArgs e)
        {
            List<int> listaDeIDs = new List<int>();
            foreach (DataGridViewRow fila in dglineasDeVenta.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    listaDeIDs.Add(int.Parse(fila.Cells[0].Value.ToString()));
                }
            }
            Form_AgregarLineaDeVenta formAgregarLineaDeVenta = new Form_AgregarLineaDeVenta();
            formAgregarLineaDeVenta.Owner = this;
            formAgregarLineaDeVenta.listaDeIDs = listaDeIDs;
            this.Hide();
            formAgregarLineaDeVenta.ShowDialog();
            this.Show();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form_ConsultarClientes form_ConsultaClientes = new Form_ConsultarClientes();
            form_ConsultaClientes.Owner = this;
            this.Hide();
            form_ConsultaClientes.ShowDialog();
            this.Show();
        }
    }
}
