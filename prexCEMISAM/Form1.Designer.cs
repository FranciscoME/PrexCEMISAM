namespace prexCEMISAM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoResponsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarResponsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarResponsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportePorResponsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentosToolStripMenuItem,
            this.responsablesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1177, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDepartamentoToolStripMenuItem,
            this.modificarDepartamentoToolStripMenuItem});
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // nuevoDepartamentoToolStripMenuItem
            // 
            this.nuevoDepartamentoToolStripMenuItem.Name = "nuevoDepartamentoToolStripMenuItem";
            this.nuevoDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nuevoDepartamentoToolStripMenuItem.Text = "Nuevo departamento";
            this.nuevoDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.nuevoDepartamentoToolStripMenuItem_Click);
            // 
            // modificarDepartamentoToolStripMenuItem
            // 
            this.modificarDepartamentoToolStripMenuItem.Name = "modificarDepartamentoToolStripMenuItem";
            this.modificarDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.modificarDepartamentoToolStripMenuItem.Text = "Modificar departamento";
            this.modificarDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.modificarDepartamentoToolStripMenuItem_Click);
            // 
            // responsablesToolStripMenuItem
            // 
            this.responsablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoResponsableToolStripMenuItem,
            this.modificarResponsableToolStripMenuItem,
            this.eliminarResponsableToolStripMenuItem});
            this.responsablesToolStripMenuItem.Name = "responsablesToolStripMenuItem";
            this.responsablesToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.responsablesToolStripMenuItem.Text = "Responsables";
            // 
            // nuevoResponsableToolStripMenuItem
            // 
            this.nuevoResponsableToolStripMenuItem.Name = "nuevoResponsableToolStripMenuItem";
            this.nuevoResponsableToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nuevoResponsableToolStripMenuItem.Text = "Nuevo responsable";
            this.nuevoResponsableToolStripMenuItem.Click += new System.EventHandler(this.nuevoResponsableToolStripMenuItem_Click);
            // 
            // modificarResponsableToolStripMenuItem
            // 
            this.modificarResponsableToolStripMenuItem.Name = "modificarResponsableToolStripMenuItem";
            this.modificarResponsableToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.modificarResponsableToolStripMenuItem.Text = "Modificar responsable";
            this.modificarResponsableToolStripMenuItem.Click += new System.EventHandler(this.modificarResponsableToolStripMenuItem_Click);
            // 
            // eliminarResponsableToolStripMenuItem
            // 
            this.eliminarResponsableToolStripMenuItem.Name = "eliminarResponsableToolStripMenuItem";
            this.eliminarResponsableToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.eliminarResponsableToolStripMenuItem.Text = "Eliminar responsable";
            this.eliminarResponsableToolStripMenuItem.Click += new System.EventHandler(this.eliminarResponsableToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportePorFechaToolStripMenuItem,
            this.reportePorResponsableToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportePorFechaToolStripMenuItem
            // 
            this.reportePorFechaToolStripMenuItem.Name = "reportePorFechaToolStripMenuItem";
            this.reportePorFechaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.reportePorFechaToolStripMenuItem.Text = "Reporte por Fecha";
            this.reportePorFechaToolStripMenuItem.Click += new System.EventHandler(this.reportePorFechaToolStripMenuItem_Click);
            // 
            // reportePorResponsableToolStripMenuItem
            // 
            this.reportePorResponsableToolStripMenuItem.Name = "reportePorResponsableToolStripMenuItem";
            this.reportePorResponsableToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.reportePorResponsableToolStripMenuItem.Text = "Reporte por responsable";
            this.reportePorResponsableToolStripMenuItem.Click += new System.EventHandler(this.reportePorResponsableToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 565);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL DE PRESTAMOS DE EXPEDIENTES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoResponsableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarResponsableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarResponsableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportePorResponsableToolStripMenuItem;
    }
}

