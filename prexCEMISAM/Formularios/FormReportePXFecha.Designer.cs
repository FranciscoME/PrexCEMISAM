namespace prexCEMISAM.Formularios
{
    partial class FormReportePXFecha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportePXFecha));
            this.mcFecha = new System.Windows.Forms.MonthCalendar();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.btnReportePFecha = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mcFecha
            // 
            this.mcFecha.Location = new System.Drawing.Point(77, 30);
            this.mcFecha.Name = "mcFecha";
            this.mcFecha.TabIndex = 0;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DataSource = this.departamentoBindingSource;
            this.cbDepartamento.DisplayMember = "NombreDepartamento";
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(125, 211);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(129, 21);
            this.cbDepartamento.TabIndex = 1;
            this.cbDepartamento.ValueMember = "Id";
            this.cbDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cbDepartamento_SelectionChangeCommitted);
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataSource = typeof(prexCEMISAM.Clases.Departamento);
            // 
            // cbResponsable
            // 
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(125, 255);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(218, 21);
            this.cbResponsable.TabIndex = 2;
            // 
            // btnReportePFecha
            // 
            this.btnReportePFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReportePFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePFecha.Location = new System.Drawing.Point(77, 296);
            this.btnReportePFecha.Name = "btnReportePFecha";
            this.btnReportePFecha.Size = new System.Drawing.Size(98, 56);
            this.btnReportePFecha.TabIndex = 3;
            this.btnReportePFecha.Text = "Generar reportes";
            this.btnReportePFecha.UseVisualStyleBackColor = false;
            this.btnReportePFecha.Click += new System.EventHandler(this.btnReportePFecha_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(223, 296);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 56);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Responsable:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calendario";
            // 
            // FormReportePXFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReportePFecha);
            this.Controls.Add(this.cbResponsable);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.mcFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReportePXFecha";
            this.Text = "REPORTE POR PERSONA";
            this.Load += new System.EventHandler(this.FormReportePXFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcFecha;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.Button btnReportePFecha;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}