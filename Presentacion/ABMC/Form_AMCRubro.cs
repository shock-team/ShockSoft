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

namespace ShockSoft.Presentacion.ABMC
{
    public partial class Form_AMCRubro : Form
    {
        ControladorRubros controlador;
        public Form_AMCRubro()
        {
            InitializeComponent();

            controlador = ControladorRubros.ObtenerInstancia();
            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;

            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgRubros.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;

            List<Rubro> listaDeRubros = controlador.ListarRubros(
                CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1),
                CANTIDAD_POR_PAGINA + 1
                );

            if (listaDeRubros.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }

            foreach (Rubro rubro in listaDeRubros)
            {
                dgRubros.Rows.Add(rubro.IdRubro, rubro.Descripcion);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadDeRubros());
            ActualizarTabla();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarRubro(txtAñadirRubro.Text);
                ActualizarTabla();
                MessageBox.Show($"El rubro {txtAñadirRubro.Text} se ha añadido correctamente", "Aviso");
                txtAñadirRubro.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarRubro_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.ModificarRubro(int.Parse(txtModificarID.Text), txtModificarDesc.Text);
                ActualizarTabla();
                MessageBox.Show($"Se ha cambiado el nombre del rubro a {txtModificarDesc.Text}", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                txtModificarID.Clear();
                txtModificarDesc.Clear();
            }
        }

        private void dgRubros_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtModificarID.Text = dgRubros.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtModificarDesc.Text = dgRubros.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
