using System;
using System.Windows.Forms;
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    public partial class Form_AltaCliente : Form
    {
        ControladorClientes controlador;

        public Form_AltaCliente()
        {
            InitializeComponent();
            foreach (Localidad localidad in ControladorLocalidades.ObtenerInstancia().ListarLocalidades())
            {
                comboLocalidad.Items.Add(localidad);
            }
            comboLocalidad.ValueMember = "IdLocalidad";
            comboLocalidad.DisplayMember = "Nombre";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            controlador.AltaCliente(txtDNI.Text, txtCUIT.Text, txtApellido.Text, txtNombre.Text, txtTelefono.Text, txtDireccion.Text, (int)comboLocalidad.SelectedItem);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
