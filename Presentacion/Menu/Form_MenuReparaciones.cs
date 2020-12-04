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
    public partial class Form_MenuReparaciones : Form
    {
        public Form_MenuReparaciones()
        {
            InitializeComponent();
        }

        private void BtnAltaReparacion_Click(object sender, EventArgs e)
        {
            Form_AgregarReparacion form_AgregarReparacion = new Form_AgregarReparacion();
            this.Hide();
            form_AgregarReparacion.ShowDialog();
            this.Show();
        }

        private void btnConsultaReparacion_Click(object sender, EventArgs e)
        {
            Form_ConsultarReparaciones form_ConsultarReparaciones = new Form_ConsultarReparaciones();
            this.Hide();
            form_ConsultarReparaciones.ShowDialog();
            this.Show();
        }
    }
}
