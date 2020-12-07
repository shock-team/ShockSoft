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
using ShockSoft.Presentacion.Datos;

namespace ShockSoft.Presentacion
{
    public partial class Form_ConsultarVentas : Form, IBusquedaDeClientes, IBusquedaDeProductos
    {
        ControladorVentas controlador = ControladorVentas.ObtenerInstancia();
        public Form_ConsultarVentas()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void AgregarCliente(int pIdCliente)
        {
            txtIdCliente.Text = pIdCliente.ToString();
            Cliente clienteActual = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombreCliente.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
            ActualizarTabla();
        }

        public void AgregarProducto(int pIdProducto, int pProducto = 0)
        {
            txtIdProducto.Text = pIdProducto.ToString();
            Producto productoActual = ControladorProductos.ObtenerInstancia().ObtenerProducto(pIdProducto);
            txtDescripcionProducto.Text = productoActual.Descripcion;
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgVentas.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;

            int idCliente = 0;
            if (txtIdCliente.Text.Length > 0)
            {
                idCliente = int.Parse(txtIdCliente.Text);
            }

            int idProducto = 0;
            if (txtIdProducto.Text.Length > 0)
            {
                idProducto = int.Parse(txtIdProducto.Text);
            }

            if (lblPaginaActual.Text == "1")
            {
                btnAnterior.Enabled = false;
                btnAnterior.Visible = false;
            }

            List<Venta> listaDeVentas = controlador.ListarVentas(idCliente, idProducto, CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);

            if (listaDeVentas.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Venta venta in listaDeVentas)
            {
                dgVentas.Rows.Add(venta.IdVenta, venta.Fecha, venta.Cliente.Nombre + " " + venta.Cliente.Apellido, venta.ObtenerTotal());
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form_ConsultarClientes form_ConsultarClientes = new Form_ConsultarClientes();
            form_ConsultarClientes.Owner = this;
            this.Hide();
            form_ConsultarClientes.ShowDialog();
            this.Show();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            Form_BuscarProducto form_BuscarProducto = new Form_BuscarProducto();
            form_BuscarProducto.Owner = this;
            this.Hide();
            form_BuscarProducto.ShowDialog();
            this.Show();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadDeVentas());
            ActualizarTabla();
        }

        private void DgVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ventaSeleccionada = (int)dgVentas.CurrentRow.Cells[0].Value;
            Form_DatosVenta form_DatosVenta = new Form_DatosVenta(ventaSeleccionada);
            this.Hide();
            form_DatosVenta.ShowDialog();
            this.Show();
        }
    }
}
