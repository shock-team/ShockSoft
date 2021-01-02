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
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion
{
    public partial class Form_DatosLocalidad : Form
    {
        ControladorLocalidades controlador = ControladorLocalidades.ObtenerInstancia();

        public Form_DatosLocalidad(int pId)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

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
                controlador.ModificarLocalidad(int.Parse(txtId.Text), txtNombre.Text);
                MessageBox.Show("Localidad modificada correctamente", "Éxito");
            }
            catch (Exception)
            {
                MessageBox.Show("Ya existe una localidad con ese nombre. Intente nuevamente", "Error");
                txtNombre.Text = nombreActual;
            }
        }


        // Deslizar ventana desde el panel de control
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTamano_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
