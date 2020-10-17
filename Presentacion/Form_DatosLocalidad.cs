using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShockSoft.Excepciones;
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    public partial class Form_DatosLocalidad : Form
    {
        ControladorLocalidades controlador = ControladorLocalidades.ObtenerInstancia();

        public Form_DatosLocalidad(int pId)
        {
            InitializeComponent();
            txtId.Text = pId.ToString();
            Localidad localidad = controlador.ObtenerLocalidad(pId);
            txtNombre.Text = localidad.Nombre;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string nombreActual = txtNombre.Text;
            try
            {
                controlador.VerificarDatos(txtNombre.Text);
                controlador.ModificarLocalidad(txtNombre.Text, int.Parse(txtId.Text));
                MessageBox.Show("Localidad modificada correctamente", "Éxito");
            }
            catch (Exception)
            {
                MessageBox.Show("Ya existe una localidad con ese nombre. Intente nuevamente", "Error");
                txtNombre.Text = nombreActual;
            }
        }
    }
}
