using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion
{
    public partial class Form_BuscarProducto : Form
    {
        ControladorProductos controlador;
        public List<int> listaDeIDs = new List<int>();

        public Form_BuscarProducto()
        {
            InitializeComponent();
            controlador = ControladorProductos.ObtenerInstancia();
            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;

            //Carga los datos del ComboBox de Marcas
            foreach (Marca marca in ControladorMarcas.ObtenerInstancia().ListarMarcas())
            {
                comboMarca.Items.Add(marca);
            }
            comboMarca.ValueMember = "IdMarca";
            comboMarca.DisplayMember = "Descripcion";

            //Carga los datos del ComboBox de Rubros
            foreach (Rubro rubro in ControladorRubros.ObtenerInstancia().ListarRubros())
            {
                comboRubro.Items.Add(rubro);
            }
            comboRubro.ValueMember = "IdRubro";
            comboRubro.DisplayMember = "Descripcion";

            //Carga los datos a la DataTable
            ActualizarTabla();
        }


        private void ValorCambiado(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgProductos.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;
            Rubro rubro = (Rubro)comboRubro.SelectedItem ?? new Rubro { IdRubro = -1 };
            Marca marca = (Marca)comboMarca.SelectedItem ?? new Marca { IdMarca = -1 };
            List<Producto> listaDeProductos = controlador.ListarProductos(
                    txtDescripcion.Text,
                    false,
                    false,
                    txtId.Text,
                    CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1),
                    CANTIDAD_POR_PAGINA + 1,
                    marca.IdMarca,
                    rubro.IdRubro);

            if (listaDeProductos.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Producto producto in listaDeProductos)
            {
                dgProductos.Rows.Add(producto.IdProducto, producto.Descripcion, producto.Marca.Descripcion, producto.PrecioBaseDolar, producto.Cantidad);
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

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadDeProductos());
            ActualizarTabla();
        }

        private void DgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int productoSeleccionado = (int)dgProductos.CurrentRow.Cells[0].Value;
            if (!(listaDeIDs.Contains(productoSeleccionado)))
            {
                IBusquedaDeProductos owner = (IBusquedaDeProductos)Owner;
                owner.AgregarProducto(productoSeleccionado);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ese producto ya ha sido seleccionado", "Error");
            }
        }
    }
}
