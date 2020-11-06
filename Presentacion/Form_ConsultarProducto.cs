using System.Windows.Forms;
using ShockSoft.Dominio;
using System.Data;

namespace ShockSoft.Presentacion
{
    public partial class Form_ConsultarProducto : Form
    {
        ControladorProductos controlador;
        DataTable tablaDeProductos;
        public Form_ConsultarProducto()
        {
            InitializeComponent();
            controlador = ControladorProductos.ObtenerInstancia();
            /*
            //Genera una DataTable que muestre los datos especificados
            tablaDeProductos = new DataTable();
            tablaDeProductos.Columns.AddRange(new DataColumn[5]
            {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Descripción", typeof(string)),
                new DataColumn("Marca", typeof(string)),
                new DataColumn("Cantidad", typeof(int)),
                new DataColumn("Precio", typeof(float))
            });
            
            dgProductos.DataSource = tablaDeProductos;
            */
            //Carga los datos a la DataTable
            ActualizarTabla();
        }

        private void ValorCambiado(object sender, System.EventArgs e)
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dgProductos.Rows.Clear();
            foreach (Producto producto in controlador.ListarProductos(txtDescripcion.Text, cbMostrarProductosBaja.Checked, cbSinStock.Checked, int.Parse(txtId.Text)))
            {
                dgProductos.Rows.Add(producto.IdProducto, producto.Descripcion, producto.Marca.Descripcion, producto.Cantidad, producto.PrecioBaseDolar);
            }
        }

        private void BtnAnterior_Click(object sender, System.EventArgs e)
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            lblPaginaActual.Text = (int.Parse(lblPaginaActual.Text) - 1).ToString();
            if (lblPaginaActual.Text.Equals("1"))
            {
                btnAnterior.Enabled = false;
                btnAnterior.Visible = false;
            }
            ActualizarTabla();
        }

        private void BtnSiguiente_Click(object sender, System.EventArgs e)
        {
            if (lblPaginaActual.Text.Equals("1"))
            {
                btnAnterior.Enabled = true;
                btnAnterior.Visible = true;
            }
            lblPaginaActual.Text = (int.Parse(lblPaginaActual.Text) + 1).ToString();
            if (int.Parse(lblPaginaActual.Text) >= (controlador.ObtenerCantidadDeProductos() / 15))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            ActualizarTabla();
        }
    }
}
