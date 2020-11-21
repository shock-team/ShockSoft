using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShockSoft.Excepciones;

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarLocalidad : Form
    {
        ControladorLocalidades controlador = ControladorLocalidades.ObtenerInstancia();
        public Form_AgregarLocalidad()
        {
            InitializeComponent();
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

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                controlador.VerificarDatos(txtNombre.Text);
                controlador.AgregarLocalidad(txtNombre.Text);
                MessageBox.Show("La marca se ha agregado correctamente", "Exito");
                txtNombre.Clear();
            }
            catch (DatosRepetidosException)
            {
                MessageBox.Show("Ya existe una localidad con ese nombre. Intente nuevamente", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
