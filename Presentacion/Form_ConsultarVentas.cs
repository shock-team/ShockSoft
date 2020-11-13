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
    public partial class Form_ConsultarVentas : Form, IBusquedaDeClientes, IBusquedaDeProductos
    {
        public Form_ConsultarVentas()
        {
            InitializeComponent();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form_ConsultarClientes form_ConsultarClientes = new Form_ConsultarClientes();
            form_ConsultarClientes.Owner = this;
            this.Hide();
            form_ConsultarClientes.ShowDialog();
            this.Show();
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {

        }

        public void AgregarCliente(int pIdCliente)
        {
            txtIdCliente.Text = pIdCliente.ToString();
            Cliente clienteActual = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombreCliente.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
        }

        public void AgregarProducto(int pIdProducto)
        {
            txtIdProducto.Text = pIdProducto.ToString();
            Producto productoActual = ControladorProductos.ObtenerInstancia().ObtenerProducto(pIdProducto);
            txtDescripcionProducto.Text = productoActual.Descripcion;
        }
    }
}
