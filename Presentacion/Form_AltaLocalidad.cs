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
    public partial class Form_AltaLocalidad : Form
    {
        ControladorLocalidades controlador = ControladorLocalidades.ObtenerInstancia();
        public Form_AltaLocalidad()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.VerificarDatos(txtNombre.Text);
                controlador.AgregarLocalidad(txtNombre.Text);
                MessageBox.Show("La localidad se ha agregado correctamente", "Exito");
                txtNombre.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ya existe una localidad con ese nombre. Intente nuevamente", "Error");
            }
        }
    }
}
