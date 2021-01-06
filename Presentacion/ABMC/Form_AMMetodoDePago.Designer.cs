namespace ShockSoft.Presentacion.ABMC
{
    partial class Form_AMMetodoDePago
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
            this.lblIdMetodoPago = new System.Windows.Forms.Label();
            this.txtIdMetodoPago = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblValorMultiplicador = new System.Windows.Forms.Label();
            this.txtValorMuliplicador = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.picShock = new System.Windows.Forms.PictureBox();
            this.lblShock = new System.Windows.Forms.Label();
            this.btnTamano = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNuevoMetodoPago = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdMetodoPago
            // 
            this.lblIdMetodoPago.AutoSize = true;
            this.lblIdMetodoPago.Location = new System.Drawing.Point(152, 41);
            this.lblIdMetodoPago.Name = "lblIdMetodoPago";
            this.lblIdMetodoPago.Size = new System.Drawing.Size(27, 19);
            this.lblIdMetodoPago.TabIndex = 0;
            this.lblIdMetodoPago.Text = "ID:";
            // 
            // txtIdMetodoPago
            // 
            this.txtIdMetodoPago.Enabled = false;
            this.txtIdMetodoPago.Location = new System.Drawing.Point(185, 38);
            this.txtIdMetodoPago.Name = "txtIdMetodoPago";
            this.txtIdMetodoPago.ReadOnly = true;
            this.txtIdMetodoPago.Size = new System.Drawing.Size(145, 25);
            this.txtIdMetodoPago.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(88, 76);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 19);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(185, 73);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(249, 25);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblValorMultiplicador
            // 
            this.lblValorMultiplicador.AutoSize = true;
            this.lblValorMultiplicador.Location = new System.Drawing.Point(11, 112);
            this.lblValorMultiplicador.Name = "lblValorMultiplicador";
            this.lblValorMultiplicador.Size = new System.Drawing.Size(168, 19);
            this.lblValorMultiplicador.TabIndex = 5;
            this.lblValorMultiplicador.Text = "Valor del multiplicador:";
            // 
            // txtValorMuliplicador
            // 
            this.txtValorMuliplicador.Location = new System.Drawing.Point(186, 109);
            this.txtValorMuliplicador.Name = "txtValorMuliplicador";
            this.txtValorMuliplicador.Size = new System.Drawing.Size(110, 25);
            this.txtValorMuliplicador.TabIndex = 6;
            this.txtValorMuliplicador.Text = "1,0";
            this.txtValorMuliplicador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorMuliplicador_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(40)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(302, 109);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(132, 28);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
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
            this.panelControl.Size = new System.Drawing.Size(500, 45);
            this.panelControl.TabIndex = 26;
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
            this.btnMinimizar.Location = new System.Drawing.Point(365, 0);
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
            this.btnTamano.Location = new System.Drawing.Point(410, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(455, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 45);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(60)))), ((int)(((byte)(55)))));
            this.groupBox2.Controls.Add(this.txtIdMetodoPago);
            this.groupBox2.Controls.Add(this.lblIdMetodoPago);
            this.groupBox2.Controls.Add(this.btnAceptar);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.txtValorMuliplicador);
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Controls.Add(this.lblValorMultiplicador);
            this.groupBox2.Controls.Add(this.lblNuevoMetodoPago);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(21, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 158);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Método de pago";
            // 
            // lblNuevoMetodoPago
            // 
            this.lblNuevoMetodoPago.AutoSize = true;
            this.lblNuevoMetodoPago.Location = new System.Drawing.Point(152, 41);
            this.lblNuevoMetodoPago.Name = "lblNuevoMetodoPago";
            this.lblNuevoMetodoPago.Size = new System.Drawing.Size(170, 19);
            this.lblNuevoMetodoPago.TabIndex = 8;
            this.lblNuevoMetodoPago.Text = "Nuevo método de pago";
            // 
            // Form_AMMetodoDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(80)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(500, 245);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AMMetodoDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métodos de Pago";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIdMetodoPago;
        private System.Windows.Forms.TextBox txtIdMetodoPago;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblValorMultiplicador;
        private System.Windows.Forms.TextBox txtValorMuliplicador;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox picShock;
        private System.Windows.Forms.Label lblShock;
        private System.Windows.Forms.Button btnTamano;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNuevoMetodoPago;
    }
}