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
    public partial class VistaFormEXFecha : Form
    {
        public List<EXFecha> listEXFecha = new List<EXFecha>();

        public VistaFormEXFecha()
        {
            InitializeComponent();
        }

        private void VistaFormEXFecha_Load(object sender, EventArgs e)
        {

            this.rvEXFecha.RefreshReport();
            rvEXFecha.LocalReport.DataSources.Clear();
            rvEXFecha.LocalReport.DataSources.Add(new ReportDataSource("dsEXFecha", listEXFecha));
            this.rvEXFecha.RefreshReport();
        }
    }
}
