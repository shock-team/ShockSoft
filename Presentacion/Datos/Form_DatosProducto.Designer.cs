﻿namespace ZonaSoft.Presentacion
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.picShock = new System.Windows.Forms.PictureBox();
            this.lblShock = new System.Windows.Forms.Label();
            this.btnTamano = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblIVA = new System.Windows.Forms.Label();
            this.comboIVA = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMarca = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPrecioEnDolares = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.txtPorcentajeDeGanancia = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblEnVenta = new System.Windows.Forms.Label();
            this.txtEnVenta = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnHistorialVenta = new System.Windows.Forms.Button();
            this.btnHistorialCompra = new System.Windows.Forms.Button();
            this.btnAltaBaja = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
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
            this.panelControl.Size = new System.Drawing.Size(898, 45);
            this.panelControl.TabIndex = 27;
            this.panelControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControl_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::ZonaSoft.Properties.Resources.Shock_img02;
            this.btnMinimizar.Location = new System.Drawing.Point(763, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 45);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // picShock
            // 
            this.picShock.Image = global::ZonaSoft.Properties.Resources.LOGO_ZONA;
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
            this.btnTamano.Image = global::ZonaSoft.Properties.Resources.Shock_img03;
            this.btnTamano.Location = new System.Drawing.Point(808, 0);
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
            this.btnCerrar.Image = global::ZonaSoft.Properties.Resources.Shock_img04;
            this.btnCerrar.Location = new System.Drawing.Point(853, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 45);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.panel5.Controls.Add(this.lblIVA);
            this.panel5.Controls.Add(this.comboIVA);
            this.panel5.Location = new System.Drawing.Point(30, 180);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 47);
            this.panel5.TabIndex = 39;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIVA.Location = new System.Drawing.Point(8, 12);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(36, 19);
            this.lblIVA.TabIndex = 7;
            this.lblIVA.Text = "IVA:";
            // 
            // comboIVA
            // 
            this.comboIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIVA.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIVA.FormattingEnabled = true;
            this.comboIVA.Location = new System.Drawing.Point(80, 10);
            this.comboIVA.Name = "comboIVA";
            this.comboIVA.Size = new System.Drawing.Size(180, 27);
            this.comboIVA.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.panel4.Controls.Add(this.lblMarca);
            this.panel4.Controls.Add(this.comboMarca);
            this.panel4.Controls.Add(this.btnAgregarMarca);
            this.panel4.Location = new System.Drawing.Point(330, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(540, 47);
            this.panel4.TabIndex = 38;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMarca.Location = new System.Drawing.Point(8, 12);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 19);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca:";
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(120, 10);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(300, 27);
            this.comboMarca.Sorted = true;
            this.comboMarca.TabIndex = 18;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnAgregarMarca.FlatAppearance.BorderSize = 0;
            this.btnAgregarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnAgregarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarMarca.Location = new System.Drawing.Point(440, 0);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(100, 47);
            this.btnAgregarMarca.TabIndex = 15;
            this.btnAgregarMarca.Text = "Nueva Marca";
            this.btnAgregarMarca.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Location = new System.Drawing.Point(300, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 47);
            this.panel1.TabIndex = 35;
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
            this.txtDescripcion.Location = new System.Drawing.Point(150, 11);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(400, 25);
            this.txtDescripcion.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.lblPrecioEnDolares);
            this.panel2.Controls.Add(this.txtPrecio);
            this.panel2.Location = new System.Drawing.Point(30, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 47);
            this.panel2.TabIndex = 36;
            // 
            // lblPrecioEnDolares
            // 
            this.lblPrecioEnDolares.AutoSize = true;
            this.lblPrecioEnDolares.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioEnDolares.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrecioEnDolares.Location = new System.Drawing.Point(8, 12);
            this.lblPrecioEnDolares.Name = "lblPrecioEnDolares";
            this.lblPrecioEnDolares.Size = new System.Drawing.Size(130, 19);
            this.lblPrecioEnDolares.TabIndex = 1;
            this.lblPrecioEnDolares.Text = "Precio en dólares:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(150, 11);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(235, 25);
            this.txtPrecio.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.lblGanancia);
            this.panel3.Controls.Add(this.txtPorcentajeDeGanancia);
            this.panel3.Location = new System.Drawing.Point(465, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 47);
            this.panel3.TabIndex = 37;
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanancia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGanancia.Location = new System.Drawing.Point(8, 12);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(96, 19);
            this.lblGanancia.TabIndex = 1;
            this.lblGanancia.Text = "Ganancia(%):";
            // 
            // txtPorcentajeDeGanancia
            // 
            this.txtPorcentajeDeGanancia.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentajeDeGanancia.Location = new System.Drawing.Point(150, 11);
            this.txtPorcentajeDeGanancia.Name = "txtPorcentajeDeGanancia";
            this.txtPorcentajeDeGanancia.Size = new System.Drawing.Size(235, 25);
            this.txtPorcentajeDeGanancia.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.panel9.Controls.Add(this.lblId);
            this.panel9.Controls.Add(this.txtId);
            this.panel9.Location = new System.Drawing.Point(30, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(240, 47);
            this.panel9.TabIndex = 40;
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
            this.txtId.Location = new System.Drawing.Point(80, 11);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(150, 25);
            this.txtId.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.panel6.Controls.Add(this.lblCantidad);
            this.panel6.Controls.Add(this.txtCantidad);
            this.panel6.Location = new System.Drawing.Point(30, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(405, 47);
            this.panel6.TabIndex = 41;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCantidad.Location = new System.Drawing.Point(8, 12);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 19);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(150, 11);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(235, 25);
            this.txtCantidad.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.panel7.Controls.Add(this.lblEnVenta);
            this.panel7.Controls.Add(this.txtEnVenta);
            this.panel7.Location = new System.Drawing.Point(465, 240);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(405, 47);
            this.panel7.TabIndex = 42;
            // 
            // lblEnVenta
            // 
            this.lblEnVenta.AutoSize = true;
            this.lblEnVenta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEnVenta.Location = new System.Drawing.Point(8, 12);
            this.lblEnVenta.Name = "lblEnVenta";
            this.lblEnVenta.Size = new System.Drawing.Size(69, 19);
            this.lblEnVenta.TabIndex = 1;
            this.lblEnVenta.Text = "En venta:";
            // 
            // txtEnVenta
            // 
            this.txtEnVenta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnVenta.Location = new System.Drawing.Point(150, 11);
            this.txtEnVenta.Name = "txtEnVenta";
            this.txtEnVenta.ReadOnly = true;
            this.txtEnVenta.Size = new System.Drawing.Size(235, 25);
            this.txtEnVenta.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel8.Controls.Add(this.btnHistorialVenta);
            this.panel8.Controls.Add(this.btnHistorialCompra);
            this.panel8.Controls.Add(this.btnAltaBaja);
            this.panel8.Controls.Add(this.btnModificar);
            this.panel8.Location = new System.Drawing.Point(30, 403);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(840, 64);
            this.panel8.TabIndex = 26;
            // 
            // btnHistorialVenta
            // 
            this.btnHistorialVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnHistorialVenta.FlatAppearance.BorderSize = 0;
            this.btnHistorialVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHistorialVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnHistorialVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialVenta.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistorialVenta.Location = new System.Drawing.Point(600, 7);
            this.btnHistorialVenta.Name = "btnHistorialVenta";
            this.btnHistorialVenta.Size = new System.Drawing.Size(232, 50);
            this.btnHistorialVenta.TabIndex = 27;
            this.btnHistorialVenta.Text = "Historial de Venta";
            this.btnHistorialVenta.UseVisualStyleBackColor = false;
            this.btnHistorialVenta.Click += new System.EventHandler(this.btnHistorialVenta_Click);
            // 
            // btnHistorialCompra
            // 
            this.btnHistorialCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnHistorialCompra.FlatAppearance.BorderSize = 0;
            this.btnHistorialCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHistorialCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnHistorialCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialCompra.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialCompra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistorialCompra.Location = new System.Drawing.Point(361, 7);
            this.btnHistorialCompra.Name = "btnHistorialCompra";
            this.btnHistorialCompra.Size = new System.Drawing.Size(232, 50);
            this.btnHistorialCompra.TabIndex = 26;
            this.btnHistorialCompra.Text = "Historial de Compra";
            this.btnHistorialCompra.UseVisualStyleBackColor = false;
            this.btnHistorialCompra.Click += new System.EventHandler(this.btnHistorialCompra_Click);
            // 
            // btnAltaBaja
            // 
            this.btnAltaBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnAltaBaja.FlatAppearance.BorderSize = 0;
            this.btnAltaBaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAltaBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnAltaBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaBaja.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaBaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAltaBaja.Location = new System.Drawing.Point(184, 7);
            this.btnAltaBaja.Name = "btnAltaBaja";
            this.btnAltaBaja.Size = new System.Drawing.Size(170, 50);
            this.btnAltaBaja.TabIndex = 25;
            this.btnAltaBaja.Text = "Alta/Baja";
            this.btnAltaBaja.UseVisualStyleBackColor = false;
            this.btnAltaBaja.Click += new System.EventHandler(this.btnAltaBaja_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificar.Location = new System.Drawing.Point(7, 7);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(170, 50);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.panel10.Controls.Add(this.txtComentarios);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Location = new System.Drawing.Point(30, 293);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(840, 104);
            this.panel10.TabIndex = 43;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtComentarios.Location = new System.Drawing.Point(130, 12);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(690, 79);
            this.txtComentarios.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comentarios:";
            // 
            // Form_DatosProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(898, 478);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DatosProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Producto";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox picShock;
        private System.Windows.Forms.Label lblShock;
        private System.Windows.Forms.Button btnTamano;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.ComboBox comboIVA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrecioEnDolares;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.TextBox txtPorcentajeDeGanancia;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblEnVenta;
        private System.Windows.Forms.TextBox txtEnVenta;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnHistorialVenta;
        private System.Windows.Forms.Button btnHistorialCompra;
        private System.Windows.Forms.Button btnAltaBaja;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label1;
    }
}