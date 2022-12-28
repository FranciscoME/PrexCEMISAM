namespace prexCEMISAM.Formularios
{
    partial class ModificarSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarSalidas));
            this.txtNoExpediente = new System.Windows.Forms.TextBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNoExpediente
            // 
            this.txtNoExpediente.Enabled = false;
            this.txtNoExpediente.Location = new System.Drawing.Point(212, 74);
            this.txtNoExpediente.Name = "txtNoExpediente";
            this.txtNoExpediente.Size = new System.Drawing.Size(90, 20);
            this.txtNoExpediente.TabIndex = 0;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(212, 115);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(151, 21);
            this.cbDepartamento.TabIndex = 1;
            this.cbDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbDepartamento_SelectedIndexChanged);
            this.cbDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cbDepartamento_SelectionChangeCommitted);
            // 
            // cbResponsable
            // 
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(212, 159);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(210, 21);
            this.cbResponsable.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(87, 233);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 55);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(293, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 55);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Por favor selecciona el departamento y nuevo responsable de este expediente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numero de Expediente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Responsable:";
            // 
            // ModificarSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 328);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cbResponsable);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.txtNoExpediente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarSalidas";
            this.Text = "MODIFICAR SALIDAS DE EXPEDIENTES";
            this.Load += new System.EventHandler(this.ModificarSalidas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtNoExpediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}