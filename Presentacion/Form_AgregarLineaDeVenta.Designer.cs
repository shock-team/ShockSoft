namespace ShockSoft.Presentacion
{
    partial class Form_AgregarLineaDeVenta
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
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.nmCantidad = new System.Windows.Forms.NumericUpDown();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.picShock = new System.Windows.Forms.PictureBox();
            this.lblShock = new System.Windows.Forms.Label();
            this.btnTamano = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtPrecioUnitario.Location = new System.Drawing.Point(12, 45);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.ReadOnly = true;
            this.txtPrecioUnitario.Size = new System.Drawing.Size(150, 25);
            this.txtPrecioUnitario.TabIndex = 4;
            this.txtPrecioUnitario.Text = "0";
            // 
            // nmCantidad
            // 
            this.nmCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.nmCantidad.Location = new System.Drawing.Point(287, 45);
            this.nmCantidad.Name = "nmCantidad";
            this.nmCantidad.Size = new System.Drawing.Size(150, 25);
            this.nmCantidad.TabIndex = 7;
            this.nmCantidad.ValueChanged += new System.EventHandler(this.NmCantidad_ValueChanged);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtSubtotal.Location = new System.Drawing.Point(110, 84);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(214, 25);
            this.txtSubtotal.TabIndex = 9;
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
            this.panelControl.Size = new System.Drawing.Size(540, 45);
            this.panelControl.TabIndex = 23;
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
            this.btnMinimizar.Location = new System.Drawing.Point(405, 0);
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
            this.btnTamano.Location = new System.Drawing.Point(450, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(495, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 45);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Location = new System.Drawing.Point(30, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 47);
            this.panel1.TabIndex = 24;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscar.Location = new System.Drawing.Point(350, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 45);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblId.Location = new System.Drawing.Point(8, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 19);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(110, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(230, 25);
            this.txtId.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Location = new System.Drawing.Point(30, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 47);
            this.panel2.TabIndex = 25;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 12);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 19);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(110, 11);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(360, 25);
            this.txtDescripcion.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(65)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.lblSubtotal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblCantidad);
            this.panel3.Controls.Add(this.lblPrecioUnitario);
            this.panel3.Controls.Add(this.txtPrecioUnitario);
            this.panel3.Controls.Add(this.nmCantidad);
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Location = new System.Drawing.Point(30, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 122);
            this.panel3.TabIndex = 26;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(8, 12);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(112, 19);
            this.lblPrecioUnitario.TabIndex = 1;
            this.lblPrecioUnitario.Text = "Precio unitario:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Location = new System.Drawing.Point(283, 12);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(215, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubtotal.Location = new System.Drawing.Point(11, 87);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(69, 19);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(30, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(480, 28);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form_AgregarLineaDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(540, 350);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AgregarLineaDeVenta";
            this.Text = "Form_AgregarLineaDeVenta";
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.NumericUpDown nmCantidad;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox picShock;
        private System.Windows.Forms.Label lblShock;
        private System.Windows.Forms.Button btnTamano;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Button btnAceptar;
    }
}