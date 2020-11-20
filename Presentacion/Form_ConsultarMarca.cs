using ShockSoft.Dominio;
using ShockSoft.Excepciones;
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
    public partial class Form_ConsultarMarca : Form
    {
        ControladorMarcas controlador = ControladorMarcas.ObtenerInstancia();

        public Form_ConsultarMarca()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgvMarcas.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;

            List<Marca> listaDeMarcas = controlador.ListarMarcas(CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);

            if (listaDeMarcas.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Marca marca in listaDeMarcas)
            {
                dgvMarcas.Rows.Add(marca.IdMarca, marca.Descripcion);
            }
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (lblPaginaActual.Text.Equals("1"))
            {
                btnAnterior.Enabled = true;
                btnAnterior.Visible = true;
            }
            lblPaginaActual.Text = (int.Parse(lblPaginaActual.Text) + 1).ToString();
            if (int.Parse(lblPaginaActual.Text) >= (controlador.ObtenerCantidadDeMarcas() / 15))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            ActualizarTabla();
        }

        private void dgvMarcas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvMarcas.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvMarcas.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.VerificarDatos(txtNombre.Text);
                controlador.ModificarMarca(txtNombre.Text, int.Parse(txtID.Text));
                MessageBox.Show("Marca modificada correctamente!", "Exito");
                ActualizarTabla();
            }
            catch (DatosRepetidosException)
            {
                MessageBox.Show("Ya existe esa marca!", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error");
            }
        }
    }
}
