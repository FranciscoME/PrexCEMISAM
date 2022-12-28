namespace prexCEMISAM.Formularios
{
    partial class VistaFormEXFecha
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaFormEXFecha));
            this.EXFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvEXFecha = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EXFechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EXFechaBindingSource
            // 
            this.EXFechaBindingSource.DataSource = typeof(prexCEMISAM.Clases.EXFecha);
            // 
            // rvEXFecha
            // 
            this.rvEXFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsEXFecha";
            reportDataSource1.Value = this.EXFechaBindingSource;
            this.rvEXFecha.LocalReport.DataSources.Add(reportDataSource1);
            this.rvEXFecha.LocalReport.ReportEmbeddedResource = "prexCEMISAM.Reportes.ReportEXFecha.rdlc";
            this.rvEXFecha.Location = new System.Drawing.Point(0, 0);
            this.rvEXFecha.Name = "rvEXFecha";
            this.rvEXFecha.Size = new System.Drawing.Size(618, 468);
            this.rvEXFecha.TabIndex = 0;
            // 
            // VistaFormEXFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 468);
            this.Controls.Add(this.rvEXFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaFormEXFecha";
            this.Text = "ENTRADAS DE EXPEDIENTES";
            this.Load += new System.EventHandler(this.VistaFormEXFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EXFechaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvEXFecha;
        private System.Windows.Forms.BindingSource EXFechaBindingSource;
    }
}