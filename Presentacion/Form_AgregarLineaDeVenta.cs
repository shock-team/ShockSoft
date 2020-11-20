using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShockSoft.Dominio;
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarLineaDeVenta : Form, IBusquedaDeProductos
    {
        public Form_AgregarLineaDeVenta()
        {
            InitializeComponent();
        }


        public void AgregarProducto(int pIdProducto)
        {
            txtId.Text = pIdProducto.ToString();
        }

        private void NmCantidad_ValueChanged(object sender, EventArgs e)
        {
            txtSubtotal.Text = (nmCantidad.Value * decimal.Parse(txtPrecioUnitario.Text)).ToString();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form_BuscarProducto formBuscarProducto = new Form_BuscarProducto();
            formBuscarProducto.Owner = this;
            this.Hide();
            formBuscarProducto.ShowDialog();
            this.Show();
            Producto productoSeleccionado = ControladorProductos.ObtenerInstancia().ObtenerProducto(int.Parse(txtId.Text));
            txtDescripcion.Text = productoSeleccionado.Descripcion;
            nmCantidad.Maximum = productoSeleccionado.Cantidad;
            nmCantidad.Enabled = true;
            txtPrecioUnitario.Text = productoSeleccionado.PrecioBaseDolar.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Form_AgregarVenta formAgregarVenta = (Form_AgregarVenta)Owner;
            formAgregarVenta.AgregarLineaDeVenta(txtId.Text, txtDescripcion.Text, txtPrecioUnitario.Text, Convert.ToInt32(nmCantidad.Value));
            MessageBox.Show("Línea agregada exitosamente", "Éxito");
            this.Close();
        }
    }
}
