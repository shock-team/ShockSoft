﻿using ZonaSoft.Dominio;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Drawing;

namespace ZonaSoft.Presentacion
{
    public partial class Form_ConsultarClientes : Form
    {
        ControladorClientes controlador;

        public Form_ConsultarClientes()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblShock.Text = $"{Properties.Settings.Default.AppName}: {this.Text}";

            controlador = ControladorClientes.ObtenerInstancia();
            cbConDeudas.Checked = true;
            cbSinDeudas.Checked = true;
            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;
            if (controlador.ObtenerCantidadDeClientes() <= 15)
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }

            ActualizarTabla();
            CambiarColor();
        }

        public void CambiarColor()
        {
            if ((this.Owner != null) && (this.Owner is IBusquedaDeClientes))
            {
                this.BackColor = Color.FromArgb(255, 87, 80, 75);
                this.panel1.BackColor = Color.FromArgb(255, 75, 60, 55);
                this.panel2.BackColor = Color.FromArgb(255, 75, 60, 55);
                this.panel3.BackColor = Color.FromArgb(255, 75, 60, 55);
                this.panel4.BackColor = Color.FromArgb(255, 75, 60, 55);
                this.btnAnterior.BackColor = Color.FromArgb(255, 50, 45, 45);
                this.btnAnterior.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 215, 58, 73);
                this.btnSiguiente.BackColor = Color.FromArgb(255, 50, 45, 45);
                this.btnSiguiente.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 215, 58, 73);
            }
        }


        private void ValorCambiado(object sender, System.EventArgs e)
        {
            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;
            lblPaginaActual.Text = "1";
            ActualizarTabla();
        }

        private void DgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int clienteSeleccionado = (int)dgClientes.CurrentRow.Cells[0].Value;
            //Las tareas a realizar cambian si esta form es creada desde un Form_AgregarVenta
            //Si es Form_AgregarVenta selecciona el cliente y lo devuelve al owner
            if ( (this.Owner != null) && (this.Owner is IBusquedaDeClientes) )
            {
                IBusquedaDeClientes owner = (IBusquedaDeClientes)Owner;
                owner.AgregarCliente(clienteSeleccionado);
                this.Close();
            }

            //Si no, muestra sus datos
            else
            {
                //Obtiene el cliente seleccionado a partir de su ID
                Form_DatosCliente formDatosCliente = new Form_DatosCliente(clienteSeleccionado);
                this.Hide();
                formDatosCliente.ShowDialog();
                ActualizarTabla();
                this.Show();
            }
        }

        private void BtnAnterior_Click(object sender, System.EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void BtnSiguiente_Click(object sender, System.EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadDeClientes());
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgClientes.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;
            List<Cliente> listaDeClientes = controlador.ListarClientes(cbConDeudas.Checked, cbSinDeudas.Checked, txtNombre.Text, txtApellido.Text, CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);
            if (listaDeClientes.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Cliente cliente in listaDeClientes)
            {
                dgClientes.Rows.Add(cliente.IdCliente, FormsHelper.NameFormatter(cliente.Nombre, cliente.Apellido), cliente.CUIT, cliente.ObtenerSaldo());
            }
        }

        // Deslizar ventana desde el panel de control
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnTamano_Click(object sender, System.EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimizar_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
