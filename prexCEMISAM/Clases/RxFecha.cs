using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prexCEMISAM.Clases
{
    class RxFecha
    {
        string fecha;
        string horaS;
        string noExpS;
        string responsableS;
        string entregadoS;
        string horaE;
        string noExpE;
        string responsableE;

        public RxFecha(string _fecha, string _horaS, string _noExpS, string _responsableS, string _entregadoS, string _horaE, string _noExpE, string _responsableE)
        {
            fecha = _fecha;
            horaS = _horaS;
            noExpS = _noExpS;
            responsableS = _responsableS;
            entregadoS = _entregadoS;
            horaE = _horaE;
            noExpE = _noExpE;
            responsableE = _responsableE;
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

        public string EntregadoS
        {
            get { return entregadoS; }
            set { entregadoS = value; }
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
