using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prexCEMISAM.Clases
{
    class Salidas
    {
        string hora;
        int noExpediente;
        int fkResponsable;
        int fkFecha;

        public Salidas(string _hora, int _noExpediente, int _fkResponsable, int _fkFecha)
        {
            hora = _hora;
            noExpediente = _noExpediente;
            fkResponsable = _fkResponsable;
            fkFecha = _fkFecha;
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public int NoExpdiente
        {
            get { return noExpediente; }
            set { noExpediente = value;}
        }

        public int FkResponsable
        {
            get { return fkResponsable; }
            set { fkResponsable = value; }
        }

        public int FkFecha
        {
            get { return fkFecha; }
            set { fkFecha = value; }
        }
    }
}
