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

namespace ShockSoft.Presentacion.ABMC
{
    public partial class Form_AgregarCompra : Form, IAgregarLinea
    {
        ControladorCompras controlador = ControladorCompras.ObtenerInstancia();
        public Form_AgregarCompra()
        {
            InitializeComponent();
            txtTotal.Text = "0";
            ActualizarCombobox();
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

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            Form_AMCProveedor form_AMCProveedor = new Form_AMCProveedor();
            this.Hide();
            form_AMCProveedor.ShowDialog();
            ActualizarCombobox();
            this.Show();
        }

        private void ActualizarCombobox()
        {
            comboProveedores.Items.Clear();
            foreach (Proveedor proveedor in ControladorProveedores.ObtenerInstancia().ObtenerProveedores())
            {
                comboProveedores.Items.Add(proveedor);
            }
            comboProveedores.DisplayMember = "Nombre";
            comboProveedores.ValueMember = "IdProveedor";
            comboProveedores.SelectedIndex = 0;
        }

        private void BtnAgregarLinea_Click(object sender, EventArgs e)
        {
            List<int> listaDeIDs = new List<int>();
            foreach (DataGridViewRow fila in dgLineasDeCompra.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    listaDeIDs.Add(int.Parse(fila.Cells[0].Value.ToString()));
                }
            }
            Form_AgregarLineaDeVenta formAgregarLineaDeVenta = new Form_AgregarLineaDeVenta();
            formAgregarLineaDeVenta.Owner = this;
            formAgregarLineaDeVenta.listaDeIDs = listaDeIDs;
            this.Hide();
            formAgregarLineaDeVenta.ShowDialog();
            this.Show();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCompra = controlador.AgregarCompra(
                    ((Proveedor)comboProveedores.SelectedItem).IdProveedor, 
                    dtpFecha.Value,
                    float.Parse(txtDolarProveedor.Text),
                    float.Parse( FormsHelper.TextToCurrency(txtTotal.Text) )
                    );

                controlador.GenerarLineasDeCompra(dgLineasDeCompra.Rows, idCompra);
                MessageBox.Show("La compra se ha registrado exitosamente", "Éxito");
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

        public void AgregarLinea(string pIdProducto, string pDescripcion, string pPrecioActual, int pCantidad)
        {
            dgLineasDeCompra.Rows.Add(pIdProducto, pDescripcion, pPrecioActual, pCantidad, float.Parse(pPrecioActual) * pCantidad);
            float total = 0;
            foreach (DataGridViewRow fila in dgLineasDeCompra.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    total += (float)fila.Cells[4].Value;
                }
            }
            total *= float.Parse(txtDolarProveedor.Text);

            txtTotal.Text = FormsHelper.TextToCurrency(total);
        }

        private void btnDolarActual_Click(object sender, EventArgs e)
        {
            float dolar = ControladorParametros.ObtenerInstancia().ObtenerPrecioDolar();
            txtDolarProveedor.Text = dolar.ToString();
        }
    }
}
