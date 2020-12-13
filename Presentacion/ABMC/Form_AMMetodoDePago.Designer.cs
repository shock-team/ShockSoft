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
            this.lblNuevoMetodoPago = new System.Windows.Forms.Label();
            this.txtIdMetodoPago = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblValorMultiplicador = new System.Windows.Forms.Label();
            this.txtValorMuliplicador = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdMetodoPago
            // 
            this.lblIdMetodoPago.AutoSize = true;
            this.lblIdMetodoPago.Location = new System.Drawing.Point(111, 22);
            this.lblIdMetodoPago.Name = "lblIdMetodoPago";
            this.lblIdMetodoPago.Size = new System.Drawing.Size(21, 13);
            this.lblIdMetodoPago.TabIndex = 0;
            this.lblIdMetodoPago.Text = "ID:";
            // 
            // lblNuevoMetodoPago
            // 
            this.lblNuevoMetodoPago.AutoSize = true;
            this.lblNuevoMetodoPago.Location = new System.Drawing.Point(113, 22);
            this.lblNuevoMetodoPago.Name = "lblNuevoMetodoPago";
            this.lblNuevoMetodoPago.Size = new System.Drawing.Size(119, 13);
            this.lblNuevoMetodoPago.TabIndex = 1;
            this.lblNuevoMetodoPago.Text = "Nuevo método de pago";
            this.lblNuevoMetodoPago.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdMetodoPago
            // 
            this.txtIdMetodoPago.Enabled = false;
            this.txtIdMetodoPago.Location = new System.Drawing.Point(138, 19);
            this.txtIdMetodoPago.Name = "txtIdMetodoPago";
            this.txtIdMetodoPago.ReadOnly = true;
            this.txtIdMetodoPago.Size = new System.Drawing.Size(100, 20);
            this.txtIdMetodoPago.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(67, 57);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 54);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(249, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lblValorMultiplicador
            // 
            this.lblValorMultiplicador.AutoSize = true;
            this.lblValorMultiplicador.Location = new System.Drawing.Point(21, 93);
            this.lblValorMultiplicador.Name = "lblValorMultiplicador";
            this.lblValorMultiplicador.Size = new System.Drawing.Size(112, 13);
            this.lblValorMultiplicador.TabIndex = 5;
            this.lblValorMultiplicador.Text = "Valor del multiplicador:";
            // 
            // txtValorMuliplicador
            // 
            this.txtValorMuliplicador.Location = new System.Drawing.Point(139, 90);
            this.txtValorMuliplicador.Name = "txtValorMuliplicador";
            this.txtValorMuliplicador.Size = new System.Drawing.Size(99, 20);
            this.txtValorMuliplicador.TabIndex = 6;
            this.txtValorMuliplicador.Text = "1.0";
            this.txtValorMuliplicador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorMuliplicador_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(313, 88);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // Form_AMMetodoDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 132);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtValorMuliplicador);
            this.Controls.Add(this.lblValorMultiplicador);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtIdMetodoPago);
            this.Controls.Add(this.lblIdMetodoPago);
            this.Controls.Add(this.lblNuevoMetodoPago);
            this.Name = "Form_AMMetodoDePago";
            this.Text = "Form_AMMetodoDePago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdMetodoPago;
        private System.Windows.Forms.Label lblNuevoMetodoPago;
        private System.Windows.Forms.TextBox txtIdMetodoPago;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblValorMultiplicador;
        private System.Windows.Forms.TextBox txtValorMuliplicador;
        private System.Windows.Forms.Button btnAceptar;
    }
}