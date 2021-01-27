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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgLineasDeCompra = new System.Windows.Forms.DataGridView();
            this.btnAgregarLinea = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineasDeCompra)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(24, 40);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(285, 25);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(22, 8);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 19);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(75, 6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(407, 25);
            this.txtTotal.TabIndex = 5;
            // 
            // dgLineasDeCompra
            // 
            this.dgLineasDeCompra.AllowUserToAddRows = false;
            this.dgLineasDeCompra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLineasDeCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgLineasDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineasDeCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.PrecioUnitario,
            this.Cantidad,
            this.Subtotal});
            this.dgLineasDeCompra.Location = new System.Drawing.Point(12, 168);
            this.dgLineasDeCompra.Name = "dgLineasDeCompra";
            this.dgLineasDeCompra.ReadOnly = true;
            this.dgLineasDeCompra.Size = new System.Drawing.Size(743, 225);
            this.dgLineasDeCompra.TabIndex = 6;
            this.dgLineasDeCompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLineasDeCompra_CellDoubleClick);
            // 
            // btnAgregarLinea
            // 
            this.btnAgregarLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAgregarLinea.FlatAppearance.BorderSize = 0;
            this.btnAgregarLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnAgregarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLinea.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarLinea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarLinea.Location = new System.Drawing.Point(12, 393);
            this.btnAgregarLinea.Name = "btnAgregarLinea";
            this.btnAgregarLinea.Size = new System.Drawing.Size(743, 28);
            this.btnAgregarLinea.TabIndex = 7;
            this.btnAgregarLinea.Text = "Agregar línea";
            this.btnAgregarLinea.UseVisualStyleBackColor = false;
            this.btnAgregarLinea.Click += new System.EventHandler(this.BtnAgregarLinea_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(719, 444);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(117, 28);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAgregarProveedor.FlatAppearance.BorderSize = 0;
            this.btnAgregarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(346, 30);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(121, 28);
            this.btnAgregarProveedor.TabIndex = 9;
            this.btnAgregarProveedor.Text = "Agregar proveedor";
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.BtnAgregarProveedor_Click);
            // 
            // comboProveedores
            // 
            this.comboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProveedores.FormattingEnabled = true;
            this.comboProveedores.Location = new System.Drawing.Point(20, 30);
            this.comboProveedores.Name = "comboProveedores";
            this.comboProveedores.Size = new System.Drawing.Size(320, 27);
            this.comboProveedores.Sorted = true;
            this.comboProveedores.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dólar ($):";
            // 
            // txtDolarProveedor
            // 
            this.txtDolarProveedor.Location = new System.Drawing.Point(105, 63);
            this.txtDolarProveedor.Name = "txtDolarProveedor";
            this.txtDolarProveedor.Size = new System.Drawing.Size(235, 25);
            this.txtDolarProveedor.TabIndex = 13;
            this.txtDolarProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDolarProveedor_KeyPress);
            // 
            // btnDolarActual
            // 
            this.btnDolarActual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDolarActual.FlatAppearance.BorderSize = 0;
            this.btnDolarActual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnDolarActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDolarActual.Location = new System.Drawing.Point(346, 62);
            this.btnDolarActual.Name = "btnDolarActual";
            this.btnDolarActual.Size = new System.Drawing.Size(121, 28);
            this.btnDolarActual.TabIndex = 14;
            this.btnDolarActual.Text = "Actual";
            this.btnDolarActual.UseVisualStyleBackColor = false;
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
            this.panelControl.Size = new System.Drawing.Size(854, 45);
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
            this.btnMinimizar.Location = new System.Drawing.Point(719, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 45);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // picShock
            // 
            this.picShock.Image = global::ShockSoft.Properties.Resources.LOGO_ZONA;
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
            this.lblShock.Size = new System.Drawing.Size(0, 28);
            this.lblShock.TabIndex = 8;
            // 
            // btnTamano
            // 
            this.btnTamano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnTamano.FlatAppearance.BorderSize = 0;
            this.btnTamano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnTamano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamano.Image = global::ShockSoft.Properties.Resources.Shock_img03;
            this.btnTamano.Location = new System.Drawing.Point(764, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(809, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 45);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.groupBox1.Controls.Add(this.comboProveedores);
            this.groupBox1.Controls.Add(this.btnAgregarProveedor);
            this.groupBox1.Controls.Add(this.btnDolarActual);
            this.groupBox1.Controls.Add(this.txtDolarProveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 102);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(510, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 102);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(12, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 37);
            this.panel1.TabIndex = 28;
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
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "0";
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // Form_AgregarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(854, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregarLinea);
            this.Controls.Add(this.dgLineasDeCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AgregarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgLineasDeCompra)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgLineasDeCompra;
        private System.Windows.Forms.Button btnAgregarLinea;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregarProveedor;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}