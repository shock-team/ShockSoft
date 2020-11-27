using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShockSoft.Presentacion
{
    public partial class Form_ConsultarReparaciones : Form, IBusquedaDeClientes
    {
        ControladorReparaciones controlador = new ControladorReparaciones();
        public Form_ConsultarReparaciones()
        {
            InitializeComponent();
        }

        public void AgregarCliente(int pIdCliente)
        {
            txtIdCliente.Text = pIdCliente.ToString();
            Cliente clienteActual = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombreCliente.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
        }

        private void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgReparaciones.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;

            List<Reparacion> listaDeReparaciones = controlador.ListarReparaciones(int.Parse(txtIdCliente.Text), cbReparado.Checked, cbEntregado.Checked,cbCobrado.Checked, CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);

            if (listaDeReparaciones.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Reparacion rep in listaDeReparaciones)
            {
                dgReparaciones.Rows.Add();
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form_ConsultarClientes form_ConsultarClientes = new Form_ConsultarClientes();
            form_ConsultarClientes.Owner = this;
            this.Hide();
            form_ConsultarClientes.ShowDialog();
            this.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (lblPaginaActual.Text.Equals("1"))
            {
                btnAnterior.Enabled = true;
                btnAnterior.Visible = true;
            }
            lblPaginaActual.Text = (int.Parse(lblPaginaActual.Text) + 1).ToString();
            if (int.Parse(lblPaginaActual.Text) >= (controlador.ObtenerCantidadReparaciones() / 15))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            ActualizarTabla();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            lblPaginaActual.Text = (int.Parse(lblPaginaActual.Text) - 1).ToString();
            if (lblPaginaActual.Text.Equals("1"))
            {
                btnAnterior.Enabled = false;
                btnAnterior.Visible = false;
            }
            ActualizarTabla();
        }
    }
}
