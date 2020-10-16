namespace ShockSoft.Presentacion
{
    partial class Form_DatosProducto
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioEnDolares = new System.Windows.Forms.Label();
            this.lblPorcentajeDeGanancia = new System.Windows.Forms.Label();
            this.lblEnVenta = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtPorcentajeDeGanancia = new System.Windows.Forms.TextBox();
            this.txtEnVenta = new System.Windows.Forms.TextBox();
            this.comboIVA = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAltaBaja = new System.Windows.Forms.Button();
            this.btnHistorialDeCompra = new System.Windows.Forms.Button();
            this.btnHistorialDeVenta = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(87, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(42, 78);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(56, 118);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecioEnDolares
            // 
            this.lblPrecioEnDolares.AutoSize = true;
            this.lblPrecioEnDolares.Location = new System.Drawing.Point(433, 39);
            this.lblPrecioEnDolares.Name = "lblPrecioEnDolares";
            this.lblPrecioEnDolares.Size = new System.Drawing.Size(92, 13);
            this.lblPrecioEnDolares.TabIndex = 3;
            this.lblPrecioEnDolares.Text = "Precio en dólares:";
            // 
            // lblPorcentajeDeGanancia
            // 
            this.lblPorcentajeDeGanancia.AutoSize = true;
            this.lblPorcentajeDeGanancia.Location = new System.Drawing.Point(402, 118);
            this.lblPorcentajeDeGanancia.Name = "lblPorcentajeDeGanancia";
            this.lblPorcentajeDeGanancia.Size = new System.Drawing.Size(123, 13);
            this.lblPorcentajeDeGanancia.TabIndex = 4;
            this.lblPorcentajeDeGanancia.Text = "Porcentaje de ganancia:";
            // 
            // lblEnVenta
            // 
            this.lblEnVenta.AutoSize = true;
            this.lblEnVenta.Location = new System.Drawing.Point(472, 156);
            this.lblEnVenta.Name = "lblEnVenta";
            this.lblEnVenta.Size = new System.Drawing.Size(53, 13);
            this.lblEnVenta.TabIndex = 5;
            this.lblEnVenta.Text = "En venta:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(68, 156);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(498, 78);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(27, 13);
            this.lblIVA.TabIndex = 7;
            this.lblIVA.Text = "IVA:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(134, 36);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(92, 20);
            this.txtId.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(134, 75);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(256, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(134, 115);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(149, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(549, 36);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(149, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // txtPorcentajeDeGanancia
            // 
            this.txtPorcentajeDeGanancia.Location = new System.Drawing.Point(549, 115);
            this.txtPorcentajeDeGanancia.Name = "txtPorcentajeDeGanancia";
            this.txtPorcentajeDeGanancia.Size = new System.Drawing.Size(149, 20);
            this.txtPorcentajeDeGanancia.TabIndex = 12;
            // 
            // txtEnVenta
            // 
            this.txtEnVenta.Enabled = false;
            this.txtEnVenta.Location = new System.Drawing.Point(549, 153);
            this.txtEnVenta.Name = "txtEnVenta";
            this.txtEnVenta.ReadOnly = true;
            this.txtEnVenta.Size = new System.Drawing.Size(149, 20);
            this.txtEnVenta.TabIndex = 13;
            // 
            // comboIVA
            // 
            this.comboIVA.FormattingEnabled = true;
            this.comboIVA.Location = new System.Drawing.Point(549, 75);
            this.comboIVA.Name = "comboIVA";
            this.comboIVA.Size = new System.Drawing.Size(149, 21);
            this.comboIVA.TabIndex = 15;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(45, 219);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnAltaBaja
            // 
            this.btnAltaBaja.Location = new System.Drawing.Point(162, 219);
            this.btnAltaBaja.Name = "btnAltaBaja";
            this.btnAltaBaja.Size = new System.Drawing.Size(75, 23);
            this.btnAltaBaja.TabIndex = 17;
            this.btnAltaBaja.Text = "Alta / Baja";
            this.btnAltaBaja.UseVisualStyleBackColor = true;
            this.btnAltaBaja.Click += new System.EventHandler(this.BtnAltaBaja_Click);
            // 
            // btnHistorialDeCompra
            // 
            this.btnHistorialDeCompra.Location = new System.Drawing.Point(279, 219);
            this.btnHistorialDeCompra.Name = "btnHistorialDeCompra";
            this.btnHistorialDeCompra.Size = new System.Drawing.Size(130, 23);
            this.btnHistorialDeCompra.TabIndex = 18;
            this.btnHistorialDeCompra.Text = "Historial de compra";
            this.btnHistorialDeCompra.UseVisualStyleBackColor = true;
            this.btnHistorialDeCompra.Click += new System.EventHandler(this.BtnHistorialDeCompra_Click);
            // 
            // btnHistorialDeVenta
            // 
            this.btnHistorialDeVenta.Location = new System.Drawing.Point(451, 219);
            this.btnHistorialDeVenta.Name = "btnHistorialDeVenta";
            this.btnHistorialDeVenta.Size = new System.Drawing.Size(130, 23);
            this.btnHistorialDeVenta.TabIndex = 19;
            this.btnHistorialDeVenta.Text = "Historial de venta";
            this.btnHistorialDeVenta.UseVisualStyleBackColor = true;
            this.btnHistorialDeVenta.Click += new System.EventHandler(this.BtnHistorialDeVenta_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(134, 153);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(223, 20);
            this.txtMarca.TabIndex = 20;
            // 
            // Form_DatosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 266);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnHistorialDeVenta);
            this.Controls.Add(this.btnHistorialDeCompra);
            this.Controls.Add(this.btnAltaBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.comboIVA);
            this.Controls.Add(this.txtEnVenta);
            this.Controls.Add(this.txtPorcentajeDeGanancia);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblEnVenta);
            this.Controls.Add(this.lblPorcentajeDeGanancia);
            this.Controls.Add(this.lblPrecioEnDolares);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblId);
            this.Name = "Form_DatosProducto";
            this.Text = "Form_DatosProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioEnDolares;
        private System.Windows.Forms.Label lblPorcentajeDeGanancia;
        private System.Windows.Forms.Label lblEnVenta;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtPorcentajeDeGanancia;
        private System.Windows.Forms.TextBox txtEnVenta;
        private System.Windows.Forms.ComboBox comboIVA;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAltaBaja;
        private System.Windows.Forms.Button btnHistorialDeCompra;
        private System.Windows.Forms.Button btnHistorialDeVenta;
        private System.Windows.Forms.TextBox txtMarca;
    }
}