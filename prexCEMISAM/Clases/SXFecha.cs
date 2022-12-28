using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prexCEMISAM.Clases
{
   public class SXFecha
    {
        string fecha;
        string horaS;
        string noExpS;
        string responsableS;


        public SXFecha(string _fecha, string _horaS, string _noExpS, string _responsableS)
        {
            fecha = _fecha;
            horaS = _horaS;
            noExpS = _noExpS;
            responsableS = _responsableS;            
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string HoraS
        {
            get { return horaS; }
            set { horaS = value; }
        }

        public string NoExpS
        {
            get { return noExpS; }
            set { noExpS = value; }
        }

        public string ResponsableS
        {
            get { return responsableS; }
            set { responsableS = value; }
        }
              
    }
}
