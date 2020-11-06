using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShockSoft.Presentacion
{
    public partial class Form_BuscarProducto : Form
    {
        ControladorProductos controlador;

        public Form_BuscarProducto()
        {
            InitializeComponent();
            InitializeComponent();
            controlador = ControladorProductos.ObtenerInstancia();
            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;

            //Carga los datos del ComboBox de Marcas
            foreach (Marca marca in ControladorMarcas.ObtenerInstancia().ListarMarcas())
            {
                comboMarca.Items.Add(marca);
            }

            //Carga los datos del ComboBox de Marcas
            foreach (Rubro rubro in ControladorRubros.ObtenerInstancia().ListarRubros())
            {
                comboRubro.Items.Add(rubro);
            }

            //Carga los datos a la DataTable
            ActualizarTabla();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
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

        private void BtnAnterior_Click(object sender, EventArgs e)
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
            List<Producto> listaDeProductos = controlador.ListarProductos(txtDescripcion.Text, false, false, txtId.Text, CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);
            if (listaDeProductos.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Producto producto in listaDeProductos)
            {
                if (!(producto == null))
                {
                    dgProductos.Rows.Add(producto.IdProducto, producto.Descripcion, producto.Marca.Descripcion, producto.PrecioBaseDolar, producto.Cantidad);
                }
            }
        }
    }
}
