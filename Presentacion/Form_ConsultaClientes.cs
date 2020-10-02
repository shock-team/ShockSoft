using ShockSoft.Dominio;
using System.Data;
using System.Windows.Forms;

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
            cbConDeudas.Checked = true;
            cbSinDeudas.Checked = true;

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

            //Carga los datos a la DataTable
            foreach (Cliente cliente in controlador.ListarClientes(cbConDeudas.Checked, cbSinDeudas.Checked))
            {
                tablaDeClientes.Rows.Add(cliente.IdCliente, cliente.Nombre, cliente.Apellido, cliente.CUIT, cliente.ObtenerSaldo());
            }
        }

        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ValorCambiado(object sender, System.EventArgs e)
        {
            //Limpia la tabla y vuelve a cargarla
            tablaDeClientes.Rows.Clear();
            foreach (Cliente cliente in controlador.ListarClientes(cbConDeudas.Checked, cbSinDeudas.Checked, txtNombre.Text, txtApellido.Text, txtCUIT.Text))
            {
                tablaDeClientes.Rows.Add(cliente.IdCliente, cliente.Nombre, cliente.Apellido, cliente.CUIT, cliente.ObtenerSaldo());
            }
        }

        private void DgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Obtiene el cliente seleccionado a partir de su ID
            int clienteSeleccionado = tablaDeClientes.Rows[dgClientes.SelectedRows[0].Index].Field<int>("ID");
            Form_DatosCliente formDatosCliente = new Form_DatosCliente(clienteSeleccionado);
            formDatosCliente.Show();
            this.Hide();
        }
    }
}
