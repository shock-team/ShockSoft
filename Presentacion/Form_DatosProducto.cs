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
    public partial class Form_DatosProducto : Form
    {
        ControladorProductos controlador = ControladorProductos.ObtenerInstancia();

        public Form_DatosProducto(int pIdProducto)
        {
            InitializeComponent();
            
            //Obtiene los datos del producto y los carga en los espacios correspondientes
            Producto producto = controlador.ObtenerProducto(pIdProducto);
            txtId.Text = producto.IdProducto.ToString();
            txtDescripcion.Text = producto.Descripcion;
            txtCantidad.Text = producto.Cantidad.ToString();
            txtPrecio.Text = producto.PrecioBaseDolar.ToString();
            txtPorcentajeDeGanancia.Text = producto.PorcentajeGanancia.ToString();
            //txtMarca.Text = ControladorMarcas.ObtenerInstancia().Obtener(producto.IdMarca).Descripcion;
            if (producto.EnVenta)
            {
                txtEnVenta.Text = "Sí";
            }
            else
            {
                txtEnVenta.Text = "No";
            }

            //Carga los IVAs en el combobox
            foreach (Parametro parametro in ControladorParametros.ObtenerInstancia().ListarParametros())
            {
                if (!(parametro is PrecioDolar))
                {
                    comboIVA.Items.Add(parametro);
                    if (producto.IdParametro == parametro.IdParametro)
                    {
                        comboIVA.SelectedItem = parametro;
                    }
                }
            }
            comboIVA.DisplayMember = "Descripcion";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            controlador.ModificarProducto(txtDescripcion.Text, float.Parse(txtPrecio.Text), float.Parse(txtPorcentajeDeGanancia.Text), ((IVA)comboIVA.SelectedItem).IdParametro, int.Parse(txtId.Text));
        }

        private void btnAltaBaja_Click(object sender, EventArgs e)
        {
            controlador.DarDeBaja(int.Parse(txtId.Text));
            if (txtEnVenta.Text == "Sí")
            {
                txtEnVenta.Text = "No";
            }
            else
            {
                txtEnVenta.Text = "Sí";
            }
        }

        private void btnHistorialCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorialVenta_Click(object sender, EventArgs e)
        {

        }
    }
}
