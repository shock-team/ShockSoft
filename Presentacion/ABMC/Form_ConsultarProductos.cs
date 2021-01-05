using System.Windows.Forms;
using ShockSoft.Dominio;
using System.Data;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System;
using System.Drawing;

namespace ShockSoft.Presentacion
{
    public partial class Form_ConsultarProductos : Form
    {
        ControladorProductos controlador;
        ControladorParametros parametros;
        public List<int> listaDeIDs;
        float _precioDolar;

        public Form_ConsultarProductos()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            controlador = ControladorProductos.ObtenerInstancia();
            parametros = ControladorParametros.ObtenerInstancia();
            parametros.OnDolarChangedEvent += Parametros_OnDolarChangedEvent;

            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;

            CargarDatos();
        }

        private void CargarDatos()
        {
            //Carga los datos del ComboBox de Marcas
            //comboMarca.Items.Add(new Marca
            //{
            //    IdMarca = -1,
            //    Descripcion = "Sin Filtro"
            //});

            foreach (Marca marca in ControladorMarcas.ObtenerInstancia().ListarMarcas())
            {
                comboMarca.Items.Add(marca);
            }
            comboMarca.ValueMember = "IdMarca";
            comboMarca.DisplayMember = "Descripcion";

            //Carga los datos del ComboBox de Rubros
            //comboRubro.Items.Add(new Rubro
            //{
            //    IdRubro = -1,
            //    Descripcion = "Sin Filtro"
            //});
            foreach (Rubro rubro in ControladorRubros.ObtenerInstancia().ListarRubros())
            {
                comboRubro.Items.Add(rubro);
            }
            comboRubro.ValueMember = "IdRubro";
            comboRubro.DisplayMember = "Descripcion";

            //Cargar precio dólar
            _precioDolar = parametros.ObtenerPrecioDolar();
            lblPrecioDolar.Text = String.Format("{0:C2}", _precioDolar);

            ActualizarTabla();
        }

        private void Parametros_OnDolarChangedEvent(object sender, Parametro e)
        {
            _precioDolar = parametros.ObtenerPrecioDolar();
            lblPrecioDolar.Text = String.Format("{0:C2}", _precioDolar);
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
                float precio = producto.IdProducto != 0 ? producto.ObtenerPrecioDeVenta() * _precioDolar : 0;
                
                dgProductos.Rows.Add(producto.IdProducto, producto.Descripcion, producto.Marca.Descripcion, precio, producto.Cantidad);
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

        private void dgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtiene el producto seleccionado a partir de su ID
            int productoSeleccionado = (int)dgProductos.CurrentRow.Cells[0].Value;
            if (!(Owner == null))
            {
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
            else
            {
                Form_DatosProducto formDatosProducto = new Form_DatosProducto(productoSeleccionado);
                formDatosProducto.FormClosing += FormDatosProducto_FormClosing;
                this.Hide();
                formDatosProducto.ShowDialog();
                this.Show();
            }
        }

        private void FormDatosProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            ActualizarTabla();
        }

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            comboMarca.SelectedIndex = -1;
            comboRubro.SelectedIndex = -1;
            txtDescripcion.Text = string.Empty;
            txtId.Text = string.Empty;
            cbMostrarProductosBaja.Checked = false;
            cbSinStock.Checked = false;

            ActualizarTabla();
        }
    }
}
