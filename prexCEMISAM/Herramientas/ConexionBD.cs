using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

using System.Windows.Forms;
using System.Data;

namespace prexCEMISAM.Herramientas
{
    class ConexionBD
    {
        static public OleDbConnection conexionbd;

         

        public static void iniciarConexion()
        {
            try
            {

                string StrConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\expedientes.accdb";
                conexionbd = new OleDbConnection(StrConexion);
                using (OleDbConnection sqlconnection = new OleDbConnection(StrConexion)) ;

                conexionbd.Open();



                //MessageBox.Show("Conexion Exitosa")
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
            

        }

        public static void cerrarConexion()
        {
            conexionbd.Close();
        }
    }
}
