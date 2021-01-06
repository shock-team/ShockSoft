using ShockSoft.Dominio;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using ShockSoft.Excepciones;
using System.Drawing;

namespace ShockSoft.Presentacion
{
    public partial class Form_AgregarProducto : Form
    {
        ControladorProductos controlador;

        public Form_AgregarProducto()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblShock.Text = $"{Properties.Settings.Default.AppName}: {this.Text}";

            controlador = ControladorProductos.ObtenerInstancia();

            //Carga las marcas en el ComboBox
            List<Marca> marcas = ControladorMarcas.ObtenerInstancia().ListarMarcas().OrderBy(x => x.Descripcion).ToList();
            foreach (Marca marca in marcas)
            {
                comboMarca.Items.Add(marca);
            }
            comboMarca.DisplayMember = "Descripcion";
            comboMarca.ValueMember = "IdMarca";

            //Carga los IVAs en el ComboBox
            foreach (Parametro iva in ControladorParametros.ObtenerInstancia().ListarParametros())
            {
                if (iva.IdParametro != 1)
                {
                    comboIVA.Items.Add(iva);
                }
            }
            comboIVA.DisplayMember = "Descripcion";
            comboIVA.ValueMember = "IdParametro";

            //Carga los rubros en el ComboBox
            List<Rubro> rubros = ControladorRubros.ObtenerInstancia().ListarRubros().OrderBy(x => x.Descripcion).ToList();
            foreach (Rubro rubro in rubros)
            {
                comboRubro.Items.Add(rubro);
            }
            comboRubro.DisplayMember = "Descripcion";
            comboRubro.ValueMember = "IdRubro";
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
            try
            {
                int idParametro = comboIVA.SelectedItem == null ? 0 : ((Parametro)comboIVA.SelectedItem).IdParametro;
                int idMarca = comboMarca.SelectedItem == null ? 0 : ((Marca)comboMarca.SelectedItem).IdMarca;
                int idRubro = comboRubro.SelectedItem == null ? 0 : ((Rubro)comboRubro.SelectedItem).IdRubro;

                controlador.AgregarProducto(
                    txtDescripcion.Text, 
                    txtComentarios.Text,
                    float.Parse(txtPrecio.Text), 
                    float.Parse(txtGanancia.Text),
                    idParametro,
                    idMarca, 
                    idRubro);
                MessageBox.Show("El producto ha sido agregado correctamente", "Éxito");
            }
            catch (DatosFaltantesException)
            {
                MessageBox.Show("Por favor, complete todos los campos para continuar", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Form_AgregarMarca form_AgregarMarca = new Form_AgregarMarca();
            this.Hide();
            form_AgregarMarca.ShowDialog();
            this.Show();
        }
    }
}
