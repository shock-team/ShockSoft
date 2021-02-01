using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZonaSoft.Dominio;
using ZonaSoft.Presentacion.Controladores;
using System.Runtime.InteropServices;

namespace ZonaSoft.Presentacion.ABMC
{
    public partial class Form_AgregarCompra : Form, IAgregarLinea
    {
        ControladorCompras controlador = ControladorCompras.ObtenerInstancia();
        float dolarProveedor;
        public Form_AgregarCompra()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblShock.Text = $"{Properties.Settings.Default.AppName}: {this.Text}";

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

            if (float.TryParse(txtDolarProveedor.Text, out dolarProveedor))
            {
                Form_AgregarLineaDeVenta formAgregarLineaDeVenta = new Form_AgregarLineaDeVenta(dolarProveedor);
                formAgregarLineaDeVenta.Owner = this;
                formAgregarLineaDeVenta.listaDeIDs = listaDeIDs;
                this.Hide();
                formAgregarLineaDeVenta.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show($"{txtDolarProveedor.Text} no es valor correcto de dólar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                float precioDolar = float.Parse(txtDolarProveedor.Text);
                int idCompra = controlador.AgregarCompra(
                    ((Proveedor)comboProveedores.SelectedItem).IdProveedor, 
                    dtpFecha.Value, precioDolar,
                    float.Parse( FormsHelper.CurrencyToText(txtTotal.Text) )
                    );

                controlador.GenerarLineasDeCompra(dgLineasDeCompra.Rows, idCompra, precioDolar);
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
            bool lineaModificada = false;

            //Recorre la tala buscando la línea que referencie al producto seleccionado.
            foreach (DataGridViewRow fila in dgLineasDeCompra.Rows)
            {
                if (((string)(fila.Cells[0].Value)).Equals(pIdProducto))
                {
                    fila.Cells[3].Value = pCantidad;
                    fila.Cells[4].Value = float.Parse(pPrecioActual) * pCantidad;
                    lineaModificada = true;
                }
            }

            //Si no lo encuentra, genera una nueva línea.
            if (!lineaModificada)
            {
                dgLineasDeCompra.Rows.Add(pIdProducto, pDescripcion, pPrecioActual, pCantidad, float.Parse(pPrecioActual) * pCantidad);
            }
            
            ActualizarTotal();
        }

        private void btnDolarActual_Click(object sender, EventArgs e)
        {
            float dolar = ControladorParametros.ObtenerInstancia().ObtenerPrecioDolar();
            txtDolarProveedor.Text = dolar.ToString();
            ActualizarTotal();
        }

        private void DgLineasDeCompra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormsHelper.DobleClickCeldaLinea(dgLineasDeCompra, this);
        }

        private void ActualizarTotal()
        {
            float total = 0;
            
            foreach (DataGridViewRow fila in dgLineasDeCompra.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    total += (float)fila.Cells[4].Value;
                }
            }

            //string precioDolarString = txtDolarProveedor.Text;
            //if (precioDolarString.IndexOf(",") == precioDolarString.Length - 1)
            //{
            //    precioDolarString += "0";
            //}

            //if (float.TryParse(txtDolarProveedor.Text , out dolarProveedor))
            //{
            //    total *= dolarProveedor;
            //}
            //else
            //{
            //    MessageBox.Show($"{txtDolarProveedor.Text} no es valor correcto de dólar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtDolarProveedor.Clear();
            //}
            

            txtTotal.Text = FormsHelper.TextToCurrency(total);
        }

        private void TxtDolarProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (caracter == 46 && txtDolarProveedor.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(caracter) && caracter != 8 && caracter != 44)
            {
                e.Handled = true;
            }

            ActualizarTotal();
        }
    }
}
