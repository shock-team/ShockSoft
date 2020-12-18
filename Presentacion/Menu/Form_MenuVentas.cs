using ShockSoft.Presentacion.ABMC;
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
    public partial class Form_MenuVentas : Form
    {
        public Form_MenuVentas()
        {
            InitializeComponent();
        }

        private void btnAltaVenta_Click(object sender, EventArgs e)
        {
            Form_AgregarVenta form_AgregarVenta = new Form_AgregarVenta();
            form_AgregarVenta.Show();
        }

        private void btnConsultaVenta_Click(object sender, EventArgs e)
        {
            Form_ConsultarVentas form_ConsultarVentas = new Form_ConsultarVentas();
            form_ConsultarVentas.Show();
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            Form_AgregarCompra form_AgregarCompra = new Form_AgregarCompra();
            form_AgregarCompra.Show();
        }

        private void btnConsultarCompras_Click(object sender, EventArgs e)
        {
            Form_ConsultarCompras form_ConsultarCompras = new Form_ConsultarCompras();
            form_ConsultarCompras.Show();
        }

        private void BtnAgregarMetodoDePago_Click(object sender, EventArgs e)
        {
            Form_AMMetodoDePago form_AMMetodoDePago = new Form_AMMetodoDePago();
            form_AMMetodoDePago.Show();
        }

        private void BtnConsultarMetodosDePago_Click(object sender, EventArgs e)
        {
            Form_ConsultarMetodoDePago form_ConsultarMetodoDePago = new Form_ConsultarMetodoDePago();
            form_ConsultarMetodoDePago.Show();
        }
    }
}
