namespace ShockSoft.Presentacion
{
    partial class Form_MenuProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAltaProducto = new System.Windows.Forms.Button();
            this.btnConsultaProducto = new System.Windows.Forms.Button();
            this.btnABMParametro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(213)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(546, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "powered by Shock!Team";
            // 
            // btnAltaProducto
            // 
            this.btnAltaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnAltaProducto.FlatAppearance.BorderSize = 0;
            this.btnAltaProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnAltaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProducto.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAltaProducto.Location = new System.Drawing.Point(45, 35);
            this.btnAltaProducto.Name = "btnAltaProducto";
            this.btnAltaProducto.Size = new System.Drawing.Size(600, 45);
            this.btnAltaProducto.TabIndex = 5;
            this.btnAltaProducto.Text = "Nuevo Producto";
            this.btnAltaProducto.UseVisualStyleBackColor = false;
            this.btnAltaProducto.Click += new System.EventHandler(this.btnAltaProducto_Click);
            // 
            // btnConsultaProducto
            // 
            this.btnConsultaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnConsultaProducto.FlatAppearance.BorderSize = 0;
            this.btnConsultaProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnConsultaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaProducto.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultaProducto.Location = new System.Drawing.Point(45, 101);
            this.btnConsultaProducto.Name = "btnConsultaProducto";
            this.btnConsultaProducto.Size = new System.Drawing.Size(600, 45);
            this.btnConsultaProducto.TabIndex = 6;
            this.btnConsultaProducto.Text = "Lista de Productos";
            this.btnConsultaProducto.UseVisualStyleBackColor = false;
            this.btnConsultaProducto.Click += new System.EventHandler(this.btnConsultaProducto_Click);
            // 
            // btnABMParametro
            // 
            this.btnABMParametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.btnABMParametro.FlatAppearance.BorderSize = 0;
            this.btnABMParametro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(175)))), ((int)(((byte)(100)))));
            this.btnABMParametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABMParametro.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnABMParametro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnABMParametro.Location = new System.Drawing.Point(45, 165);
            this.btnABMParametro.Name = "btnABMParametro";
            this.btnABMParametro.Size = new System.Drawing.Size(600, 44);
            this.btnABMParametro.TabIndex = 7;
            this.btnABMParametro.Text = "ABM Parametros";
            this.btnABMParametro.UseVisualStyleBackColor = false;
            this.btnABMParametro.Click += new System.EventHandler(this.btnABMParametro_Click);
            // 
            // Form_MenuProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnABMParametro);
            this.Controls.Add(this.btnConsultaProducto);
            this.Controls.Add(this.btnAltaProducto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MenuProducto";
            this.Text = "Form_MenuProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAltaProducto;
        private System.Windows.Forms.Button btnConsultaProducto;
        private System.Windows.Forms.Button btnABMParametro;
    }
}