using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShockSoft.Presentacion
{
    public partial class Form_MenuProducto : Form
    {
        public Form_MenuProducto()
        {
            InitializeComponent();
        }

        private void btnAltaProducto_Click(object sender, EventArgs e)
        {
            Form_AñadirProducto form_AñadirProducto = new Form_AñadirProducto();
            form_AñadirProducto.Show();
        }

        private void btnConsultaProducto_Click(object sender, EventArgs e)
        {
            Form_ConsultarProducto form_ConsultarProducto = new Form_ConsultarProducto();
            form_ConsultarProducto.Show();
        }
    }
}
