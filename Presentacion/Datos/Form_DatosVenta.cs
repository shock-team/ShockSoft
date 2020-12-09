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
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    public partial class Form_DatosVenta : Form
    {
        ControladorVentas controlador = ControladorVentas.ObtenerInstancia();
        ControladorParametros parametros = ControladorParametros.ObtenerInstancia();
        int _idVenta;
        float _precioDolar;

        public Form_DatosVenta(int pIdVenta)
        {
            InitializeComponent();
            _idVenta = pIdVenta;
            _precioDolar = parametros.ObtenerPrecioDolar();
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            Venta ventaActual = controlador.ObtenerVenta(_idVenta);
            txtNombreCliente.Text = FormsHelper.NameFormatter(ventaActual.Cliente.Nombre,ventaActual.Cliente.Apellido);
            txtIdCliente.Text = ventaActual.Cliente.IdCliente.ToString();

            //Carga las líneas de venta
            foreach (LineaVenta lineaDeVenta in ventaActual.Lineas)
            {
                dglineasDeVenta.Rows.Add(lineaDeVenta.IdProducto, ControladorProductos.ObtenerInstancia().ObtenerProducto(lineaDeVenta.IdProducto).Descripcion, lineaDeVenta.PrecioActual, lineaDeVenta.Cantidad, lineaDeVenta.ObtenerSubtotal());
            }

            comboMetodoPago.Items.Add(ventaActual.MetodoPago);
            comboMetodoPago.DisplayMember = "Descripcion";
            comboMetodoPago.SelectedIndex = 0;

            txtTotal.Text = ventaActual.ObtenerTotal().ToString();
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
