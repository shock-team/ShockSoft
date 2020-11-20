namespace ShockSoft.Presentacion
{
    partial class Form_ConsultarReparaciones
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
            this.dgReparaciones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbEntregado = new System.Windows.Forms.CheckBox();
            this.cbPendiente = new System.Windows.Forms.CheckBox();
            this.cbReparado = new System.Windows.Forms.CheckBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReparaciones
            // 
            this.dgReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReparaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FechaIngreso,
            this.Cliente,
            this.Rubro,
            this.Problema,
            this.Entregado});
            this.dgReparaciones.Location = new System.Drawing.Point(22, 61);
            this.dgReparaciones.Name = "dgReparaciones";
            this.dgReparaciones.Size = new System.Drawing.Size(862, 346);
            this.dgReparaciones.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha de ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Width = 120;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 200;
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            // 
            // Problema
            // 
            this.Problema.HeaderText = "Problema";
            this.Problema.Name = "Problema";
            this.Problema.Width = 200;
            // 
            // Entregado
            // 
            this.Entregado.HeaderText = "Entregado";
            this.Entregado.Name = "Entregado";
            // 
            // cbEntregado
            // 
            this.cbEntregado.AutoSize = true;
            this.cbEntregado.Location = new System.Drawing.Point(558, 26);
            this.cbEntregado.Name = "cbEntregado";
            this.cbEntregado.Size = new System.Drawing.Size(75, 17);
            this.cbEntregado.TabIndex = 1;
            this.cbEntregado.Text = "Entregado";
            this.cbEntregado.UseVisualStyleBackColor = true;
            // 
            // cbPendiente
            // 
            this.cbPendiente.AutoSize = true;
            this.cbPendiente.Location = new System.Drawing.Point(375, 26);
            this.cbPendiente.Name = "cbPendiente";
            this.cbPendiente.Size = new System.Drawing.Size(74, 17);
            this.cbPendiente.TabIndex = 2;
            this.cbPendiente.Text = "Pendiente";
            this.cbPendiente.UseVisualStyleBackColor = true;
            // 
            // cbReparado
            // 
            this.cbReparado.AutoSize = true;
            this.cbReparado.Location = new System.Drawing.Point(470, 26);
            this.cbReparado.Name = "cbReparado";
            this.cbReparado.Size = new System.Drawing.Size(73, 17);
            this.cbReparado.TabIndex = 3;
            this.cbReparado.Text = "Reparado";
            this.cbReparado.UseVisualStyleBackColor = true;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(75, 12);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 4;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(75, 38);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(221, 20);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(191, 10);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(105, 23);
            this.btnBuscarCliente.TabIndex = 6;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(48, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // Form_ConsultarReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 419);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.cbReparado);
            this.Controls.Add(this.cbPendiente);
            this.Controls.Add(this.cbEntregado);
            this.Controls.Add(this.dgReparaciones);
            this.Name = "Form_ConsultarReparaciones";
            this.Text = "Form_ConsultarReparaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgReparaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReparaciones;
        private System.Windows.Forms.CheckBox cbEntregado;
        private System.Windows.Forms.CheckBox cbPendiente;
        private System.Windows.Forms.CheckBox cbReparado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Problema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entregado;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
    }
}