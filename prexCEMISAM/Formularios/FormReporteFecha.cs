using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prexCEMISAM.Herramientas;
using prexCEMISAM.Clases;
using prexCEMISAM.Formularios;
using System.Data.OleDb;


namespace prexCEMISAM.Formularios
{
    public partial class FormReporteFecha : Form
    {
        OleDbCommand comando;

        //string fechaSelec;

        public FormReporteFecha()
        {
            InitializeComponent();
        }

        private void FormReporteFecha_Load(object sender, EventArgs e)
        {

        }

        private void consultaSalidas()
        {
            int idFecha = obtenerIdFecha();
            string fechaSelec = mcxFecha.SelectionEnd.ToString("MM/dd/yyyy");
            VistaFormSXFecha fVFomSXFecha = new VistaFormSXFecha();

            try
            {
                ConexionBD.iniciarConexion();
                string consultaTablas = "SELECT hora,noExpediente,fkResponsable FROM salidas WHERE fkFecha = " + idFecha + "and cancelado=false";

                comando = new OleDbCommand(consultaTablas, ConexionBD.conexionbd);
                //comando.ExecuteNonQuery();
                //MessageBox.Show("Consulta exitosa");

                OleDbDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    string horaS = dr.GetDateTime(0).ToString("hh:mm:ss tt");
                    string noExpS = dr.GetInt32(1).ToString();
                    int fkResp = dr.GetInt32(2);
                    string nomResp = obtenerNombreResponsable(fkResp);
                    //bool entregado = dr.GetBoolean(3);
                    SXFecha objSXFecha= new SXFecha(fechaSelec, horaS, noExpS, nomResp);                    
                    fVFomSXFecha.listSXFecha.Add(objSXFecha);                    

                }
                
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("No se han podido obtener las salidas " + ex,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }

            finally
            {
                ConexionBD.cerrarConexion();
            }
            fVFomSXFecha.Show();
            fVFomSXFecha.Location = new Point(50, 50);
        }

        private void consultaEntradas()
        {
            int idFecha = obtenerIdFecha();
            string fechaSelec = mcxFecha.SelectionEnd.ToString("MM/dd/yyyy");
            VistaFormEXFecha fVFomEXFecha = new VistaFormEXFecha();

            try
            {
                ConexionBD.iniciarConexion();
                string consultaTablas = "SELECT hora,noExpediente,fkResponsable FROM entradas WHERE fkFecha = " + idFecha + "";

                comando = new OleDbCommand(consultaTablas, ConexionBD.conexionbd);
                //comando.ExecuteNonQuery();
                //MessageBox.Show("Consulta exitosa");

                OleDbDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    string horaS = dr.GetDateTime(0).ToString("hh:mm:ss tt");
                    string noExpS = dr.GetInt32(1).ToString();
                    int fkResp = dr.GetInt32(2);
                    string nomResp = obtenerNombreResponsable(fkResp);
                    //bool entregado = dr.GetBoolean(3);
                    EXFecha objEXFecha = new EXFecha(fechaSelec, horaS, noExpS, nomResp);
                    fVFomEXFecha.listEXFecha.Add(objEXFecha);

                }

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("No se han podido obtener las entradas " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            finally
            {
                ConexionBD.cerrarConexion();
            }
            fVFomEXFecha.Show();
            fVFomEXFecha.Location = new Point(700, 50);
        }

        private void consultaTablas()
        {
            int idFecha = obtenerIdFecha();
            try
            {
                ConexionBD.iniciarConexion();
                string consultaTablas = "SELECT hora,noExpediente,fkResponsable,entregado FROM salidas WHERE fkFecha = " + idFecha + " UNION ALL SELECT hora,noExpediente,fkResponsable,cancelado FROM entradas WHERE fkFecha = " + idFecha + "";
                
                comando = new OleDbCommand(consultaTablas, ConexionBD.conexionbd);
                //comando.ExecuteNonQuery();
                //MessageBox.Show("Consulta exitosa");

                OleDbDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    string horaS = dr.GetDateTime(0).ToString("hh:mm:ss tt");
                    string noExpS = dr.GetInt32(1).ToString();
                    int fkResp = dr.GetInt32(2);
                    string nomResp = obtenerNombreResponsable(fkResp);
                    bool entregado = dr.GetBoolean(3);

                    MessageBox.Show("Hora: "+horaS+
                                    "\nNoExp: "+noExpS+
                                     "\nNombreResp: "+nomResp+
                                     "\nEntregado:"+entregado);
                }

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("No se ha podigo consultar a las tablas " + ex);
            }

            finally
            {
                ConexionBD.cerrarConexion();
            }

        }



        private int obtenerIdFecha()
        {
            int id = 0;
            //fecha dia de hoy
            //string fechaHoy = DateTime.Now.ToString("MM/dd/yyyy");
            
            
            //string fechaHoy = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string fechaSelec = mcxFecha.SelectionEnd.ToString("MM/dd/yyyy");

            try
            {
                ConexionBD.iniciarConexion();
                string consulta = "select id from fecha where fecha=#" + fechaSelec + "#";
                comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                id = int.Parse(comando.ExecuteScalar().ToString());
                //MessageBox.Show("IdFecha: {0}",id.ToString());
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error (Obtener id fecha)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("Error en la consulta (obtener id fecha metodo (obtenerIdFecha))");
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }

            return id;
        }

        private string obtenerNombreResponsable(int _idResponsable)
        {
            string nombreResponsable = "";
            try
            {
                ConexionBD.iniciarConexion();
                string consulta = "Select nombreResponsable from responsable where id =" + _idResponsable + "";
                comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                nombreResponsable = comando.ExecuteScalar().ToString();

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("No se ha podido obtener el nombre del responsable:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            //catch
            //{
            //    MessageBox.Show("Error en la consulta (obtener  ID nombre responsable)");

            //}
            finally
            {
                ConexionBD.cerrarConexion();
            }
            return nombreResponsable;
        }

        private void btnReporteFecha_Click(object sender, EventArgs e)
        {
            //consultaTablas();
            consultaSalidas();
            consultaEntradas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
