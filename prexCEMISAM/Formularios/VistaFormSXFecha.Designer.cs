namespace prexCEMISAM.Formularios
{
    partial class VistaFormSXFecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaFormSXFecha));
            this.SXFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvSXFecha = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EXFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SXFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXFechaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SXFechaBindingSource
            // 
            this.SXFechaBindingSource.DataSource = typeof(prexCEMISAM.Clases.SXFecha);
            // 
            // rvSXFecha
            // 
            this.rvSXFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsSXF";
            reportDataSource1.Value = this.SXFechaBindingSource;
            this.rvSXFecha.LocalReport.DataSources.Add(reportDataSource1);
            this.rvSXFecha.LocalReport.ReportEmbeddedResource = "prexCEMISAM.Reportes.ReportSXFecha.rdlc";
            this.rvSXFecha.Location = new System.Drawing.Point(0, 0);
            this.rvSXFecha.Name = "rvSXFecha";
            this.rvSXFecha.Size = new System.Drawing.Size(630, 471);
            this.rvSXFecha.TabIndex = 0;
            // 
            // EXFechaBindingSource
            // 
            this.EXFechaBindingSource.DataSource = typeof(prexCEMISAM.Clases.EXFecha);
            // 
            // VistaFormSXFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 471);
            this.Controls.Add(this.rvSXFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaFormSXFecha";
            this.Text = "SALIDAS DE EXPEDIENTES";
            this.Load += new System.EventHandler(this.VistaFormSXFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SXFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EXFechaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvSXFecha;
        private System.Windows.Forms.BindingSource SXFechaBindingSource;
        private System.Windows.Forms.BindingSource EXFechaBindingSource;
    }
}