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
    public partial class Form_AMMetodoDePago : Form
    {
        ControladorMetodosPago controlador = ControladorMetodosPago.ObtenerInstancia();

        public Form_AMMetodoDePago(int pIdMetodoPago = 0)
        {
            InitializeComponent();

            if (pIdMetodoPago != 0)
            {
                lblNuevoMetodoPago.Visible = false;
                txtIdMetodoPago.Text = pIdMetodoPago.ToString();
                MetodoPago metodoPago = controlador.ObtenerMetodoDePago(pIdMetodoPago);
                txtDescripcion.Text = metodoPago.Descripcion;
                txtValorMuliplicador.Text = metodoPago.MultiplicadorInteres.ToString();
            }
            else
            {
                lblIdMetodoPago.Visible = false;
                txtIdMetodoPago.Visible = false;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtIdMetodoPago.Text == "0")
            {
                controlador.AgregarMetodoDePago(txtDescripcion.Text, float.Parse(txtValorMuliplicador.Text));
                MessageBox.Show("Método de pago agregado correctamente", "Éxito");
            }
            else
            {
                controlador.ModificarMetodoDePago(txtDescripcion.Text, float.Parse(txtValorMuliplicador.Text), int.Parse(txtIdMetodoPago.Text));
                MessageBox.Show("Método de pago modificado correctamente", "Éxito");
            }
        }

        private void TxtValorMuliplicador_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (caracter == 46 && txtValorMuliplicador.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(caracter) && caracter != 8 && caracter != 46)
            {
                e.Handled = true;
            }
        }
    }
}
