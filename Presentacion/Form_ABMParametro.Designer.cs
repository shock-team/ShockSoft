namespace ShockSoft.Presentacion
{
    partial class Form_ABMParametro
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
            this.dgParametros = new System.Windows.Forms.DataGridView();
            this.IdParametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.dgPrecioDolar = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.lblDolar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.picShock = new System.Windows.Forms.PictureBox();
            this.lblShock = new System.Windows.Forms.Label();
            this.btnTamano = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblPaginaActual = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgParametros)).BeginInit();
            this.gbParametros.SuspendLayout();
            this.dgPrecioDolar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgParametros
            // 
            this.dgParametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParametros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdParametro,
            this.descripcion,
            this.valor});
            this.dgParametros.Location = new System.Drawing.Point(6, 31);
            this.dgParametros.Name = "dgParametros";
            this.dgParametros.Size = new System.Drawing.Size(421, 244);
            this.dgParametros.TabIndex = 0;
            // 
            // IdParametro
            // 
            this.IdParametro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdParametro.HeaderText = "ID";
            this.IdParametro.Name = "IdParametro";
            this.IdParametro.ReadOnly = true;
            this.IdParametro.Width = 48;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 70;
            // 
            // gbParametros
            // 
            this.gbParametros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.gbParametros.Controls.Add(this.lblPaginaActual);
            this.gbParametros.Controls.Add(this.btnAnterior);
            this.gbParametros.Controls.Add(this.btnSiguiente);
            this.gbParametros.Controls.Add(this.dgParametros);
            this.gbParametros.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbParametros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbParametros.Location = new System.Drawing.Point(12, 60);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(435, 328);
            this.gbParametros.TabIndex = 4;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // dgPrecioDolar
            // 
            this.dgPrecioDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.dgPrecioDolar.Controls.Add(this.btnGuardar);
            this.dgPrecioDolar.Controls.Add(this.txtDolar);
            this.dgPrecioDolar.Controls.Add(this.lblDolar);
            this.dgPrecioDolar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgPrecioDolar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgPrecioDolar.Location = new System.Drawing.Point(453, 60);
            this.dgPrecioDolar.Name = "dgPrecioDolar";
            this.dgPrecioDolar.Size = new System.Drawing.Size(235, 128);
            this.dgPrecioDolar.TabIndex = 5;
            this.dgPrecioDolar.TabStop = false;
            this.dgPrecioDolar.Text = "Precio Dólar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(9, 83);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 28);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(78, 40);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(151, 25);
            this.txtDolar.TabIndex = 1;
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(26, 43);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(45, 19);
            this.lblDolar.TabIndex = 0;
            this.lblDolar.Text = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(453, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir Parametro";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(94, 114);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(135, 25);
            this.txtValor.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(13, 72);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(216, 25);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(9, 117);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 19);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Location = new System.Drawing.Point(9, 153);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(220, 28);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 45);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 19);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción";
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
            this.panelControl.Size = new System.Drawing.Size(700, 45);
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
            this.btnMinimizar.Location = new System.Drawing.Point(565, 0);
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
            this.btnTamano.Location = new System.Drawing.Point(610, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(655, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 45);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblPaginaActual
            // 
            this.lblPaginaActual.AutoSize = true;
            this.lblPaginaActual.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginaActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPaginaActual.Location = new System.Drawing.Point(210, 293);
            this.lblPaginaActual.Name = "lblPaginaActual";
            this.lblPaginaActual.Size = new System.Drawing.Size(15, 17);
            this.lblPaginaActual.TabIndex = 20;
            this.lblPaginaActual.Text = "1";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnterior.Location = new System.Drawing.Point(85, 287);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(100, 28);
            this.btnAnterior.TabIndex = 19;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSiguiente.Location = new System.Drawing.Point(245, 287);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 28);
            this.btnSiguiente.TabIndex = 18;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // Form_ABMParametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgPrecioDolar);
            this.Controls.Add(this.gbParametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ABMParametro";
            this.Text = "Form_ABMParametro";
            ((System.ComponentModel.ISupportInitialize)(this.dgParametros)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.dgPrecioDolar.ResumeLayout(false);
            this.dgPrecioDolar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgParametros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdParametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.GroupBox dgPrecioDolar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox picShock;
        private System.Windows.Forms.Label lblShock;
        private System.Windows.Forms.Button btnTamano;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblPaginaActual;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
    }
}