using System.Windows.Forms;
using ShockSoft.Dominio;
using System.Data;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;

namespace ShockSoft.Presentacion
{
    public partial class Form_ConsultarProductos : Form
    {
        ControladorProductos controlador;
        public Form_ConsultarProductos()
        {
            InitializeComponent();
            controlador = ControladorProductos.ObtenerInstancia();
            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;

            //Carga los datos del ComboBox de Marcas
            comboMarca.Items.Add(new Marca
            {
                IdMarca = -1,
                Descripcion = "Sin Filtro"
            });

            foreach (Marca marca in ControladorMarcas.ObtenerInstancia().ListarMarcas())
            {
                comboMarca.Items.Add(marca);
            }
            comboMarca.ValueMember = "IdMarca";
            comboMarca.DisplayMember = "Descripcion";

            //Carga los datos del ComboBox de Rubros
            comboRubro.Items.Add(new Rubro
            {
                IdRubro = -1,
                Descripcion = "Sin Filtro"
            });
            foreach (Rubro rubro in ControladorRubros.ObtenerInstancia().ListarRubros())
            {
                comboRubro.Items.Add(rubro);
            }
            comboRubro.ValueMember = "IdRubro";
            comboRubro.DisplayMember = "Descripcion";

            //Carga los datos a la DataTable
            ActualizarTabla();
        }

        private void ValorCambiado(object sender, System.EventArgs e)
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
                    cbMostrarProductosBaja.Checked, 
                    cbSinStock.Checked, 
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

        private void btnMinimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTamano_Click(object sender, System.EventArgs e)
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

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnAnterior_Click(object sender, System.EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void btnSiguiente_Click(object sender, System.EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadDeProductos());
            ActualizarTabla();
        }

        private void DgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtiene el cliente seleccionado a partir de su ID
            int productoSeleccionado = (int)dgProductos.CurrentRow.Cells[0].Value;
            Form_DatosProducto formDatosProducto = new Form_DatosProducto(productoSeleccionado);
            this.Hide();
            formDatosProducto.ShowDialog();
            this.Show();
        }
    }
}
