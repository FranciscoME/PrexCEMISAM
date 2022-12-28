using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prexCEMISAM.Clases
{
    public class EXFecha
    {
        string fecha;
        string horaE;
        string noExpE;
        string responsableE;


        public EXFecha(string _fecha, string _horaE, string _noExpE, string _responsableE)
        {
            fecha = _fecha;
            horaE = _horaE;
            noExpE = _noExpE;
            responsableE = _responsableE;            
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string HoraE
        {
            get { return horaE; }
            set { horaE = value; }
        }

        public string NoExpE
        {
            get { return noExpE; }
            set { noExpE = value; }
        }

        public string ResponsableE
        {
            get { return responsableE; }
            set { responsableE = value; }
        }
    }
}
