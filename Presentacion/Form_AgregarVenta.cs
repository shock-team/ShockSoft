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

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarVenta : Form
    {
        ControladorVentas controlador = ControladorVentas.ObtenerInstancia();

        public Form_AgregarVenta()
        {
            InitializeComponent();
            foreach (MetodoPago metodoDePago in ControladorMetodosPago.ObtenerInstancia().ListarMetodosDePago())
            {
                comboMetodoPago.Items.Add(metodoDePago);
            }
            comboMetodoPago.DisplayMember = "Descripcion";
            comboMetodoPago.ValueMember = "IdMetodoPago";
        }

        private void BtnAgregarLinea_Click(object sender, EventArgs e)
        {
            Form_AgregarLineaDeVenta formAgregarLineaDeVenta = new Form_AgregarLineaDeVenta();
            formAgregarLineaDeVenta.Owner = this;
            this.Hide();
            formAgregarLineaDeVenta.ShowDialog();
            this.Show();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            controlador.AgregarVenta(int.Parse(txtId.Text), controlador.GenerarLineasDeVenta(dglineasDeVenta.Rows), (int)comboMetodoPago.SelectedValue);
            MessageBox.Show("La venta se ha registrado exitosamente", "Éxito");
        }

        public void AgregarLineaDeVenta(string pIdProducto, string pDescripcion, string pPrecioActual, int pCantidad)
        {
            dglineasDeVenta.Rows.Add(pIdProducto, pDescripcion, pPrecioActual, pCantidad, double.Parse(pPrecioActual)*pCantidad);
            double total = 0;
            for (int i = 0; i < dglineasDeVenta.Rows.Count; i++)
            {
                total += (double)dglineasDeVenta.Rows[i].Cells[4].Value;
            }
            txtTotal.Text = total.ToString();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form_ConsultarClientes form_ConsultaClientes = new Form_ConsultarClientes();
            form_ConsultaClientes.Owner = this;
            this.Hide();
            form_ConsultaClientes.ShowDialog();
            this.Show();
        }

        public void AgregarCliente(int pIdCliente)
        {
            txtId.Text = pIdCliente.ToString();
            Cliente clienteActual = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombre.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
        }
    }
}
