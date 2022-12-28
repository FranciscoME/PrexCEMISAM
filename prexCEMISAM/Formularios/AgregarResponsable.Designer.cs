namespace prexCEMISAM.Formularios
{
    partial class AgregarResponsable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarResponsable));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomRes = new System.Windows.Forms.TextBox();
            this.btnguardarResp = new System.Windows.Forms.Button();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del responsable";
            // 
            // txtnomRes
            // 
            this.txtnomRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomRes.Location = new System.Drawing.Point(84, 94);
            this.txtnomRes.Name = "txtnomRes";
            this.txtnomRes.Size = new System.Drawing.Size(193, 22);
            this.txtnomRes.TabIndex = 1;
            // 
            // btnguardarResp
            // 
            this.btnguardarResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnguardarResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardarResp.Location = new System.Drawing.Point(56, 233);
            this.btnguardarResp.Name = "btnguardarResp";
            this.btnguardarResp.Size = new System.Drawing.Size(91, 50);
            this.btnguardarResp.TabIndex = 2;
            this.btnguardarResp.Text = "Guardar";
            this.btnguardarResp.UseVisualStyleBackColor = false;
            this.btnguardarResp.Click += new System.EventHandler(this.btnguardarResp_Click);
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(84, 178);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(193, 24);
            this.cbDepartamento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departamento al que pertenece";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(206, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 50);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AgregarResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 310);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDepartamento);
            this.Controls.Add(this.btnguardarResp);
            this.Controls.Add(this.txtnomRes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarResponsable";
            this.Text = "AGREGAR RESPONSABLE";
            this.Load += new System.EventHandler(this.AgregarResponsable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomRes;
        private System.Windows.Forms.Button btnguardarResp;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
    }
}