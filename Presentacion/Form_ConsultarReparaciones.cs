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
            //btnReiniciarFiltros.Image = Properties.Resources.filter_reset;
            ActualizarTabla();
        }

        public void AgregarCliente(int pIdCliente)
        {
            txtIdCliente.Text = pIdCliente.ToString();
            Cliente clienteActual = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombreCliente.Text = Helper.NameFormatter(clienteActual.Nombre, clienteActual.Apellido);
        }

        private void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgReparaciones.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;

            int idCliente;
            if (txtIdCliente.TextLength > 0)
            {
                idCliente = int.Parse(txtIdCliente.Text);
            }
            else
            {
                idCliente = 0;
            }
            
            List<Reparacion> listaDeReparaciones = controlador.ListarReparaciones(idCliente, cbReparado.Checked, cbEntregado.Checked,cbCobrado.Checked, CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);

            if (listaDeReparaciones.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Reparacion rep in listaDeReparaciones)
            {
                dgReparaciones.Rows.Add(rep.IdReparacion, rep.FechaIngreso, Helper.NameFormatter(rep.Cliente.Nombre, rep.Cliente.Apellido), rep.Rubro.Descripcion, rep.Problema, rep.Entregado );
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

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void cbReparado_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void cbCobrado_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void cbEntregado_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void btnReiniciarFiltros_Click(object sender, EventArgs e)
        {
            txtIdCliente.Clear();
            txtNombreCliente.Clear();
            cbCobrado.Checked = false;
            cbEntregado.Checked = false;
            cbReparado.Checked = false;
        }
    }
}
