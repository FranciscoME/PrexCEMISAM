namespace prexCEMISAM.Formularios
{
    partial class FormReporteFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteFecha));
            this.mcxFecha = new System.Windows.Forms.MonthCalendar();
            this.btnReporteFecha = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mcxFecha
            // 
            this.mcxFecha.Location = new System.Drawing.Point(89, 41);
            this.mcxFecha.Name = "mcxFecha";
            this.mcxFecha.TabIndex = 0;
            // 
            // btnReporteFecha
            // 
            this.btnReporteFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReporteFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteFecha.Location = new System.Drawing.Point(91, 228);
            this.btnReporteFecha.Name = "btnReporteFecha";
            this.btnReporteFecha.Size = new System.Drawing.Size(101, 57);
            this.btnReporteFecha.TabIndex = 1;
            this.btnReporteFecha.Text = "Generar reportes";
            this.btnReporteFecha.UseVisualStyleBackColor = false;
            this.btnReporteFecha.Click += new System.EventHandler(this.btnReporteFecha_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(243, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 57);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calendario";
            // 
            // FormReporteFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReporteFecha);
            this.Controls.Add(this.mcxFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporteFecha";
            this.Text = "REPORTE POR FECHA";
            this.Load += new System.EventHandler(this.FormReporteFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcxFecha;
        private System.Windows.Forms.Button btnReporteFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}