﻿namespace ShockSoft.Presentacion
{
    partial class Form_AgregarReparacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblProblema = new System.Windows.Forms.Label();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.cbReparado = new System.Windows.Forms.CheckBox();
            this.dtpFechaReparacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReparacion = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cbIncluyeCargador = new System.Windows.Forms.CheckBox();
            this.cbIncluyeCables = new System.Windows.Forms.CheckBox();
            this.cbCobrado = new System.Windows.Forms.CheckBox();
            this.cbEntregado = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblTotalInsumos = new System.Windows.Forms.Label();
            this.txtTotalInsumos = new System.Windows.Forms.TextBox();
            this.lblSolucion = new System.Windows.Forms.Label();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.comboMetodoDePago = new System.Windows.Forms.ComboBox();
            this.lblCostoTrabajo = new System.Windows.Forms.Label();
            this.txtCostoTrabajo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(51, 19);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(72, 13);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "ID del cliente:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(25, 49);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(98, 13);
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text = "Nombre del cliente:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(129, 16);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 2;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(129, 46);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(265, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(249, 14);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(145, 23);
            this.btnBuscarCliente.TabIndex = 4;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(431, 21);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(92, 13);
            this.lblFechaIngreso.TabIndex = 5;
            this.lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(433, 46);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 6;
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(28, 97);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(54, 13);
            this.lblProblema.TabIndex = 7;
            this.lblProblema.Text = "Problema:";
            // 
            // txtProblema
            // 
            this.txtProblema.Location = new System.Drawing.Point(28, 113);
            this.txtProblema.Multiline = true;
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.Size = new System.Drawing.Size(366, 90);
            this.txtProblema.TabIndex = 8;
            // 
            // cbReparado
            // 
            this.cbReparado.AutoSize = true;
            this.cbReparado.Location = new System.Drawing.Point(772, 20);
            this.cbReparado.Name = "cbReparado";
            this.cbReparado.Size = new System.Drawing.Size(104, 17);
            this.cbReparado.TabIndex = 9;
            this.cbReparado.Text = "Equipo reparado";
            this.cbReparado.UseVisualStyleBackColor = true;
            // 
            // dtpFechaReparacion
            // 
            this.dtpFechaReparacion.Location = new System.Drawing.Point(661, 46);
            this.dtpFechaReparacion.Name = "dtpFechaReparacion";
            this.dtpFechaReparacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReparacion.TabIndex = 10;
            // 
            // lblFechaReparacion
            // 
            this.lblFechaReparacion.AutoSize = true;
            this.lblFechaReparacion.Location = new System.Drawing.Point(658, 21);
            this.lblFechaReparacion.Name = "lblFechaReparacion";
            this.lblFechaReparacion.Size = new System.Drawing.Size(108, 13);
            this.lblFechaReparacion.TabIndex = 11;
            this.lblFechaReparacion.Text = "Fecha de reparación:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(459, 116);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(64, 13);
            this.lblClave.TabIndex = 12;
            this.lblClave.Text = "Contraseña:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(529, 113);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(293, 20);
            this.txtClave.TabIndex = 13;
            // 
            // cbIncluyeCargador
            // 
            this.cbIncluyeCargador.AutoSize = true;
            this.cbIncluyeCargador.Location = new System.Drawing.Point(465, 163);
            this.cbIncluyeCargador.Name = "cbIncluyeCargador";
            this.cbIncluyeCargador.Size = new System.Drawing.Size(105, 17);
            this.cbIncluyeCargador.TabIndex = 14;
            this.cbIncluyeCargador.Text = "Incluye cargador";
            this.cbIncluyeCargador.UseVisualStyleBackColor = true;
            // 
            // cbIncluyeCables
            // 
            this.cbIncluyeCables.AutoSize = true;
            this.cbIncluyeCables.Location = new System.Drawing.Point(465, 186);
            this.cbIncluyeCables.Name = "cbIncluyeCables";
            this.cbIncluyeCables.Size = new System.Drawing.Size(94, 17);
            this.cbIncluyeCables.TabIndex = 15;
            this.cbIncluyeCables.Text = "Incluye cables";
            this.cbIncluyeCables.UseVisualStyleBackColor = true;
            // 
            // cbCobrado
            // 
            this.cbCobrado.AutoSize = true;
            this.cbCobrado.Location = new System.Drawing.Point(756, 186);
            this.cbCobrado.Name = "cbCobrado";
            this.cbCobrado.Size = new System.Drawing.Size(66, 17);
            this.cbCobrado.TabIndex = 17;
            this.cbCobrado.Text = "Cobrado";
            this.cbCobrado.UseVisualStyleBackColor = true;
            // 
            // cbEntregado
            // 
            this.cbEntregado.AutoSize = true;
            this.cbEntregado.Location = new System.Drawing.Point(756, 163);
            this.cbEntregado.Name = "cbEntregado";
            this.cbEntregado.Size = new System.Drawing.Size(75, 17);
            this.cbEntregado.TabIndex = 16;
            this.cbEntregado.Text = "Entregado";
            this.cbEntregado.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Cantidad,
            this.PrecioUnitario,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(28, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 194);
            this.dataGridView1.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 350;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(720, 473);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarProducto.TabIndex = 19;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // lblTotalInsumos
            // 
            this.lblTotalInsumos.AutoSize = true;
            this.lblTotalInsumos.Location = new System.Drawing.Point(28, 473);
            this.lblTotalInsumos.Name = "lblTotalInsumos";
            this.lblTotalInsumos.Size = new System.Drawing.Size(75, 13);
            this.lblTotalInsumos.TabIndex = 20;
            this.lblTotalInsumos.Text = "Total insumos:";
            // 
            // txtTotalInsumos
            // 
            this.txtTotalInsumos.Location = new System.Drawing.Point(109, 469);
            this.txtTotalInsumos.Name = "txtTotalInsumos";
            this.txtTotalInsumos.ReadOnly = true;
            this.txtTotalInsumos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalInsumos.TabIndex = 21;
            // 
            // lblSolucion
            // 
            this.lblSolucion.AutoSize = true;
            this.lblSolucion.Location = new System.Drawing.Point(28, 229);
            this.lblSolucion.Name = "lblSolucion";
            this.lblSolucion.Size = new System.Drawing.Size(48, 13);
            this.lblSolucion.TabIndex = 22;
            this.lblSolucion.Text = "Solución";
            // 
            // txtSolucion
            // 
            this.txtSolucion.Location = new System.Drawing.Point(82, 226);
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(740, 20);
            this.txtSolucion.TabIndex = 23;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(229, 473);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(88, 13);
            this.lblMetodoPago.TabIndex = 24;
            this.lblMetodoPago.Text = "Método de pago:";
            // 
            // comboMetodoDePago
            // 
            this.comboMetodoDePago.FormattingEnabled = true;
            this.comboMetodoDePago.Location = new System.Drawing.Point(323, 468);
            this.comboMetodoDePago.Name = "comboMetodoDePago";
            this.comboMetodoDePago.Size = new System.Drawing.Size(121, 21);
            this.comboMetodoDePago.TabIndex = 25;
            // 
            // lblCostoTrabajo
            // 
            this.lblCostoTrabajo.AutoSize = true;
            this.lblCostoTrabajo.Location = new System.Drawing.Point(14, 503);
            this.lblCostoTrabajo.Name = "lblCostoTrabajo";
            this.lblCostoTrabajo.Size = new System.Drawing.Size(89, 13);
            this.lblCostoTrabajo.TabIndex = 26;
            this.lblCostoTrabajo.Text = "Costo del trabajo:";
            // 
            // txtCostoTrabajo
            // 
            this.txtCostoTrabajo.Location = new System.Drawing.Point(109, 500);
            this.txtCostoTrabajo.Name = "txtCostoTrabajo";
            this.txtCostoTrabajo.Size = new System.Drawing.Size(100, 20);
            this.txtCostoTrabajo.TabIndex = 27;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(283, 503);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(323, 500);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 29;
            // 
            // Form_AgregarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 525);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtCostoTrabajo);
            this.Controls.Add(this.lblCostoTrabajo);
            this.Controls.Add(this.comboMetodoDePago);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.txtSolucion);
            this.Controls.Add(this.lblSolucion);
            this.Controls.Add(this.txtTotalInsumos);
            this.Controls.Add(this.lblTotalInsumos);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCobrado);
            this.Controls.Add(this.cbEntregado);
            this.Controls.Add(this.cbIncluyeCables);
            this.Controls.Add(this.cbIncluyeCargador);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblFechaReparacion);
            this.Controls.Add(this.dtpFechaReparacion);
            this.Controls.Add(this.cbReparado);
            this.Controls.Add(this.txtProblema);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Name = "Form_AgregarReparacion";
            this.Text = "Form_AgregarReparacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.CheckBox cbReparado;
        private System.Windows.Forms.DateTimePicker dtpFechaReparacion;
        private System.Windows.Forms.Label lblFechaReparacion;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.CheckBox cbIncluyeCargador;
        private System.Windows.Forms.CheckBox cbIncluyeCables;
        private System.Windows.Forms.CheckBox cbCobrado;
        private System.Windows.Forms.CheckBox cbEntregado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblTotalInsumos;
        private System.Windows.Forms.TextBox txtTotalInsumos;
        private System.Windows.Forms.Label lblSolucion;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox comboMetodoDePago;
        private System.Windows.Forms.Label lblCostoTrabajo;
        private System.Windows.Forms.TextBox txtCostoTrabajo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}