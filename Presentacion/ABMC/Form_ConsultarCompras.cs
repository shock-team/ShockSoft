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
using ShockSoft.Presentacion.Controladores;
using ShockSoft.Presentacion.Datos;

namespace ShockSoft.Presentacion.ABMC
{
    public partial class Form_ConsultarCompras : Form, IBusquedaDeProductos
    {
        ControladorCompras controlador = ControladorCompras.ObtenerInstancia();
        public Form_ConsultarCompras()
        {
            InitializeComponent();

            txtIdProducto.Text = "0";

            Proveedor ninguno = new Proveedor();
            ninguno.Nombre = "Ninguno";
            ninguno.IdProveedor = 0;
            comboProveedores.Items.Add(ninguno);

            foreach (Proveedor proveedor in ControladorProveedores.ObtenerInstancia().ObtenerProveedores())
            {
                comboProveedores.Items.Add(proveedor);
            }
            comboProveedores.ValueMember = "IdProveedor";
            comboProveedores.DisplayMember = "Nombre";
            comboProveedores.SelectedIndex = 0;

            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgCompras.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;
            Proveedor proveedor = (Proveedor)comboProveedores.SelectedItem ?? new Proveedor { IdProveedor = 0 };
            List<Compra> listaDeCompras = controlador.ListarCompras(proveedor.IdProveedor, int.Parse(txtIdProducto.Text), CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);
            if (listaDeCompras.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Compra compra in listaDeCompras)
            {
                dgCompras.Rows.Add(compra.IdCompra, compra.Fecha, compra.Proveedor.Nombre, compra.ObtenerTotal());
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadDeCompras());
            ActualizarTabla();
        }

        private void ValorCambiado(object sender, System.EventArgs e)
        {
            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;
            lblPaginaActual.Text = "1";
            ActualizarTabla();
        }

        private void DgCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int compraSeleccionada = (int)dgCompras.CurrentRow.Cells[0].Value;
            Form_DatosCompra form_DatosCompra = new Form_DatosCompra(compraSeleccionada);
            this.Hide();
            form_DatosCompra.ShowDialog();
            this.Show();
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            Form_BuscarProducto form_BuscarProducto = new Form_BuscarProducto();
            form_BuscarProducto.Owner = this;
            this.Hide();
            form_BuscarProducto.ShowDialog();
            this.Show();
        }

        public void AgregarProducto(int pIdProducto, int pCantidad = 0)
        {
            txtIdProducto.Text = pIdProducto.ToString();
            Producto productoActual = ControladorProductos.ObtenerInstancia().ObtenerProducto(pIdProducto);
            txtDescripcionProducto.Text = productoActual.Descripcion;
            ActualizarTabla();
        }
    }
}
