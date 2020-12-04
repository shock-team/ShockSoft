﻿using ShockSoft.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShockSoft.Presentacion.ABMC
{
    public partial class Form_AMCProveedor : Form
    {
        ControladorProveedores controlador;
        public Form_AMCProveedor()
        {
            InitializeComponent();

            controlador = ControladorProveedores.ObtenerInstancia();
            btnAnterior.Enabled = false;
            btnAnterior.Visible = false;

            ActualizarTabla();
        }

        public void ActualizarTabla()
        {
            btnSiguiente.Enabled = true;
            btnSiguiente.Visible = true;
            dgProveedores.Rows.Clear();
            int CANTIDAD_POR_PAGINA = 15;

            List<Proveedor> listaDeProveedores = controlador.ListarProveedores(
                CANTIDAD_POR_PAGINA * (int.Parse(lblPaginaActual.Text) - 1),
                CANTIDAD_POR_PAGINA + 1
                );

            if (listaDeProveedores.Count < (CANTIDAD_POR_PAGINA + 1))
            {
                btnSiguiente.Enabled = false;
                btnSiguiente.Visible = false;
            }

            foreach (Proveedor proveedor in listaDeProveedores)
            {
                dgProveedores.Rows.Add(proveedor.IdProveedor, proveedor.Nombre);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            FormsHelper.PaginaAnterior(btnSiguiente, btnAnterior, lblPaginaActual);
            ActualizarTabla();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            FormsHelper.SiguientePagina(btnSiguiente, btnAnterior, lblPaginaActual, controlador.ObtenerCantidadDeProveedores());
            ActualizarTabla();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarProveedor(txtAñadirNombre.Text);
                ActualizarTabla();
                MessageBox.Show($"El proveedor {txtAñadirNombre.Text} se ha añadido correctamente", "Aviso");
                txtAñadirNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.ModificarProveedor(int.Parse(txtModificarID.Text), txtModificarNombre.Text);
                ActualizarTabla();
                MessageBox.Show($"Se ha cambiado el nombre del proveedor a {txtModificarNombre.Text}", "Aviso");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                txtModificarID.Clear();
                txtModificarNombre.Clear();
            }
        }

        private void dgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModificarID.Text = dgProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtModificarNombre.Text = dgProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}