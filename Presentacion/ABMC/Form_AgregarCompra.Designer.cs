namespace ShockSoft.Presentacion.ABMC
{
    partial class Form_AgregarCompra
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgLineasDeCompra = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarLinea = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.comboProveedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDolarProveedor = new System.Windows.Forms.TextBox();
            this.btnDolarActual = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.picShock = new System.Windows.Forms.PictureBox();
            this.lblShock = new System.Windows.Forms.Label();
            this.btnTamano = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineasDeCompra)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(560, 109);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(606, 106);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(60, 388);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(100, 384);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(181, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // dgLineasDeCompra
            // 
            this.dgLineasDeCompra.AllowUserToAddRows = false;
            this.dgLineasDeCompra.AllowUserToDeleteRows = false;
            this.dgLineasDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineasDeCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.PrecioUnitario,
            this.Cantidad,
            this.Subtotal});
            this.dgLineasDeCompra.Location = new System.Drawing.Point(63, 153);
            this.dgLineasDeCompra.Name = "dgLineasDeCompra";
            this.dgLineasDeCompra.Size = new System.Drawing.Size(743, 225);
            this.dgLineasDeCompra.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 300;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnAgregarLinea
            // 
            this.btnAgregarLinea.Location = new System.Drawing.Point(296, 382);
            this.btnAgregarLinea.Name = "btnAgregarLinea";
            this.btnAgregarLinea.Size = new System.Drawing.Size(105, 23);
            this.btnAgregarLinea.TabIndex = 7;
            this.btnAgregarLinea.Text = "Agregar línea";
            this.btnAgregarLinea.UseVisualStyleBackColor = true;
            this.btnAgregarLinea.Click += new System.EventHandler(this.BtnAgregarLinea_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(731, 385);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(351, 79);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarProveedor.TabIndex = 9;
            this.btnAgregarProveedor.Text = "Agregar proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.BtnAgregarProveedor_Click);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(60, 85);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 10;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // comboProveedores
            // 
            this.comboProveedores.FormattingEnabled = true;
            this.comboProveedores.Location = new System.Drawing.Point(125, 80);
            this.comboProveedores.Name = "comboProveedores";
            this.comboProveedores.Size = new System.Drawing.Size(220, 21);
            this.comboProveedores.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dólar ($):";
            // 
            // txtDolarProveedor
            // 
            this.txtDolarProveedor.Location = new System.Drawing.Point(125, 113);
            this.txtDolarProveedor.Name = "txtDolarProveedor";
            this.txtDolarProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtDolarProveedor.TabIndex = 13;
            // 
            // btnDolarActual
            // 
            this.btnDolarActual.Location = new System.Drawing.Point(231, 111);
            this.btnDolarActual.Name = "btnDolarActual";
            this.btnDolarActual.Size = new System.Drawing.Size(75, 23);
            this.btnDolarActual.TabIndex = 14;
            this.btnDolarActual.Text = "Actual";
            this.btnDolarActual.UseVisualStyleBackColor = true;
            this.btnDolarActual.Click += new System.EventHandler(this.btnDolarActual_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelControl.Controls.Add(this.btnMinimizar);
            this.panelControl.Controls.Add(this.picShock);
            this.panelControl.Controls.Add(this.lblShock);
            this.panelControl.Controls.Add(this.btnTamano);
            this.panelControl.Controls.Add(this.btnCerrar);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(900, 45);
            this.panelControl.TabIndex = 25;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::ShockSoft.Properties.Resources.Shock_img02;
            this.btnMinimizar.Location = new System.Drawing.Point(765, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 45);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // picShock
            // 
            this.picShock.Image = global::ShockSoft.Properties.Resources.Shock_Simbol02;
            this.picShock.Location = new System.Drawing.Point(3, 3);
            this.picShock.Name = "picShock";
            this.picShock.Size = new System.Drawing.Size(40, 40);
            this.picShock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShock.TabIndex = 9;
            this.picShock.TabStop = false;
            // 
            // lblShock
            // 
            this.lblShock.AutoSize = true;
            this.lblShock.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShock.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblShock.Location = new System.Drawing.Point(40, 9);
            this.lblShock.Name = "lblShock";
            this.lblShock.Size = new System.Drawing.Size(129, 28);
            this.lblShock.TabIndex = 8;
            this.lblShock.Text = "Shock!Soft";
            // 
            // btnTamano
            // 
            this.btnTamano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnTamano.FlatAppearance.BorderSize = 0;
            this.btnTamano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnTamano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamano.Image = global::ShockSoft.Properties.Resources.Shock_img03;
            this.btnTamano.Location = new System.Drawing.Point(810, 0);
            this.btnTamano.Name = "btnTamano";
            this.btnTamano.Size = new System.Drawing.Size(45, 45);
            this.btnTamano.TabIndex = 7;
            this.btnTamano.UseVisualStyleBackColor = false;
            this.btnTamano.Click += new System.EventHandler(this.btnTamano_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::ShockSoft.Properties.Resources.Shock_img04;
            this.btnCerrar.Location = new System.Drawing.Point(855, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 45);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Form_AgregarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.btnDolarActual);
            this.Controls.Add(this.txtDolarProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboProveedores);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.btnAgregarProveedor);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregarLinea);
            this.Controls.Add(this.dgLineasDeCompra);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AgregarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AgregarCompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgLineasDeCompra)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgLineasDeCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btnAgregarLinea;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox comboProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDolarProveedor;
        private System.Windows.Forms.Button btnDolarActual;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox picShock;
        private System.Windows.Forms.Label lblShock;
        private System.Windows.Forms.Button btnTamano;
        private System.Windows.Forms.Button btnCerrar;
    }
}