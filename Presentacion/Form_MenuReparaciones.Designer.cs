namespace ShockSoft.Presentacion
{
    partial class Form_MenuReparaciones
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
            this.btnConsultaReparacion = new System.Windows.Forms.Button();
            this.btnAltaReparacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(546, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "powered by Shock!Team";
            // 
            // btnConsultaReparacion
            // 
            this.btnConsultaReparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.btnConsultaReparacion.FlatAppearance.BorderSize = 0;
            this.btnConsultaReparacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(54)))));
            this.btnConsultaReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaReparacion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaReparacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultaReparacion.Location = new System.Drawing.Point(45, 101);
            this.btnConsultaReparacion.Name = "btnConsultaReparacion";
            this.btnConsultaReparacion.Size = new System.Drawing.Size(600, 45);
            this.btnConsultaReparacion.TabIndex = 8;
            this.btnConsultaReparacion.Text = "Lista de Reparaciones";
            this.btnConsultaReparacion.UseVisualStyleBackColor = false;
            // 
            // btnAltaReparacion
            // 
            this.btnAltaReparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(40)))));
            this.btnAltaReparacion.FlatAppearance.BorderSize = 0;
            this.btnAltaReparacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(54)))));
            this.btnAltaReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaReparacion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaReparacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAltaReparacion.Location = new System.Drawing.Point(45, 35);
            this.btnAltaReparacion.Name = "btnAltaReparacion";
            this.btnAltaReparacion.Size = new System.Drawing.Size(600, 45);
            this.btnAltaReparacion.TabIndex = 7;
            this.btnAltaReparacion.Text = "Nueva Reparacion";
            this.btnAltaReparacion.UseVisualStyleBackColor = false;
            // 
            // Form_MenuReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnConsultaReparacion);
            this.Controls.Add(this.btnAltaReparacion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_MenuReparaciones";
            this.Text = "Form_MenuReparaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaReparacion;
        private System.Windows.Forms.Button btnAltaReparacion;
    }
}