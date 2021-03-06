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
using Squirrel;

namespace ZonaSoft.Presentacion
{
    public partial class Form_MenuPrincipal : Form
    {
        private string localPath = @"C:\ZonaSoft\Releases";

        public Form_MenuPrincipal()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            lblShock.Text = $"{Properties.Settings.Default.AppName}: {this.Text}";

            //CheckForUpdates();
        }

        async void CheckForUpdates()
        {
            using (var manager = new UpdateManager(localPath))
            {
                await manager.UpdateApp();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Form_MenuProducto());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Form_MenuClientes());
        }

        private void btnReparaciones_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Form_MenuReparaciones());
        }

        private void AbrirFormHija(object formHija)
        {
            if (this.panelPrincipal.Controls.Count > 0)
            {
                this.panelPrincipal.Controls.RemoveAt(0);
            }

            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Form_MenuVentas());
        }
    }
}
