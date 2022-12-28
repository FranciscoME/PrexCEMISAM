namespace prexCEMISAM.Formularios
{
    partial class AgregarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarDepartamento));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.btnNuevoDepartamento = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce el nombre del nuevo departamento";
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDepartamento.Location = new System.Drawing.Point(102, 107);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(195, 26);
            this.txtNombreDepartamento.TabIndex = 1;
            // 
            // btnNuevoDepartamento
            // 
            this.btnNuevoDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNuevoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDepartamento.Location = new System.Drawing.Point(82, 178);
            this.btnNuevoDepartamento.Name = "btnNuevoDepartamento";
            this.btnNuevoDepartamento.Size = new System.Drawing.Size(101, 44);
            this.btnNuevoDepartamento.TabIndex = 2;
            this.btnNuevoDepartamento.Text = "Guardar";
            this.btnNuevoDepartamento.UseVisualStyleBackColor = false;
            this.btnNuevoDepartamento.ClientSizeChanged += new System.EventHandler(this.btnNuevoDepartamento_ClientSizeChanged);
            this.btnNuevoDepartamento.Click += new System.EventHandler(this.btnNuevoDepartamento_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(219, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 44);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 290);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevoDepartamento);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarDepartamento";
            this.Text = "AGREGAR DEPARTAMENTO";
            this.Load += new System.EventHandler(this.AgregarDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Button btnNuevoDepartamento;
        private System.Windows.Forms.Button btnCancelar;
    }
}