using ZonaSoft.Presentacion.ABMC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZonaSoft.Presentacion
{
    public partial class Form_MenuProducto : Form
    {
        public Form_MenuProducto()
        {
            InitializeComponent();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            Form_AgregarProducto form_AñadirProducto = new Form_AgregarProducto();
            form_AñadirProducto.Show();
        }

        private void btnConsultaProducto_Click(object sender, EventArgs e)
        {
            Form_ConsultarProductos form_ConsultarProducto = new Form_ConsultarProductos();
            form_ConsultarProducto.Show();
        }

        private void btnABMParametro_Click(object sender, EventArgs e)
        {
            Form_ABMParametro form_ABMParametro = new Form_ABMParametro();
            form_ABMParametro.Show();
        }

        private void btnConsultaMarca_Click(object sender, EventArgs e)
        {
            Form_ConsultarMarca form_ConsultarMarca = new Form_ConsultarMarca();
            form_ConsultarMarca.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Form_AMCProveedor form_AMCProveedor = new Form_AMCProveedor();
            form_AMCProveedor.Show();
        }

        private void btnRubros_Click(object sender, EventArgs e)
        {
            Form_AMCRubro form_AMCRubro = new Form_AMCRubro();
            form_AMCRubro.Show();
        }
    }
}
