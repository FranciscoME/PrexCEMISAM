using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prexCEMISAM.Formularios;
using prexCEMISAM.Herramientas;

namespace prexCEMISAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarDepartamento formAgregarDepartamento = new AgregarDepartamento();
            formAgregarDepartamento.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConexionBD.iniciarConexion();
            PrincipalForm formPrincipal = new PrincipalForm();
            formPrincipal.MdiParent = this;
            formPrincipal.Show();


        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoResponsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            AgregarResponsable formAgregarResponsable = new AgregarResponsable();
            //formAgregarResponsable.MdiParent = this;
            formAgregarResponsable.Show();
        }

        private void reportePorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteFecha formRxFecha = new FormReporteFecha();
            formRxFecha.ShowDialog();
        }

        private void reportePorResponsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportePXFecha fRPXF = new FormReportePXFecha();
            fRPXF.Show();
        }

        private void modificarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formModificarDepartamento formModDep = new formModificarDepartamento();
            formModDep.Show();
        }

        private void modificarResponsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formModificarResponsable formModRes = new formModificarResponsable();
            formModRes.Show();
        }

        private void eliminarResponsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEliminarResponsable formEliResp = new formEliminarResponsable();
            formEliResp.Show();
        }

        
    }
}
