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
    public partial class Form_DatosProducto : Form
    {
        ControladorProductos controlador = ControladorProductos.ObtenerInstancia();

        public Form_DatosProducto(int pIdProducto)
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            //Obtiene los datos del producto y los carga en los espacios correspondientes
            Producto producto = controlador.ObtenerProducto(pIdProducto);
            txtId.Text = producto.IdProducto.ToString();
            txtDescripcion.Text = producto.Descripcion;
            txtCantidad.Text = producto.Cantidad.ToString();
            txtPrecio.Text = producto.PrecioBaseDolar.ToString();
            txtPorcentajeDeGanancia.Text = producto.PorcentajeGanancia.ToString();
            //txtMarca.Text = ControladorMarcas.ObtenerInstancia().Obtener(producto.IdMarca).Descripcion;
            if (producto.EnVenta)
            {
                txtEnVenta.Text = "Sí";
            }
            else
            {
                txtEnVenta.Text = "No";
            }

            //Carga los IVAs en el combobox
            foreach (Parametro parametro in ControladorParametros.ObtenerInstancia().ListarParametros())
            {
                if (!(parametro.IdParametro == 1))
                {
                    comboIVA.Items.Add(parametro);
                    if (producto.IdParametro == parametro.IdParametro)
                    {
                        comboIVA.SelectedItem = parametro;
                    }
                }
            }
            comboIVA.DisplayMember = "Descripcion";

            //Carga las marcas en el ComboBox
            foreach (Marca marca in ControladorMarcas.ObtenerInstancia().ListarMarcas())
            {
                comboMarca.Items.Add(marca);
                if (producto.IdMarca == marca.IdMarca)
                {
                    comboMarca.SelectedItem = marca;
                }
            }
            comboMarca.DisplayMember = "Descripcion";
            comboMarca.ValueMember = "IdMarca";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            controlador.ModificarProducto(txtDescripcion.Text, float.Parse(txtPrecio.Text), float.Parse(txtPorcentajeDeGanancia.Text), ((Parametro)comboIVA.SelectedItem).IdParametro, int.Parse(txtId.Text));
        }

        private void btnAltaBaja_Click(object sender, EventArgs e)
        {
            controlador.DarDeBaja(int.Parse(txtId.Text));
            if (txtEnVenta.Text == "Sí")
            {
                txtEnVenta.Text = "No";
            }
            else
            {
                txtEnVenta.Text = "Sí";
            }
        }

        private void btnHistorialCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorialVenta_Click(object sender, EventArgs e)
        {

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
