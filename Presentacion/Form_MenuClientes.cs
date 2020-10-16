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
    public partial class Form_MenuClientes : Form
    {
        public Form_MenuClientes()
        {
            InitializeComponent();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            Form_AltaCliente form_AltaCliente = new Form_AltaCliente();
            form_AltaCliente.Show();
        }

        private void btnConsultarClientes_Click(object sender, EventArgs e)
        {
            Form_ConsultaClientes form_ConsultaCliente = new Form_ConsultaClientes();
            form_ConsultaCliente.Show();
        }
    }
}
