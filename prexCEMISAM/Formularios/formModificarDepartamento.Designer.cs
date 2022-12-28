namespace prexCEMISAM.Formularios
{
    partial class formModificarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formModificarDepartamento));
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.btnNuevoDepartamento = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtNuevoDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(135, 76);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(156, 21);
            this.cbDepartamento.TabIndex = 0;
            // 
            // btnNuevoDepartamento
            // 
            this.btnNuevoDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNuevoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDepartamento.Location = new System.Drawing.Point(96, 202);
            this.btnNuevoDepartamento.Name = "btnNuevoDepartamento";
            this.btnNuevoDepartamento.Size = new System.Drawing.Size(86, 44);
            this.btnNuevoDepartamento.TabIndex = 2;
            this.btnNuevoDepartamento.Text = "Actualizar";
            this.btnNuevoDepartamento.UseVisualStyleBackColor = false;
            this.btnNuevoDepartamento.Click += new System.EventHandler(this.btnNuevoDepartamento_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(216, 202);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(86, 44);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtNuevoDepartamento
            // 
            this.txtNuevoDepartamento.Location = new System.Drawing.Point(135, 148);
            this.txtNuevoDepartamento.Name = "txtNuevoDepartamento";
            this.txtNuevoDepartamento.Size = new System.Drawing.Size(156, 20);
            this.txtNuevoDepartamento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "MODIFICAR DEPARTAMENTO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selecciona el departamento a modificar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Introduce el nuevo nombre del departamento:";
            // 
            // formModificarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNuevoDepartamento);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevoDepartamento);
            this.Controls.Add(this.cbDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formModificarDepartamento";
            this.Text = "Modificar departamento";
            this.Load += new System.EventHandler(this.formModificarDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Button btnNuevoDepartamento;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtNuevoDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}