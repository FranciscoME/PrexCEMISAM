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
using System.Data.OleDb;

namespace prexCEMISAM.Formularios
{
    public partial class FormReportePXFecha : Form
    {
        OleDbDataAdapter adaptador;
        OleDbCommand comando;
        DataSet ds;

        public FormReportePXFecha()
        {
            InitializeComponent();
        }

        private void FormReportePXFecha_Load(object sender, EventArgs e)
        {
            obtenerDepartamentosInicio();
        }


        private void obtenerDepartamentosInicio()
        {

            try
            {
                ConexionBD.iniciarConexion();
                ds = new DataSet();
                string consulta = "Select * from departamento";
                adaptador = new OleDbDataAdapter(consulta, ConexionBD.conexionbd);
                adaptador.Fill(ds);
                adaptador.Dispose();

                cbDepartamento.DataSource = ds.Tables[0];
                cbDepartamento.ValueMember = "Id";
                cbDepartamento.DisplayMember = "nombreDepartamento";
                cbDepartamento.SelectedIndex = -1;
                Departamento dep = new Departamento(int.Parse(cbDepartamento.SelectedValue.ToString()), cbDepartamento.DisplayMember.ToString());
            }

            catch
            {
                //MessageBox.Show("Ha ocurrido un problema con la conexion a la base de datos, no se han podido fijar los Departamentos en el texbox");
            }

            finally
            {
                ConexionBD.cerrarConexion();
            }


        }

        private void cbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idDepartamento = obtenerDepartamentos();
            //MessageBox.Show(idDepartamento.ToString());
            obtenerResponsablesPorDepartamento(idDepartamento);
        }

        private void obtenerResponsablesPorDepartamento(int idDepartamento)
        {
            try
            {
                //int ex = 3;
                ConexionBD.iniciarConexion();
                DataSet ds = new DataSet();
                string consulta = "Select * from responsable where fkDepartamento=" + idDepartamento + "";

                adaptador = new OleDbDataAdapter(consulta, ConexionBD.conexionbd);


                adaptador.Fill(ds);
                //adaptador.Dispose();
                //ConexionBD.cerrarConexion();

                cbResponsable.DataSource = ds.Tables[0];
                cbResponsable.ValueMember = "Id";
                cbResponsable.DisplayMember = "nombreResponsable";
                //cbResponsable.SelectedIndex = -1;

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error (Responsables por departamento)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            finally
            {
                ConexionBD.cerrarConexion();
                cbResponsable.ResetText();
            }

        }

        private int obtenerDepartamentos()
        {
            int idDepartamento;
            return idDepartamento = int.Parse(cbDepartamento.SelectedValue.ToString());
        }



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnReportePFecha_Click(object sender, EventArgs e)
        {
            consultaSalidas();
            consultaEntradas();
        }

        private void consultaSalidas()
        {
            int idFecha = obtenerIdFecha();
            string fechaSelec = mcFecha.SelectionEnd.ToString("MM/dd/yyyy");
            VistaFormSXFecha fVFomSXFecha = new VistaFormSXFecha();

            try
            {
                int fkResponsable = int.Parse(cbResponsable.SelectedValue.ToString());

                try
                {
                    ConexionBD.iniciarConexion();
                    string consultaTablas = "SELECT hora,noExpediente,fkResponsable FROM salidas WHERE fkFecha = " + idFecha + " AND fkResponsable =" + fkResponsable + " AND cancelado =false";

                    comando = new OleDbCommand(consultaTablas, ConexionBD.conexionbd);
                    //comando.ExecuteNonQuery();
                    //MessageBox.Show("Consulta exitosa");

                    OleDbDataReader dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                        string horaS = dr.GetDateTime(0).ToString("hh:mm:ss tt");
                        string noExpS = dr.GetInt32(1).ToString();
                        int fkResp = dr.GetInt32(2);
                        int idResponsable = int.Parse(cbResponsable.SelectedValue.ToString());
                        string nomResp = obtenerNombreResponsable(idResponsable);
                        //bool entregado = dr.GetBoolean(3);
                        SXFecha objSXFecha = new SXFecha(fechaSelec, horaS, noExpS, nomResp);
                        fVFomSXFecha.listSXFecha.Add(objSXFecha);

                    }

                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show("No se ha podigo ingresar a las tablas " + ex);
                }

                finally
                {
                    ConexionBD.cerrarConexion();
                }
                fVFomSXFecha.Show();
                fVFomSXFecha.Location = new Point(50, 50);
            }
            catch
            {
                MessageBox.Show("Usted no ha seleccionado ningun responsable para generar el reporte");
            }
            
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

        private void consultaEntradas()
        {
            int idFecha = obtenerIdFecha();
            string fechaSelec = mcFecha.SelectionEnd.ToString("MM/dd/yyyy");
            VistaFormEXFecha fVFomEXFecha = new VistaFormEXFecha();

            try
            {
                int fkResponsable = int.Parse(cbResponsable.SelectedValue.ToString());



                try
                {
                    ConexionBD.iniciarConexion();
                    string consultaTablas = "SELECT hora,noExpediente,fkResponsable FROM entradas WHERE fkFecha = " + idFecha + "AND fkResponsable =" + fkResponsable + "";

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
                    MessageBox.Show("No se han podido consultar las entradas\n" + ex);
                }

                finally
                {
                    ConexionBD.cerrarConexion();
                }
                fVFomEXFecha.Show();
                fVFomEXFecha.Location = new Point(700, 50);
            }
            catch
            { 
            
            }
        }

        private int obtenerIdFecha()
        {
            int id = 0;
            //fecha dia de hoy
            //string fechaHoy = DateTime.Now.ToString("MM/dd/yyyy");
            //string fechaHoy = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string fechaSelec = mcFecha.SelectionEnd.ToString("MM/dd/yyyy");

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
    }
}
