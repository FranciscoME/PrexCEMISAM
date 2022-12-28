namespace prexCEMISAM.Formularios
{
    partial class formModificarResponsable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formModificarResponsable));
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.txtNuevoResponsable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(178, 88);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(160, 21);
            this.cbDepartamento.TabIndex = 0;
            this.cbDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cbDepartamento_SelectionChangeCommitted);
            // 
            // cbResponsable
            // 
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(178, 115);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(235, 21);
            this.cbResponsable.TabIndex = 1;
            this.cbResponsable.SelectionChangeCommitted += new System.EventHandler(this.cbResponsable_SelectionChangeCommitted);
            // 
            // txtNuevoResponsable
            // 
            this.txtNuevoResponsable.Location = new System.Drawing.Point(123, 192);
            this.txtNuevoResponsable.Name = "txtNuevoResponsable";
            this.txtNuevoResponsable.Size = new System.Drawing.Size(227, 20);
            this.txtNuevoResponsable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona el departamento y el responsable a modificar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(98, 249);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 48);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(269, 249);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(96, 48);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Responsable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Introduce el nuevo nombre del responsable:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // formModificarResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 343);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevoResponsable);
            this.Controls.Add(this.cbResponsable);
            this.Controls.Add(this.cbDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formModificarResponsable";
            this.Text = "MODIFICAR RESPONSABLE";
            this.Load += new System.EventHandler(this.formModificarResponsable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.TextBox txtNuevoResponsable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}