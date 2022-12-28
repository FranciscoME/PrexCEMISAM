using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prexCEMISAM.Formularios;
using System.Windows.Forms;

namespace prexCEMISAM.Herramientas
{
    public class Utileria
    {
        PrincipalForm pf = new PrincipalForm();

        public void limpiarSalidas()
        {
            pf.lvSalidas.Clear();
            pf.lvSalidas.View = View.Details;
            pf.lvSalidas.GridLines = true;
            pf.lvSalidas.FullRowSelect = true;
            //lvSalidas.HideSelection = true;
            pf.lvSalidas.Columns.Add("Id", 50);
            pf.lvSalidas.Columns.Add("No.Expediente", 100);
            pf.lvSalidas.Columns.Add("Responsable", 200);
        }
    }
}
