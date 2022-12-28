using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prexCEMISAM.Clases
{
    class Entradas
    {
        string hora;
        int noExpediente;
        int idSal;
        int fkResponsable;
        int fkFecha;

        public Entradas(string _hora, int _idSal,int _noExpediente, int _fkResponsable, int _fkFecha)
        {
            hora = _hora;
            idSal = _idSal;
            noExpediente = _noExpediente;
            fkResponsable = _fkResponsable;
            fkFecha = _fkFecha;        
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public int IdSal
        {
            get { return idSal; }
            set { idSal = value; }
        }

        public int NoExpediente
        {
            get { return noExpediente; }
            set { noExpediente = value; }
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
