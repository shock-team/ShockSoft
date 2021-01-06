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
using ShockSoft.Presentacion.Controladores;
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion.Datos
{
    public partial class Form_DatosCompra : Form
    {
        ControladorCompras controlador = ControladorCompras.ObtenerInstancia();
        public Form_DatosCompra(int pIdCompra)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            txtIdCompra.Text = pIdCompra.ToString();
            Compra compra = controlador.ObtenerCompra(pIdCompra);

            comboProveedores.Items.Add(compra.Proveedor);
            comboProveedores.SelectedIndex = 0;
            comboProveedores.DisplayMember = "Nombre";

            txtTotal.Text = compra.ObtenerTotal().ToString();
            dtpFecha.Value = compra.Fecha;

            foreach (LineaCompra lineaCompra in compra.LineasCompra)
            {
                dgLineasDeCompra.Rows.Add(lineaCompra.IdLineaCompra, lineaCompra.Producto.Descripcion, lineaCompra.PrecioActual, lineaCompra.Cantidad, lineaCompra.ObtenerSubtotal());
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
