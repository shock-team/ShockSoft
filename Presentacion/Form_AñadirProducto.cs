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

namespace ShockSoft.Presentacion
{
    public partial class Form_AñadirProducto : Form
    {
        ControladorProductos controlador;

        public Form_AñadirProducto()
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

        private void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            controlador.AgregarProducto(txtDescripcion.Text, float.Parse(txtPrecio.Text), float.Parse(txtGanancia.Text), (int)comboIVA.SelectedItem, (int)comboMarca.SelectedItem);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
