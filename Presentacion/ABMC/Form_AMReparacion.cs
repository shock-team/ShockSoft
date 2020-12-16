using System;
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
            
            txtIdReparacion.Text = pIdReparacion.ToString();
            
            if (pIdReparacion == 0)
            {
                txtIdReparacion.Visible = false;
                lblIdReparacion.Visible = false;
            }
            else
            {
                lblNuevaReparacion.Visible = false;
            }

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

            //txtCostoTrabajo.Enabled = false;
            txtCostoTrabajo.Text = "0";
            txtTotal.Text = "0";
            txtTotalInsumos.Text = "0";

            CargarDatos();
        }

        private void ActualizarTotalInsumos()
        {
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
            txtNombreCliente.Text = FormsHelper.NameFormatter(clienteActual.Nombre,clienteActual.Apellido);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            DateTime fechaReparacion = DateTime.MinValue;
            DateTime fechaEntrega = DateTime.MinValue;

            if (cbReparado.Checked)
            {
                fechaReparacion = dtpFechaReparacion.Value;
            }

            if (cbEntregado.Checked)
            {
                fechaEntrega = dtpFechaEntrega.Value;
            }

            int idReparacion;
            if (txtIdReparacion.Text.Equals("0"))
            {
                idReparacion = controlador.AgregarReparacion(txtProblema.Text, txtSolucion.Text, dtpFechaIngreso.Value, fechaReparacion,
                                                             fechaEntrega, txtClave.Text, cbIncluyeCargador.Checked, cbIncluyeCables.Checked,
                                                             txtIdCliente.Text, ((Rubro)comboRubro.SelectedItem).IdRubro,
                                                             ((Marca)comboMarca.SelectedItem).IdMarca, cbEntregado.Checked,
                                                             ((MetodoPago)comboMetodoDePago.SelectedItem).IdMetodoPago, txtCostoTrabajo.Text);
                MessageBox.Show("La reparación se ha registrado exitosamente", "Éxito");
            }
            else
            {
                idReparacion = int.Parse(txtIdReparacion.Text);
                controlador.ModificarReparacion(txtProblema.Text, txtSolucion.Text, dtpFechaIngreso.Value, fechaReparacion,
                                                             fechaEntrega, txtClave.Text, cbIncluyeCargador.Checked, cbIncluyeCables.Checked,
                                                             txtIdCliente.Text, ((Rubro)comboRubro.SelectedItem).IdRubro,
                                                             ((Marca)comboMarca.SelectedItem).IdMarca, cbEntregado.Checked,
                                                             ((MetodoPago)comboMetodoDePago.SelectedItem).IdMetodoPago, txtCostoTrabajo.Text, idReparacion);
                MessageBox.Show("La reparación se ha modificado exitosamente", "Éxito");
            }
            controlador.GenerarLineasDeReparacion(dgLineasDeReparacion.Rows, idReparacion);
            this.Close();
        }

        public void AgregarLinea(string pIdProducto, string pDescripcion, string pPrecioActual, int pCantidad)
        {
            bool lineaModificada = false;

            //Recorre la tala buscando la línea que referencie al producto seleccionado.
            foreach (DataGridViewRow fila in dgLineasDeReparacion.Rows)
            {
                if (((string)(fila.Cells[0].Value)).Equals(pIdProducto))
                {
                    fila.Cells[3].Value = pCantidad;
                    fila.Cells[4].Value = double.Parse(pPrecioActual) * pCantidad;
                    lineaModificada = true;
                }
            }

            //Si no lo encuentra, genera una nueva línea.
            if (!lineaModificada)
            {
                dgLineasDeReparacion.Rows.Add(pIdProducto, pDescripcion, pPrecioActual, pCantidad, double.Parse(pPrecioActual) * pCantidad);
            }

            ActualizarTotalInsumos();
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
                //txtCostoTrabajo.Enabled = true;
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
                //txtCostoTrabajo.Enabled = false;
                txtCostoTrabajo.Text = "0";
                txtTotal.Text = "0";
            }
        }

        private void TxtCostoTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char caracter = e.KeyChar;
            if (caracter == 46 && txtCostoTrabajo.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if(!Char.IsDigit(caracter) && caracter != 8 && caracter != 44)
            {
                e.Handled = true;
            }
        }

        private void PreciosCambiados(object sender, EventArgs e)
        {
            if ((txtTotalInsumos.TextLength > 0) && (txtCostoTrabajo.TextLength > 0))
            {
                float multInteres = (ControladorMetodosPago.ObtenerInstancia().ObtenerMetodoDePago(((MetodoPago)comboMetodoDePago.SelectedItem).IdMetodoPago).MultiplicadorInteres);
                float subtotal = (float.Parse(txtTotalInsumos.Text) + float.Parse(txtCostoTrabajo.Text));
                txtTotal.Text = FormsHelper.TextToCurrency(multInteres * subtotal);
            }
        }

        private void CargarDatos()
        {
            int idReparacion = int.Parse(txtIdReparacion.Text);
            if (idReparacion != 0)
            {
                Reparacion reparacionActual = controlador.ObtenerReparacion(idReparacion);

                txtIdCliente.Text = reparacionActual.IdCliente.ToString();
                txtNombreCliente.Text = reparacionActual.Cliente.Nombre + " " + reparacionActual.Cliente.Apellido;

                dtpFechaIngreso.Value = reparacionActual.FechaIngreso;
                
                if (reparacionActual.FechaReparacion != DateTime.MinValue)
                {
                    dtpFechaReparacion.Value = reparacionActual.FechaReparacion;
                    cbReparado.Checked = true;
                }
                else
                {
                    dtpFechaReparacion.Value = DateTime.Now;
                }

                if (reparacionActual.FechaEntrega != DateTime.MinValue)
                {
                    dtpFechaEntrega.Value = reparacionActual.FechaEntrega;
                }
                else
                {
                    dtpFechaEntrega.Value = DateTime.Now;
                }

                cbEntregado.Checked = reparacionActual.Entregado;
                cbCobrado.Checked = reparacionActual.Cobrado;

                txtProblema.Text = reparacionActual.Problema;
                txtSolucion.Text = reparacionActual.Solucion;

                comboMarca.SelectedItem = reparacionActual.Marca;
                comboRubro.SelectedItem = reparacionActual.Rubro;
                txtClave.Text = reparacionActual.Contraseña;

                foreach (LineaReparacion lineaReparacion in reparacionActual.LineasReparacion)
                {
                    AgregarLinea(lineaReparacion.IdProducto.ToString(), lineaReparacion.Producto.Descripcion, lineaReparacion.PrecioActual.ToString(), lineaReparacion.Cantidad);
                }

                ActualizarTotalInsumos();

                comboMetodoDePago.SelectedItem = reparacionActual.MetodoPago;
                txtCostoTrabajo.Text = reparacionActual.Precio.ToString();
                if (reparacionActual.Precio > 0)
                {
                    cbCobrado.Checked = true;
                }
                txtTotal.Text = reparacionActual.getPrecioTotal().ToString();
            }
        }

        private void DgLineasDeReparacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormsHelper.DobleClickCeldaLinea(dgLineasDeReparacion, this);
        }
    }

}
