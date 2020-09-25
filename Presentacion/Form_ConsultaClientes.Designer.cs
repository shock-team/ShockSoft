namespace ShockSoft.Presentacion
{
    partial class Form_ConsultaClientes
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.cbConDeudas = new System.Windows.Forms.CheckBox();
            this.cbSinDeudas = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(148, 348);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.ValorCambiado);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(148, 384);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(146, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.ValorCambiado);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(148, 418);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(146, 20);
            this.txtCUIT.TabIndex = 3;
            this.txtCUIT.TextChanged += new System.EventHandler(this.ValorCambiado);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(71, 351);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(71, 387);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(71, 421);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 6;
            this.lblCUIT.Text = "CUIT";
            // 
            // cbConDeudas
            // 
            this.cbConDeudas.AutoSize = true;
            this.cbConDeudas.Location = new System.Drawing.Point(337, 351);
            this.cbConDeudas.Name = "cbConDeudas";
            this.cbConDeudas.Size = new System.Drawing.Size(83, 17);
            this.cbConDeudas.TabIndex = 7;
            this.cbConDeudas.Text = "Con deudas";
            this.cbConDeudas.UseVisualStyleBackColor = true;
            this.cbConDeudas.CheckedChanged += new System.EventHandler(this.ValorCambiado);
            // 
            // cbSinDeudas
            // 
            this.cbSinDeudas.AutoSize = true;
            this.cbSinDeudas.Location = new System.Drawing.Point(337, 386);
            this.cbSinDeudas.Name = "cbSinDeudas";
            this.cbSinDeudas.Size = new System.Drawing.Size(79, 17);
            this.cbSinDeudas.TabIndex = 8;
            this.cbSinDeudas.Text = "Sin deudas";
            this.cbSinDeudas.UseVisualStyleBackColor = true;
            this.cbSinDeudas.CheckedChanged += new System.EventHandler(this.ValorCambiado);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(623, 416);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(12, 12);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(776, 313);
            this.dgClientes.TabIndex = 11;
            this.dgClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgClientes_CellDoubleClick);
            // 
            // Form_ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbSinDeudas);
            this.Controls.Add(this.cbConDeudas);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form_ConsultaClientes";
            this.Text = "Form_ConsultaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.CheckBox cbConDeudas;
        private System.Windows.Forms.CheckBox cbSinDeudas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgClientes;
    }
}