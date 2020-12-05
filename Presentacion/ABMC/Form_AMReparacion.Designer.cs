namespace ShockSoft.Presentacion
{
    partial class Form_AgregarReparacion
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
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.cbEntregado = new System.Windows.Forms.CheckBox();
            this.lblFechaReparacion = new System.Windows.Forms.Label();
            this.dtpFechaReparacion = new System.Windows.Forms.DateTimePicker();
            this.cbReparado = new System.Windows.Forms.CheckBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSolucion = new System.Windows.Forms.TextBox();
            this.gbEquipo = new System.Windows.Forms.GroupBox();
            this.cbIncluyeCables = new System.Windows.Forms.CheckBox();
            this.cbIncluyeCargador = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.cbCobrado = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCostoTrabajo = new System.Windows.Forms.TextBox();
            this.lblCostoTrabajo = new System.Windows.Forms.Label();
            this.comboMetodoDePago = new System.Windows.Forms.ComboBox();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.txtTotalInsumos = new System.Windows.Forms.TextBox();
            this.lblTotalInsumos = new System.Windows.Forms.Label();
            this.dgLineasDeReparacion = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboRubro = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblRubro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNuevaReparacion = new System.Windows.Forms.Label();
            this.lblIdReparacion = new System.Windows.Forms.Label();
            this.txtIdReparacion = new System.Windows.Forms.TextBox();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).BeginInit();
            this.gbLista.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbEquipo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineasDeReparacion)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panelControl.Size = new System.Drawing.Size(1135, 45);
            this.panelControl.TabIndex = 30;
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
            this.btnMinimizar.Location = new System.Drawing.Point(1000, 0);
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
            this.btnTamano.Location = new System.Drawing.Point(1045, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(1090, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 45);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbLista
            // 
            this.gbLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.gbLista.Controls.Add(this.dtpFechaEntrega);
            this.gbLista.Controls.Add(this.lblFechaEntrega);
            this.gbLista.Controls.Add(this.cbEntregado);
            this.gbLista.Controls.Add(this.lblFechaReparacion);
            this.gbLista.Controls.Add(this.dtpFechaReparacion);
            this.gbLista.Controls.Add(this.cbReparado);
            this.gbLista.Controls.Add(this.dtpFechaIngreso);
            this.gbLista.Controls.Add(this.lblFechaIngreso);
            this.gbLista.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbLista.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbLista.Location = new System.Drawing.Point(566, 52);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(545, 164);
            this.gbLista.TabIndex = 34;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Fechas";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Enabled = false;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(175, 115);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 25);
            this.dtpFechaEntrega.TabIndex = 36;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(14, 115);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(128, 19);
            this.lblFechaEntrega.TabIndex = 35;
            this.lblFechaEntrega.Text = "Fecha de entrega:";
            // 
            // cbEntregado
            // 
            this.cbEntregado.AutoSize = true;
            this.cbEntregado.Location = new System.Drawing.Point(395, 117);
            this.cbEntregado.Name = "cbEntregado";
            this.cbEntregado.Size = new System.Drawing.Size(148, 23);
            this.cbEntregado.TabIndex = 34;
            this.cbEntregado.Text = "Equipo entregado";
            this.cbEntregado.UseVisualStyleBackColor = true;
            this.cbEntregado.CheckedChanged += new System.EventHandler(this.CbEntregado_CheckedChanged);
            // 
            // lblFechaReparacion
            // 
            this.lblFechaReparacion.AutoSize = true;
            this.lblFechaReparacion.Location = new System.Drawing.Point(14, 73);
            this.lblFechaReparacion.Name = "lblFechaReparacion";
            this.lblFechaReparacion.Size = new System.Drawing.Size(149, 19);
            this.lblFechaReparacion.TabIndex = 14;
            this.lblFechaReparacion.Text = "Fecha de reparación:";
            // 
            // dtpFechaReparacion
            // 
            this.dtpFechaReparacion.Enabled = false;
            this.dtpFechaReparacion.Location = new System.Drawing.Point(175, 73);
            this.dtpFechaReparacion.Name = "dtpFechaReparacion";
            this.dtpFechaReparacion.Size = new System.Drawing.Size(200, 25);
            this.dtpFechaReparacion.TabIndex = 13;
            // 
            // cbReparado
            // 
            this.cbReparado.AutoSize = true;
            this.cbReparado.Location = new System.Drawing.Point(395, 75);
            this.cbReparado.Name = "cbReparado";
            this.cbReparado.Size = new System.Drawing.Size(141, 23);
            this.cbReparado.TabIndex = 12;
            this.cbReparado.Text = "Equipo reparado";
            this.cbReparado.UseVisualStyleBackColor = true;
            this.cbReparado.CheckedChanged += new System.EventHandler(this.CbReparado_CheckedChanged);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(175, 29);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 25);
            this.dtpFechaIngreso.TabIndex = 8;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(14, 32);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(126, 19);
            this.lblFechaIngreso.TabIndex = 7;
            this.lblFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.lblIdCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 118);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(111, 19);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(213, 25);
            this.txtClave.TabIndex = 15;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(17, 22);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(88, 19);
            this.lblClave.TabIndex = 14;
            this.lblClave.Text = "Contraseña:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(54)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Location = new System.Drawing.Point(339, 30);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(191, 28);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(178, 75);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(352, 25);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(129, 30);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(210, 25);
            this.txtIdCliente.TabIndex = 7;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(15, 75);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(142, 19);
            this.lblNombreCliente.TabIndex = 6;
            this.lblNombreCliente.Text = "Nombre del cliente:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(15, 35);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(100, 19);
            this.lblIdCliente.TabIndex = 5;
            this.lblIdCliente.Text = "ID del cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupBox2.Controls.Add(this.txtProblema);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 149);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Problema";
            // 
            // txtProblema
            // 
            this.txtProblema.Location = new System.Drawing.Point(20, 27);
            this.txtProblema.Multiline = true;
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.Size = new System.Drawing.Size(321, 104);
            this.txtProblema.TabIndex = 44;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupBox3.Controls.Add(this.txtSolucion);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(379, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 149);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Solución";
            // 
            // txtSolucion
            // 
            this.txtSolucion.Location = new System.Drawing.Point(20, 27);
            this.txtSolucion.Multiline = true;
            this.txtSolucion.Name = "txtSolucion";
            this.txtSolucion.Size = new System.Drawing.Size(341, 104);
            this.txtSolucion.TabIndex = 44;
            // 
            // gbEquipo
            // 
            this.gbEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.gbEquipo.Controls.Add(this.lblRubro);
            this.gbEquipo.Controls.Add(this.lblMarca);
            this.gbEquipo.Controls.Add(this.txtClave);
            this.gbEquipo.Controls.Add(this.lblClave);
            this.gbEquipo.Controls.Add(this.comboRubro);
            this.gbEquipo.Controls.Add(this.comboMarca);
            this.gbEquipo.Controls.Add(this.cbIncluyeCables);
            this.gbEquipo.Controls.Add(this.cbIncluyeCargador);
            this.gbEquipo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbEquipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbEquipo.Location = new System.Drawing.Point(766, 222);
            this.gbEquipo.Name = "gbEquipo";
            this.gbEquipo.Size = new System.Drawing.Size(345, 149);
            this.gbEquipo.TabIndex = 46;
            this.gbEquipo.TabStop = false;
            this.gbEquipo.Text = "Equipo";
            // 
            // cbIncluyeCables
            // 
            this.cbIncluyeCables.AutoSize = true;
            this.cbIncluyeCables.Location = new System.Drawing.Point(204, 116);
            this.cbIncluyeCables.Name = "cbIncluyeCables";
            this.cbIncluyeCables.Size = new System.Drawing.Size(120, 23);
            this.cbIncluyeCables.TabIndex = 48;
            this.cbIncluyeCables.Text = "Incluye cables";
            this.cbIncluyeCables.UseVisualStyleBackColor = true;
            // 
            // cbIncluyeCargador
            // 
            this.cbIncluyeCargador.AutoSize = true;
            this.cbIncluyeCargador.Location = new System.Drawing.Point(21, 116);
            this.cbIncluyeCargador.Name = "cbIncluyeCargador";
            this.cbIncluyeCargador.Size = new System.Drawing.Size(140, 23);
            this.cbIncluyeCargador.TabIndex = 47;
            this.cbIncluyeCargador.Text = "Incluye cargador";
            this.cbIncluyeCargador.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.groupBox5.Controls.Add(this.btnAceptar);
            this.groupBox5.Controls.Add(this.btnAgregarProducto);
            this.groupBox5.Controls.Add(this.cbCobrado);
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.lblTotal);
            this.groupBox5.Controls.Add(this.txtCostoTrabajo);
            this.groupBox5.Controls.Add(this.lblCostoTrabajo);
            this.groupBox5.Controls.Add(this.comboMetodoDePago);
            this.groupBox5.Controls.Add(this.lblMetodoPago);
            this.groupBox5.Controls.Add(this.txtTotalInsumos);
            this.groupBox5.Controls.Add(this.lblTotalInsumos);
            this.groupBox5.Controls.Add(this.dgLineasDeReparacion);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(12, 377);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1099, 311);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Problema";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(54)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(828, 267);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(253, 27);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(54)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Location = new System.Drawing.Point(20, 266);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(795, 28);
            this.btnAgregarProducto.TabIndex = 39;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // cbCobrado
            // 
            this.cbCobrado.AutoSize = true;
            this.cbCobrado.Location = new System.Drawing.Point(828, 229);
            this.cbCobrado.Name = "cbCobrado";
            this.cbCobrado.Size = new System.Drawing.Size(87, 23);
            this.cbCobrado.TabIndex = 30;
            this.cbCobrado.Text = "Cobrado";
            this.cbCobrado.UseVisualStyleBackColor = true;
            this.cbCobrado.CheckedChanged += new System.EventHandler(this.CbCobrado_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(890, 189);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(191, 25);
            this.txtTotal.TabIndex = 38;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(824, 192);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 19);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "Total:";
            // 
            // txtCostoTrabajo
            // 
            this.txtCostoTrabajo.Location = new System.Drawing.Point(959, 68);
            this.txtCostoTrabajo.Name = "txtCostoTrabajo";
            this.txtCostoTrabajo.Size = new System.Drawing.Size(122, 25);
            this.txtCostoTrabajo.TabIndex = 36;
            this.txtCostoTrabajo.TextChanged += new System.EventHandler(this.PreciosCambiados);
            this.txtCostoTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCostoTrabajo_KeyPress);
            // 
            // lblCostoTrabajo
            // 
            this.lblCostoTrabajo.AutoSize = true;
            this.lblCostoTrabajo.Location = new System.Drawing.Point(824, 71);
            this.lblCostoTrabajo.Name = "lblCostoTrabajo";
            this.lblCostoTrabajo.Size = new System.Drawing.Size(129, 19);
            this.lblCostoTrabajo.TabIndex = 35;
            this.lblCostoTrabajo.Text = "Costo del trabajo:";
            // 
            // comboMetodoDePago
            // 
            this.comboMetodoDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMetodoDePago.FormattingEnabled = true;
            this.comboMetodoDePago.Location = new System.Drawing.Point(828, 146);
            this.comboMetodoDePago.Name = "comboMetodoDePago";
            this.comboMetodoDePago.Size = new System.Drawing.Size(253, 27);
            this.comboMetodoDePago.TabIndex = 34;
            this.comboMetodoDePago.SelectedIndexChanged += new System.EventHandler(this.PreciosCambiados);
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(824, 111);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(126, 19);
            this.lblMetodoPago.TabIndex = 33;
            this.lblMetodoPago.Text = "Método de pago:";
            // 
            // txtTotalInsumos
            // 
            this.txtTotalInsumos.Location = new System.Drawing.Point(936, 30);
            this.txtTotalInsumos.Name = "txtTotalInsumos";
            this.txtTotalInsumos.ReadOnly = true;
            this.txtTotalInsumos.Size = new System.Drawing.Size(145, 25);
            this.txtTotalInsumos.TabIndex = 32;
            this.txtTotalInsumos.TextChanged += new System.EventHandler(this.PreciosCambiados);
            // 
            // lblTotalInsumos
            // 
            this.lblTotalInsumos.AutoSize = true;
            this.lblTotalInsumos.Location = new System.Drawing.Point(824, 33);
            this.lblTotalInsumos.Name = "lblTotalInsumos";
            this.lblTotalInsumos.Size = new System.Drawing.Size(105, 19);
            this.lblTotalInsumos.TabIndex = 31;
            this.lblTotalInsumos.Text = "Total insumos:";
            // 
            // dgLineasDeReparacion
            // 
            this.dgLineasDeReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineasDeReparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Cantidad,
            this.PrecioUnitario,
            this.Subtotal});
            this.dgLineasDeReparacion.Location = new System.Drawing.Point(20, 24);
            this.dgLineasDeReparacion.Name = "dgLineasDeReparacion";
            this.dgLineasDeReparacion.Size = new System.Drawing.Size(795, 251);
            this.dgLineasDeReparacion.TabIndex = 19;
            this.dgLineasDeReparacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgLineasDeReparacion_CellDoubleClick);
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
            this.Descripcion.Width = 350;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(111, 50);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(213, 27);
            this.comboMarca.TabIndex = 47;
            // 
            // comboRubro
            // 
            this.comboRubro.FormattingEnabled = true;
            this.comboRubro.Location = new System.Drawing.Point(111, 83);
            this.comboRubro.Name = "comboRubro";
            this.comboRubro.Size = new System.Drawing.Size(213, 27);
            this.comboRubro.TabIndex = 48;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(50, 53);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 19);
            this.lblMarca.TabIndex = 49;
            this.lblMarca.Text = "Marca:";
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(51, 86);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(54, 19);
            this.lblRubro.TabIndex = 50;
            this.lblRubro.Text = "Rubro:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.txtIdReparacion);
            this.panel1.Controls.Add(this.lblIdReparacion);
            this.panel1.Controls.Add(this.lblNuevaReparacion);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 40);
            this.panel1.TabIndex = 47;
            // 
            // lblNuevaReparacion
            // 
            this.lblNuevaReparacion.AutoSize = true;
            this.lblNuevaReparacion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNuevaReparacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNuevaReparacion.Location = new System.Drawing.Point(222, 10);
            this.lblNuevaReparacion.Name = "lblNuevaReparacion";
            this.lblNuevaReparacion.Size = new System.Drawing.Size(129, 19);
            this.lblNuevaReparacion.TabIndex = 51;
            this.lblNuevaReparacion.Text = "Nueva reparación";
            // 
            // lblIdReparacion
            // 
            this.lblIdReparacion.AutoSize = true;
            this.lblIdReparacion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblIdReparacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIdReparacion.Location = new System.Drawing.Point(138, 10);
            this.lblIdReparacion.Name = "lblIdReparacion";
            this.lblIdReparacion.Size = new System.Drawing.Size(141, 19);
            this.lblIdReparacion.TabIndex = 52;
            this.lblIdReparacion.Text = "ID de la reparación:";
            // 
            // txtIdReparacion
            // 
            this.txtIdReparacion.Enabled = false;
            this.txtIdReparacion.Location = new System.Drawing.Point(285, 11);
            this.txtIdReparacion.Name = "txtIdReparacion";
            this.txtIdReparacion.ReadOnly = true;
            this.txtIdReparacion.Size = new System.Drawing.Size(115, 20);
            this.txtIdReparacion.TabIndex = 53;
            // 
            // Form_AgregarReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1135, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbEquipo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbLista);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AgregarReparacion";
            this.Text = "Form_AgregarReparacion";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShock)).EndInit();
            this.gbLista.ResumeLayout(false);
            this.gbLista.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbEquipo.ResumeLayout(false);
            this.gbEquipo.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineasDeReparacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.PictureBox picShock;
        private System.Windows.Forms.Label lblShock;
        private System.Windows.Forms.Button btnTamano;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.CheckBox cbEntregado;
        private System.Windows.Forms.Label lblFechaReparacion;
        private System.Windows.Forms.DateTimePicker dtpFechaReparacion;
        private System.Windows.Forms.CheckBox cbReparado;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProblema;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSolucion;
        private System.Windows.Forms.GroupBox gbEquipo;
        private System.Windows.Forms.CheckBox cbIncluyeCables;
        private System.Windows.Forms.CheckBox cbIncluyeCargador;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCostoTrabajo;
        private System.Windows.Forms.Label lblCostoTrabajo;
        private System.Windows.Forms.ComboBox comboMetodoDePago;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.TextBox txtTotalInsumos;
        private System.Windows.Forms.Label lblTotalInsumos;
        private System.Windows.Forms.CheckBox cbCobrado;
        private System.Windows.Forms.DataGridView dgLineasDeReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboRubro;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdReparacion;
        private System.Windows.Forms.Label lblIdReparacion;
        private System.Windows.Forms.Label lblNuevaReparacion;
    }
}