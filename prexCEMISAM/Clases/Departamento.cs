using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prexCEMISAM.Clases
{
    class Departamento
    {
        int id;
        string nombreDepartamento;

        public Departamento(int _id, string _nombreDepartamento)
        {
            id = _id;
            nombreDepartamento = _nombreDepartamento;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NombreDepartamento
        {
             get { return nombreDepartamento; }
            set { nombreDepartamento = value; }
        }
    }
}
