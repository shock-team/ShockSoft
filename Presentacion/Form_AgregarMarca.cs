using ShockSoft.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarMarca : Form
    {
        ControladorMarcas controlador = ControladorMarcas.ObtenerInstancia();

        public Form_AgregarMarca()
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.VerificarDatos(txtNombre.Text);
                controlador.AgregarMarca(txtNombre.Text);
                MessageBox.Show("La localidad se ha agregado correctamente", "Exito");
                txtNombre.Clear();
            }
            catch (DatosRepetidosException)
            {
                MessageBox.Show("Ya existe una marca con ese nombre. Intente nuevamente", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error");
            }
        }
    }
}
