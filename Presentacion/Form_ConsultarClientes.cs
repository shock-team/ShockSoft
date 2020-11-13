using ShockSoft.Dominio;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace ShockSoft.Presentacion
{
    public partial class Form_ConsultarClientes : Form
    {
        ControladorClientes controlador;
        DataTable tablaDeClientes;

        public Form_ConsultarClientes()
        {
            InitializeComponent();
            controlador = ControladorClientes.ObtenerInstancia();
           
            //Genera una DataTable que muestre los datos especificados
            tablaDeClientes = new DataTable();
            tablaDeClientes.Columns.AddRange(new DataColumn[5]
            {
                new DataColumn("ID", typeof(int)),
                new DataColumn("Nombre", typeof(string)),
                new DataColumn("Apellido", typeof(string)),
                new DataColumn("CUIT", typeof(string)),
                new DataColumn("Saldo", typeof(float)),
            });
            dgClientes.DataSource = tablaDeClientes;
            dgClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgClientes.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


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
            if ( (this.Owner != null) && (this.Owner is  Form_AgregarVenta) )
            {
                Form_AgregarVenta form_AgregarVenta = (Form_AgregarVenta)this.Owner;
                form_AgregarVenta.AgregarCliente(clienteSeleccionado);
                this.Close();
            }

            //Si no, muestra sus datos
            else
            {
                //Obtiene el cliente seleccionado a partir de su ID
                Form_DatosCliente formDatosCliente = new Form_DatosCliente(clienteSeleccionado);
                this.Hide();
                formDatosCliente.ShowDialog();
                this.Show();
            }
        }

        private void BtnAnterior_Click(object sender, System.EventArgs e)
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

        private void BtnSiguiente_Click(object sender, System.EventArgs e)
        {
            if (lblPaginaActual.Text.Equals("1"))
            {
                btnAnterior.Enabled = true;
                btnAnterior.Visible = true;
            }
            lblPaginaActual.Text = (int.Parse(lblPaginaActual.Text) + 1).ToString();
            if (int.Parse(lblPaginaActual.Text) >= (controlador.ObtenerCantidadDeClientes() / 15))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            tablaDeClientes.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;
            List<Cliente> listaDeClientes = controlador.ListarClientes(cbConDeudas.Checked, cbSinDeudas.Checked, txtNombre.Text, txtApellido.Text, CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1), CANTIDAD_POR_PAGINA + 1);
            if (listaDeClientes.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }
            foreach (Cliente cliente in listaDeClientes)
            {
                tablaDeClientes.Rows.Add(cliente.IdCliente, cliente.Nombre, cliente.Apellido, cliente.CUIT, cliente.ObtenerSaldo());
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
