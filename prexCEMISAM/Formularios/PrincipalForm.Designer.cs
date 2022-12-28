namespace prexCEMISAM.Formularios
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.lvSalidas = new System.Windows.Forms.ListView();
            this.cmsSalidas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mODIFICARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cANCELARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.txtNoExpediente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.lvEntradas = new System.Windows.Forms.ListView();
            this.cmsEntradas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rESTAURARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.lblNoExp = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.cmsSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.cmsEntradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.dgvSalidas);
            this.groupBox1.Controls.Add(this.lvSalidas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salidas";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AllowDrop = true;
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.AllowUserToDeleteRows = false;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Location = new System.Drawing.Point(338, 440);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.ReadOnly = true;
            this.dgvSalidas.Size = new System.Drawing.Size(12, 16);
            this.dgvSalidas.TabIndex = 1;
            this.dgvSalidas.Visible = false;
            // 
            // lvSalidas
            // 
            this.lvSalidas.AllowColumnReorder = true;
            this.lvSalidas.ContextMenuStrip = this.cmsSalidas;
            this.lvSalidas.FullRowSelect = true;
            this.lvSalidas.Location = new System.Drawing.Point(6, 15);
            this.lvSalidas.Name = "lvSalidas";
            this.lvSalidas.Size = new System.Drawing.Size(344, 428);
            this.lvSalidas.TabIndex = 0;
            this.lvSalidas.UseCompatibleStateImageBehavior = false;
            this.lvSalidas.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvSalidas_ItemDrag);
            this.lvSalidas.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvSalidas_DragDrop);
            this.lvSalidas.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvSalidas_DragEnter);
            // 
            // cmsSalidas
            // 
            this.cmsSalidas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mODIFICARToolStripMenuItem,
            this.cANCELARToolStripMenuItem});
            this.cmsSalidas.Name = "contextMenuStrip1";
            this.cmsSalidas.Size = new System.Drawing.Size(138, 48);
            // 
            // mODIFICARToolStripMenuItem
            // 
            this.mODIFICARToolStripMenuItem.Name = "mODIFICARToolStripMenuItem";
            this.mODIFICARToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.mODIFICARToolStripMenuItem.Text = "MODIFICAR";
            this.mODIFICARToolStripMenuItem.Click += new System.EventHandler(this.mODIFICARToolStripMenuItem_Click);
            // 
            // cANCELARToolStripMenuItem
            // 
            this.cANCELARToolStripMenuItem.Name = "cANCELARToolStripMenuItem";
            this.cANCELARToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.cANCELARToolStripMenuItem.Text = "CANCELAR";
            this.cANCELARToolStripMenuItem.Click += new System.EventHandler(this.cANCELARToolStripMenuItem_Click);
            // 
            // btnSalidas
            // 
            this.btnSalidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalidas.ForeColor = System.Drawing.Color.Black;
            this.btnSalidas.Location = new System.Drawing.Point(490, 215);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(139, 58);
            this.btnSalidas.TabIndex = 1;
            this.btnSalidas.Text = "Salida";
            this.btnSalidas.UseVisualStyleBackColor = false;
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click);
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoExpediente.Location = new System.Drawing.Point(503, 104);
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(92, 26);
            this.txtNoExpediente.TabIndex = 2;
            this.txtNoExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoExpediente_KeyPress);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(524, 381);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(63, 20);
            this.txtFecha.TabIndex = 3;
            this.txtFecha.Visible = false;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DataSource = this.departamentoBindingSource;
            this.cbDepartamento.DisplayMember = "NombreDepartamento";
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(503, 146);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(140, 21);
            this.cbDepartamento.TabIndex = 5;
            this.cbDepartamento.ValueMember = "Id";
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            this.cbDepartamento.SelectedValueChanged += new System.EventHandler(this.cbDepartamento_SelectedValueChanged);
            this.cbDepartamento.Click += new System.EventHandler(this.cbDepartamento_Click);
            this.cbDepartamento.MouseEnter += new System.EventHandler(this.cbDepartamento_MouseEnter);
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataSource = typeof(prexCEMISAM.Clases.Departamento);
            // 
            // cbResponsable
            // 
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(503, 173);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(258, 21);
            this.cbResponsable.TabIndex = 6;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(456, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.dgvEntradas);
            this.groupBox2.Controls.Add(this.lvEntradas);
            this.groupBox2.Location = new System.Drawing.Point(777, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 469);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entradas";
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Location = new System.Drawing.Point(6, 461);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.Size = new System.Drawing.Size(10, 14);
            this.dgvEntradas.TabIndex = 1;
            this.dgvEntradas.Visible = false;
            // 
            // lvEntradas
            // 
            this.lvEntradas.AllowColumnReorder = true;
            this.lvEntradas.AllowDrop = true;
            this.lvEntradas.ContextMenuStrip = this.cmsEntradas;
            this.lvEntradas.Location = new System.Drawing.Point(7, 19);
            this.lvEntradas.Name = "lvEntradas";
            this.lvEntradas.Size = new System.Drawing.Size(346, 441);
            this.lvEntradas.TabIndex = 0;
            this.lvEntradas.UseCompatibleStateImageBehavior = false;
            this.lvEntradas.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvEntradas_ItemDrag);
            this.lvEntradas.SelectedIndexChanged += new System.EventHandler(this.lvEntradas_SelectedIndexChanged);
            this.lvEntradas.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvEntradas_DragDrop);
            this.lvEntradas.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvEntradas_DragEnter);
            this.lvEntradas.MouseEnter += new System.EventHandler(this.lvEntradas_MouseEnter);
            this.lvEntradas.MouseHover += new System.EventHandler(this.lvEntradas_MouseHover);
            // 
            // cmsEntradas
            // 
            this.cmsEntradas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rESTAURARToolStripMenuItem});
            this.cmsEntradas.Name = "cmsEntradas";
            this.cmsEntradas.Size = new System.Drawing.Size(139, 26);
            // 
            // rESTAURARToolStripMenuItem
            // 
            this.rESTAURARToolStripMenuItem.Name = "rESTAURARToolStripMenuItem";
            this.rESTAURARToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.rESTAURARToolStripMenuItem.Text = "RESTAURAR";
            this.rESTAURARToolStripMenuItem.Click += new System.EventHandler(this.rESTAURARToolStripMenuItem_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.Black;
            this.btnActualizar.Location = new System.Drawing.Point(490, 295);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 58);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar listas";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(211, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(71, 20);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(293, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(509, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(15, 7);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(190, 16);
            this.lblBuscar.TabIndex = 14;
            this.lblBuscar.Text = "Buscar número de expediente:";
            // 
            // btnCalendario
            // 
            this.btnCalendario.ForeColor = System.Drawing.Color.Black;
            this.btnCalendario.Location = new System.Drawing.Point(419, 4);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(75, 23);
            this.btnCalendario.TabIndex = 15;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Visible = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // lblNoExp
            // 
            this.lblNoExp.AutoSize = true;
            this.lblNoExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoExp.ForeColor = System.Drawing.Color.Black;
            this.lblNoExp.Location = new System.Drawing.Point(374, 110);
            this.lblNoExp.Name = "lblNoExp";
            this.lblNoExp.Size = new System.Drawing.Size(121, 16);
            this.lblNoExp.TabIndex = 16;
            this.lblNoExp.Text = "No. de expediente:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.Black;
            this.lblDepartamento.Location = new System.Drawing.Point(399, 146);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 16);
            this.lblDepartamento.TabIndex = 17;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsable.ForeColor = System.Drawing.Color.Black;
            this.lblResponsable.Location = new System.Drawing.Point(401, 178);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(93, 16);
            this.lblResponsable.TabIndex = 18;
            this.lblResponsable.Text = "Responsable:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(377, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "F.M.E. v1";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.Location = new System.Drawing.Point(524, 427);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // PrincipalForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1148, 558);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblNoExp);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cbResponsable);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.txtNoExpediente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnSalidas);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrincipalForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL DE PRESTAMOS DE EXPEDIENTES";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.Click += new System.EventHandler(this.PrincipalForm_Click);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            this.cmsSalidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.cmsEntradas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.TextBox txtNoExpediente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvEntradas;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.ContextMenuStrip cmsSalidas;
        private System.Windows.Forms.ToolStripMenuItem mODIFICARToolStripMenuItem;
        public System.Windows.Forms.ListView lvSalidas;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStripMenuItem cANCELARToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ContextMenuStrip cmsEntradas;
        private System.Windows.Forms.ToolStripMenuItem rESTAURARToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Label lblNoExp;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblResponsable;
        public System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}