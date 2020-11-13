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

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarLineaDeVenta : Form
    {
        public Form_AgregarLineaDeVenta()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Form_BuscarProducto formBuscarProducto = new Form_BuscarProducto();
            formBuscarProducto.Owner = this;
            this.Hide();
            formBuscarProducto.ShowDialog();
            this.Show();
            Producto productoSeleccionado = ControladorProductos.ObtenerInstancia().ObtenerProducto(int.Parse(txtId.Text));
            txtDescripcion.Text = productoSeleccionado.Descripcion;
            nmCantidad.Maximum = productoSeleccionado.Cantidad;
            nmCantidad.Enabled = true;
            txtPrecioUnitario.Text = productoSeleccionado.PrecioBaseDolar.ToString();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Form_AgregarVenta formAgregarVenta = (Form_AgregarVenta)Owner;
            formAgregarVenta.AgregarLineaDeVenta(txtId.Text, txtDescripcion.Text, txtPrecioUnitario.Text, Convert.ToInt32(nmCantidad.Value));
            MessageBox.Show("Línea agregada exitosamente", "Éxito");
            this.Close();
        }

        public void AgregarProducto(int pIdProducto)
        {
            txtId.Text = pIdProducto.ToString();
        }

        private void NmCantidad_ValueChanged(object sender, EventArgs e)
        {
            txtSubtotal.Text = (nmCantidad.Value * decimal.Parse(txtPrecioUnitario.Text)).ToString();
        }
    }
}
