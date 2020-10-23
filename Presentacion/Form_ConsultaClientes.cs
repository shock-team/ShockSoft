using ShockSoft.Dominio;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShockSoft.Presentacion
{
    public partial class Form_ConsultaClientes : Form
    {
        ControladorClientes controlador;
        DataTable tablaDeClientes;

        public Form_ConsultaClientes()
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
            //Obtiene el cliente seleccionado a partir de su ID
            int clienteSeleccionado = (int)dgClientes.CurrentRow.Cells[0].Value;
            Form_DatosCliente formDatosCliente = new Form_DatosCliente(clienteSeleccionado);
            this.Hide();
            formDatosCliente.ShowDialog();
            this.Show();
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
            btnAnterior.Enabled = true;
            btnAnterior.Visible = true;
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
            tablaDeClientes.Rows.Clear();
            foreach (Cliente cliente in controlador.ListarClientes(cbConDeudas.Checked, cbSinDeudas.Checked, txtNombre.Text, txtApellido.Text, 15 * (int.Parse(lblPaginaActual.Text) - 1) + 1, 15))
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
