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
    public partial class Form_AgregarReparacion : Form, IBusquedaDeClientes, IAgregarLinea
    {
        ControladorReparaciones controlador = ControladorReparaciones.ObtenerInstancia();

        public Form_AgregarReparacion(int pIdReparacion = 0)
        {
            InitializeComponent();
            txtCostoTrabajo.Text = "0";
            txtTotal.Text = "0";
            txtTotalInsumos.Text = "0";
            foreach (MetodoPago metodoDePago in ControladorMetodosPago.ObtenerInstancia().ListarMetodosDePago())
            {
                comboMetodoDePago.Items.Add(metodoDePago);
            }
            comboMetodoDePago.DisplayMember = "Descripcion";
            comboMetodoDePago.ValueMember = "IdMetodoPago";
            comboMetodoDePago.SelectedIndex = 0;
            foreach (Rubro rubro in ControladorRubros.ObtenerInstancia().ListarRubros())
            {
                comboRubro.Items.Add(rubro);
            }
            comboRubro.DisplayMember = "Descripcion";
            comboRubro.ValueMember = "IdRubro";
            comboRubro.SelectedIndex = 0;
            foreach (Marca marca in ControladorMarcas.ObtenerInstancia().ListarMarcas())
            {
                comboMarca.Items.Add(marca);
            }
            comboMarca.DisplayMember = "Descripcion";
            comboMarca.ValueMember = "IdMarca";
            comboMarca.SelectedIndex = 0;
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

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            List<int> listaDeIDs = new List<int>();
            foreach (DataGridViewRow fila in dgLineasDeReparacion.Rows)
            {
                if (fila.Cells[0].Value != null)
                {
                    listaDeIDs.Add(int.Parse(fila.Cells[0].Value.ToString()));
                }
            }
            Form_AgregarLineaDeVenta formAgregarLineaDeReparacion = new Form_AgregarLineaDeVenta();
            formAgregarLineaDeReparacion.Owner = this;
            formAgregarLineaDeReparacion.listaDeIDs = listaDeIDs;
            this.Hide();
            formAgregarLineaDeReparacion.ShowDialog();
            this.Show();
        }

        public void AgregarCliente(int pIdCliente)
        {
            txtIdCliente.Text = pIdCliente.ToString();
            Cliente clienteActual = ControladorClientes.ObtenerInstancia().ObtenerCliente(pIdCliente);
            txtNombreCliente.Text = clienteActual.Nombre + " " + clienteActual.Apellido;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int idReparacion = controlador.AgregarReparacion(txtProblema.Text, txtSolucion.Text , dtpFechaIngreso.Value, dtpFechaReparacion.Value,
                                                             dtpFechaEntrega.Value, txtClave.Text, cbIncluyeCargador.Checked, cbIncluyeCables.Checked,
                                                             txtIdCliente.Text, ((Rubro)comboRubro.SelectedItem).IdRubro,
                                                             ((Marca)comboMarca.SelectedItem).IdMarca, cbReparado.Checked, cbEntregado.Checked,
                                                             ((MetodoPago)comboMetodoDePago.SelectedItem).IdMetodoPago, txtTotal.Text);
            controlador.GenerarLineasDeReparacion(dgLineasDeReparacion.Rows, idReparacion);
            MessageBox.Show("La reparación se ha registrado exitosamente", "Éxito");
            this.Close();
        }

        public void AgregarLinea(string pIdProducto, string pDescripcion, string pPrecioActual, int pCantidad)
        {
            dgLineasDeReparacion.Rows.Add(pIdProducto, pDescripcion, pPrecioActual, pCantidad, double.Parse(pPrecioActual) * pCantidad);
            double total = 0;
            foreach (DataGridViewRow fila in dgLineasDeReparacion.Rows)
            {
                if (fila.Cells[4].Value != null)
                {
                    total += (double)fila.Cells[4].Value;
                }
            }
            txtTotalInsumos.Text = total.ToString();
        }

        private void CbReparado_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaReparacion.Enabled = cbReparado.Checked;
        }

        private void CbEntregado_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaEntrega.Enabled = cbEntregado.Checked;
        }

        private void CbCobrado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCobrado.Checked)
            {
                txtCostoTrabajo.Enabled = true;
                if (txtCostoTrabajo.TextLength > 0)
                {
                    txtTotal.Text = (float.Parse(txtTotalInsumos.Text) + float.Parse(txtCostoTrabajo.Text)).ToString();
                }
                else
                {
                    txtTotal.Text = (float.Parse(txtTotalInsumos.Text)).ToString();
                }
            }
            else
            {
                txtCostoTrabajo.Enabled = false;
                txtCostoTrabajo.Text = "0";
                txtTotal.Text = "0";
            }
        }

        private void TxtCostoTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (caracter == 46 && txtCostoTrabajo.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if(!Char.IsDigit(caracter) && caracter != 8 && caracter != 46)
            {
                e.Handled = true;
            }
        }

        private void PreciosCambiados(object sender, EventArgs e)
        {
            if ((txtTotalInsumos.TextLength > 0) && (txtCostoTrabajo.TextLength > 0))
            {
                txtTotal.Text = (ControladorMetodosPago.ObtenerInstancia().ObtenerMetodoDePago(((MetodoPago) comboMetodoDePago.SelectedItem).IdMetodoPago).MultiplicadorInteres * (float.Parse(txtTotalInsumos.Text) + float.Parse(txtCostoTrabajo.Text))).ToString();
            }
        }

        private void CargarDatos(int pIdReparacion)
        {
            if (pIdReparacion != 0)
            {
                Reparacion reparacionActual = controlador.ObtenerReparacion(pIdReparacion);
                txtIdCliente.Text = reparacionActual.IdCliente.ToString();
                txtNombreCliente.Text = reparacionActual.Cliente.Nombre + " " + reparacionActual.Cliente.Apellido;
                txtClave.Text = reparacionActual.Contraseña;
                dtpFechaIngreso.Value = reparacionActual.FechaIngreso;
                dtpFechaReparacion.Value = reparacionActual.FechaReparacion;
                dtpFechaEntrega.Value = reparacionActual.FechaEntrega;
                cbEntregado.Checked = reparacionActual.Entregado;
                cbCobrado.Checked = reparacionActual.Cobrado;
                cbReparado.Checked = (reparacionActual.FechaReparacion != DateTime.MinValue);
                txtProblema.Text = reparacionActual.Problema;
                txtSolucion.Text = reparacionActual.Solucion;
                comboMarca.SelectedItem = reparacionActual.Marca;
                comboMetodoDePago.SelectedItem = reparacionActual.MetodoPago;
                comboRubro.SelectedItem = reparacionActual.Rubro;
                foreach (LineaReparacion lineaReparacion in reparacionActual.LineasReparacion)
                {
                    AgregarLinea(lineaReparacion.IdProducto.ToString(), lineaReparacion.Producto.Descripcion, lineaReparacion.PrecioActual.ToString(), lineaReparacion.Cantidad);
                }
                txtCostoTrabajo.Text = (reparacionActual.Precio - float.Parse(txtTotalInsumos.Text)).ToString();
                txtTotal.Text = reparacionActual.Precio.ToString();
            }
        }
    }

}
