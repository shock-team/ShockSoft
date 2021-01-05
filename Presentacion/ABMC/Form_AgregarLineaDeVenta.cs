using System;
using System.Collections.Generic;
using ShockSoft.Presentacion.ABMC;
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
        public List<int> listaDeIDs;
        ControladorParametros parametros = ControladorParametros.ObtenerInstancia();
        float _precioDolar;

        public Form_AgregarLineaDeVenta()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            txtPrecioUnitario.Text = FormsHelper.TextToCurrency("0");
            _precioDolar = parametros.ObtenerPrecioDolar();
        }

        public void CambiarColor()
        {
            if ((this.Owner != null) && (this.Owner is Form_AgregarReparacion))
            {
                this.BackColor = Color.FromArgb(255, 85, 85, 70);
                this.panel1.BackColor = Color.FromArgb(255, 75, 75, 60);
                this.panel2.BackColor = Color.FromArgb(255, 75, 75, 60);
                this.panel3.BackColor = Color.FromArgb(255, 75, 75, 60);
                this.btnBuscar.BackColor = Color.FromArgb(255, 50, 50, 40);
                this.btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 185, 54);
                this.btnAceptar.BackColor = Color.FromArgb(255, 50, 50, 40);
                this.btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 185, 54);
            }
        }

        public void AgregarProducto(int pIdProducto, int pCantidad = 0)
        {
            txtId.Text = pIdProducto.ToString();
            if (Owner is Form_AgregarCompra)
            {
                nmCantidad.Maximum = int.MaxValue;
            }
            nmCantidad.Value = pCantidad;
            ActualizarDatos();
        }

        private void NmCantidad_ValueChanged(object sender, EventArgs e)
        {
            decimal precioUnitario = decimal.Parse(FormsHelper.CurrencyToText(txtPrecioUnitario.Text));
            decimal subtotal = nmCantidad.Value * precioUnitario;
            txtSubtotal.Text = FormsHelper.TextToCurrency(subtotal.ToString());
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
            if (Owner is Form_AgregarCompra)
            {
                Form_ConsultarProductos formBuscarProducto = new Form_ConsultarProductos();
                formBuscarProducto.listaDeIDs = listaDeIDs;
                formBuscarProducto.Owner = this;
                this.Hide();
                formBuscarProducto.ShowDialog();
                this.Show();
            }
            else
            {
                Form_BuscarProducto formBuscarProducto = new Form_BuscarProducto();
                formBuscarProducto.listaDeIDs = listaDeIDs;
                formBuscarProducto.Owner = this;
                this.Hide();
                if (Owner is Form_AgregarReparacion)
                {
                    formBuscarProducto.CambiarColor();
                }
                formBuscarProducto.ShowDialog();
                this.Show();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (nmCantidad.Value > 0)
                {
                    IAgregarLinea formAgregarVenta = (IAgregarLinea)Owner;
                    formAgregarVenta.AgregarLinea(
                        txtId.Text,
                        txtDescripcion.Text,
                        FormsHelper.CurrencyToText(txtPrecioUnitario.Text),
                        Convert.ToInt32(nmCantidad.Value));
                }
                else
                {
                    MessageBox.Show("La cantidad debe ser mayor que 0", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                this.Close();
            }
        }

        private void ActualizarDatos()
        {
            Producto productoSeleccionado = ControladorProductos.ObtenerInstancia().ObtenerProducto(int.Parse(txtId.Text));
            txtDescripcion.Text = productoSeleccionado.Descripcion;

            //Si esta form es invocada durante el caso de uso de Agregar Compra, no estará limitada por el stock
            //del producto.
            if (Owner is Form_AgregarCompra)
            {
                nmCantidad.Maximum = int.MaxValue;
            }

            //En caso contrario, lo estará.
            else
            {
                nmCantidad.Maximum = productoSeleccionado.Cantidad;
            }

            nmCantidad.Enabled = true;

            if (Owner is Form_AgregarCompra)
            {
                txtPrecioUnitario.Text = FormsHelper.TextToCurrency(productoSeleccionado.ObtenerPrecioDeVenta());
            }
            else
            {
                txtPrecioUnitario.Text = FormsHelper.TextToCurrency(productoSeleccionado.ObtenerPrecioDeVenta() * _precioDolar);
            }
        }
    }
}
