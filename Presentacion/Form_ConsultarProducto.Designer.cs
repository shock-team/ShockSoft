namespace ShockSoft.Presentacion
{
    partial class Form_ConsultarProducto
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
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbMostrarProductosBaja = new System.Windows.Forms.CheckBox();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAltaBaja = new System.Windows.Forms.Button();
            this.btnHistorialVenta = new System.Windows.Forms.Button();
            this.btnHistorialCompra = new System.Windows.Forms.Button();
            this.cbSinStock = new System.Windows.Forms.CheckBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(13, 19);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(37, 13);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtros:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(87, 19);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(185, 16);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(222, 20);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.ValorCambiado);
            // 
            // cbMostrarProductosBaja
            // 
            this.cbMostrarProductosBaja.AutoSize = true;
            this.cbMostrarProductosBaja.Location = new System.Drawing.Point(90, 55);
            this.cbMostrarProductosBaja.Name = "cbMostrarProductosBaja";
            this.cbMostrarProductosBaja.Size = new System.Drawing.Size(181, 17);
            this.cbMostrarProductosBaja.TabIndex = 5;
            this.cbMostrarProductosBaja.Text = "Mostrar productos dados de baja";
            this.cbMostrarProductosBaja.UseVisualStyleBackColor = true;
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(12, 81);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(776, 272);
            this.dgProductos.TabIndex = 6;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(16, 415);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 7;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(110, 415);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAltaBaja
            // 
            this.btnAltaBaja.Location = new System.Drawing.Point(204, 415);
            this.btnAltaBaja.Name = "btnAltaBaja";
            this.btnAltaBaja.Size = new System.Drawing.Size(75, 23);
            this.btnAltaBaja.TabIndex = 9;
            this.btnAltaBaja.Text = "Alta/Baja";
            this.btnAltaBaja.UseVisualStyleBackColor = true;
            // 
            // btnHistorialVenta
            // 
            this.btnHistorialVenta.Location = new System.Drawing.Point(650, 415);
            this.btnHistorialVenta.Name = "btnHistorialVenta";
            this.btnHistorialVenta.Size = new System.Drawing.Size(138, 23);
            this.btnHistorialVenta.TabIndex = 10;
            this.btnHistorialVenta.Text = "Historial de Venta";
            this.btnHistorialVenta.UseVisualStyleBackColor = true;
            // 
            // btnHistorialCompra
            // 
            this.btnHistorialCompra.Location = new System.Drawing.Point(501, 415);
            this.btnHistorialCompra.Name = "btnHistorialCompra";
            this.btnHistorialCompra.Size = new System.Drawing.Size(138, 23);
            this.btnHistorialCompra.TabIndex = 11;
            this.btnHistorialCompra.Text = "Historial de Compra";
            this.btnHistorialCompra.UseVisualStyleBackColor = true;
            // 
            // cbSinStock
            // 
            this.cbSinStock.AutoSize = true;
            this.cbSinStock.Location = new System.Drawing.Point(590, 55);
            this.cbSinStock.Name = "cbSinStock";
            this.cbSinStock.Size = new System.Drawing.Size(156, 17);
            this.cbSinStock.TabIndex = 14;
            this.cbSinStock.Text = "Mostrar productos sin stock";
            this.cbSinStock.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(587, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(646, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 16;
            // 
            // Form_ConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cbSinStock);
            this.Controls.Add(this.btnHistorialCompra);
            this.Controls.Add(this.btnHistorialVenta);
            this.Controls.Add(this.btnAltaBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.cbMostrarProductosBaja);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFiltro);
            this.Name = "Form_ConsultarProducto";
            this.Text = "Form_ConsultarProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox cbMostrarProductosBaja;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAltaBaja;
        private System.Windows.Forms.Button btnHistorialVenta;
        private System.Windows.Forms.Button btnHistorialCompra;
        private System.Windows.Forms.CheckBox cbSinStock;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
    }
}