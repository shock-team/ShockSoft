namespace ShockSoft.Presentacion
{
    partial class Form_AgregarVenta
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dglineasDeVenta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarLinea = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.comboMetodoPago = new System.Windows.Forms.ComboBox();
            this.btnAgregarMetodo = new System.Windows.Forms.Button();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dglineasDeVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(573, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(53, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(63, 311);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(140, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(23, 314);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(520, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(26, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "ID:";
            // 
            // dglineasDeVenta
            // 
            this.dglineasDeVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglineasDeVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.PrecioUnitario,
            this.Cantidad,
            this.Subtotal});
            this.dglineasDeVenta.Location = new System.Drawing.Point(29, 53);
            this.dglineasDeVenta.Name = "dglineasDeVenta";
            this.dglineasDeVenta.Size = new System.Drawing.Size(844, 252);
            this.dglineasDeVenta.TabIndex = 6;
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
            this.Descripcion.Width = 400;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // btnAgregarLinea
            // 
            this.btnAgregarLinea.Location = new System.Drawing.Point(221, 311);
            this.btnAgregarLinea.Name = "btnAgregarLinea";
            this.btnAgregarLinea.Size = new System.Drawing.Size(94, 23);
            this.btnAgregarLinea.TabIndex = 7;
            this.btnAgregarLinea.Text = "Agregar línea";
            this.btnAgregarLinea.UseVisualStyleBackColor = true;
            this.btnAgregarLinea.Click += new System.EventHandler(this.BtnAgregarLinea_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(798, 311);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // comboMetodoPago
            // 
            this.comboMetodoPago.FormattingEnabled = true;
            this.comboMetodoPago.Location = new System.Drawing.Point(434, 311);
            this.comboMetodoPago.Name = "comboMetodoPago";
            this.comboMetodoPago.Size = new System.Drawing.Size(196, 21);
            this.comboMetodoPago.TabIndex = 9;
            // 
            // btnAgregarMetodo
            // 
            this.btnAgregarMetodo.Location = new System.Drawing.Point(636, 311);
            this.btnAgregarMetodo.Name = "btnAgregarMetodo";
            this.btnAgregarMetodo.Size = new System.Drawing.Size(137, 23);
            this.btnAgregarMetodo.TabIndex = 10;
            this.btnAgregarMetodo.Text = "Agregar método de pago";
            this.btnAgregarMetodo.UseVisualStyleBackColor = true;
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(340, 314);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(88, 13);
            this.lblMetodoPago.TabIndex = 11;
            this.lblMetodoPago.Text = "Método de pago:";
            // 
            // Form_AgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 343);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.btnAgregarMetodo);
            this.Controls.Add(this.comboMetodoPago);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregarLinea);
            this.Controls.Add(this.dglineasDeVenta);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form_AgregarVenta";
            this.Text = "Form_AgregarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dglineasDeVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dglineasDeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button btnAgregarLinea;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox comboMetodoPago;
        private System.Windows.Forms.Button btnAgregarMetodo;
        private System.Windows.Forms.Label lblMetodoPago;
    }
}