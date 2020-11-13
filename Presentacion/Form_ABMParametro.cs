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
    public partial class Form_ABMParametro : Form
    {
        ControladorParametros controlador;

        public Form_ABMParametro()
        {
            InitializeComponent();
            controlador = ControladorParametros.ObtenerInstancia();
            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;

            txtDolar.Text = controlador.ObtenerPrecioDolar().Valor.ToString();
            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgParametros.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;

            List<Parametro> listaDeParametros = controlador.ListarParametros(
                CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1),
                CANTIDAD_POR_PAGINA + 1
                );

            if (listaDeParametros.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }

            foreach (Parametro parametro in listaDeParametros)
            {
                dgParametros.Rows.Add(parametro.IdParametro, parametro.Descripcion, parametro.Valor);
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
            if (int.Parse(lblPaginaActual.Text) >= (controlador.ObtenerCantidadDeParametros() / 15))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            ActualizarTabla();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarParametro(txtDescripcion.Text, float.Parse(txtValor.Text));
                MessageBox.Show("Parametro agregado correctamente!");
                ActualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.ModificarParametro("Precio Dólar", float.Parse(txtDolar.Text), 1);
                MessageBox.Show("Dolar actualizado!");
                ActualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
