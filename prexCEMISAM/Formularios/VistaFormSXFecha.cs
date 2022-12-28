using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prexCEMISAM.Clases;
using Microsoft.Reporting.WinForms;

namespace prexCEMISAM.Formularios
{
    public partial class VistaFormSXFecha : Form
    {
        public List<SXFecha> listSXFecha = new List<SXFecha>();
        

        public VistaFormSXFecha()
        {
            InitializeComponent();
        }

        private void VistaFormSXFecha_Load(object sender, EventArgs e)
        {
            this.rvSXFecha.RefreshReport();
            rvSXFecha.LocalReport.DataSources.Clear();
            rvSXFecha.LocalReport.DataSources.Add(new ReportDataSource("dsSXF",listSXFecha));
            
            this.rvSXFecha.RefreshReport();
        }
    }
}
