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
            int idCompra = controlador.AgregarCompra(((Proveedor)comboProveedores.SelectedItem).IdProveedor, dtpFecha.Value);
            controlador.GenerarLineasDeCompra(dgLineasDeCompra.Rows, idCompra);
            MessageBox.Show("La venta se ha registrado exitosamente", "Éxito");
            this.Close();
        }

        public void AgregarLinea(string pIdProducto, string pDescripcion, string pPrecioActual, int pCantidad)
        {
            dgLineasDeCompra.Rows.Add(pIdProducto, pDescripcion, pPrecioActual, pCantidad, double.Parse(pPrecioActual) * pCantidad);
            double total = 0;
            foreach (DataGridViewRow fila in dgLineasDeCompra.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    total += (double)fila.Cells[4].Value;
                }
            }
            txtTotal.Text = total.ToString();
        }
    }
}
