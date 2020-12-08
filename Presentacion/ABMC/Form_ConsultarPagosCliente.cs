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
    public partial class Form_ConsultarPagosCliente : Form
    {
        ControladorClientes controlador = ControladorClientes.ObtenerInstancia();

        public Form_ConsultarPagosCliente(int pIdCliente)
        {
            InitializeComponent();
            Cliente clienteActual = controlador.ObtenerCliente(pIdCliente);
            txtIdCliente.Text = pIdCliente.ToString();
            txtNombreCliente.Text = FormsHelper.NameFormatter(clienteActual.Nombre, clienteActual.Apellido);
            txtSaldo.Text = clienteActual.ObtenerSaldo().ToString();
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            int CANTIDAD_POR_PAGINA = 15;
            Cliente clienteActual = controlador.ObtenerCliente(int.Parse(txtIdCliente.Text));
            IEnumerable<Pago> listaDePagos = clienteActual.Pagos.OrderBy(x => x.Fecha).Skip(CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1)).Take(CANTIDAD_POR_PAGINA);
            foreach (Pago pago in listaDePagos)
            {
                dgPagos.Rows.Add(pago.IdPago, pago.Fecha, pago.Descripcion, pago.Monto);
            }
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Cliente clienteActual = controlador.ObtenerCliente(int.Parse(txtIdCliente.Text));
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, clienteActual.Pagos.Count());
            ActualizarTabla();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }
    }
}
