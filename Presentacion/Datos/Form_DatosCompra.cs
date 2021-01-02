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

namespace ShockSoft.Presentacion.Datos
{
    public partial class Form_DatosCompra : Form
    {
        ControladorCompras controlador = ControladorCompras.ObtenerInstancia();
        public Form_DatosCompra(int pIdCompra)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            txtIdCompra.Text = pIdCompra.ToString();
            Compra compra = controlador.ObtenerCompra(pIdCompra);

            comboProveedores.Items.Add(compra.Proveedor);
            comboProveedores.SelectedIndex = 0;
            comboProveedores.DisplayMember = "Nombre";

            txtTotal.Text = compra.ObtenerTotal().ToString();
            dtpFecha.Value = compra.Fecha;

            foreach (LineaCompra lineaCompra in compra.LineasCompra)
            {
                dgLineasDeCompra.Rows.Add(lineaCompra.IdLineaCompra, lineaCompra.Producto.Descripcion, lineaCompra.PrecioActual, lineaCompra.Cantidad, lineaCompra.ObtenerSubtotal());
            }
        }
    }
}
