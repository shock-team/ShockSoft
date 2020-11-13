﻿using ShockSoft.Dominio;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarProducto : Form
    {
        ControladorProductos controlador;

        public Form_AgregarProducto()
        {
            InitializeComponent();
            controlador = ControladorProductos.ObtenerInstancia();

            //Carga las marcas en el ComboBox
            foreach (Marca marca in ControladorMarcas.ObtenerInstancia().ListarMarcas())
            {
                comboMarca.Items.Add(marca);
            }
            comboMarca.DisplayMember = "Descripcion";
            comboMarca.ValueMember = "IdMarca";

            //Carga los IVAs en el ComboBox
            foreach (IVA iva in ControladorParametros.ObtenerInstancia().ListarParametros())
            {
                comboIVA.Items.Add(iva);
            }
            comboIVA.DisplayMember = "Descripcion";
            comboIVA.ValueMember = "IdParametro";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            controlador.AgregarProducto(txtDescripcion.Text, float.Parse(txtPrecio.Text), float.Parse(txtGanancia.Text), (int)comboIVA.SelectedItem, (int)comboMarca.SelectedItem);
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {

        }
    }
}