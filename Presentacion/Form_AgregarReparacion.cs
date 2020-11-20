﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShockSoft.Dominio;

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarReparacion : Form, IBusquedaDeClientes
    {
        ControladorReparaciones controlador = ControladorReparaciones.ObtenerInstancia();

        public Form_AgregarReparacion()
        {
            InitializeComponent();
            InitializeComponent();
            foreach (MetodoPago metodoDePago in ControladorMetodosPago.ObtenerInstancia().ListarMetodosDePago())
            {
                comboMetodoDePago.Items.Add(metodoDePago);
            }
            comboMetodoDePago.DisplayMember = "Descripcion";
            comboMetodoDePago.ValueMember = "IdMetodoPago";
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTamano_Click(object sender, EventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            Form_ConsultarClientes form_ConsultaClientes = new Form_ConsultarClientes();
            this.Hide();
            form_ConsultaClientes.ShowDialog(this);
            this.Show();
        }

        private void CbReparado_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaReparacion.Enabled = cbReparado.Checked;
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        public void AgregarCliente(int pIdCliente)
        {
            txtIdCliente.Text = pIdCliente.ToString();
            Cliente clienteActual = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombreCliente.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
        }
    }

}