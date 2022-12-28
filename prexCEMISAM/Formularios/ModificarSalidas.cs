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
    
    public partial class ModificarSalidas : Form
    {
        OleDbDataAdapter adaptador;
        OleDbCommand comando;
        DataSet ds;

        public int _idSalida;
        public int _noExpediente;

        PrincipalForm formPrincipal = new PrincipalForm();

        

        public ModificarSalidas()
        {
            InitializeComponent();
        }

        private void ModificarSalidas_Load(object sender, EventArgs e)
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

        private int obtenerDepartamentos()
        {
            int idDepartamento;
            return idDepartamento = int.Parse(cbDepartamento.SelectedValue.ToString());

        }        

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int idDepartamento = obtenerDepartamentos();
            //MessageBox.Show(idDepartamento.ToString());
            //obtenerResponsablesPorDepartamento(idDepartamento);
           
            //MessageBox.Show(comboBox1.SelectedValue.ToString());
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
                adaptador.Dispose();
                ConexionBD.cerrarConexion();

                cbResponsable.DataSource = ds.Tables[0];
                cbResponsable.ValueMember = "Id";
                cbResponsable.DisplayMember = "nombreResponsable";
                //cbResponsable.SelectedIndex = -1;

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error (Responsables por departamento)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {

            }
            finally
            {
                ConexionBD.cerrarConexion();
                cbResponsable.ResetText();
            }

        }

        private void cbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idDepartamento = obtenerDepartamentos();
            obtenerResponsablesPorDepartamento(idDepartamento);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Realizamos la actualizacion
            actualizar(_idSalida);

            //Actualizamos entradas y salidas
            //actualizarDatosLv();

            //formPrincipal.lvSalidas.Clear();
            MessageBox.Show("Por favor ahora solo actualiza las listas","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            actualizarDatosLv();
        }

        public void actualizar(int idSalida)
        {
            if (txtNoExpediente.Text == "" || cbDepartamento.Text == "" || cbResponsable.Text == "")
            {
                MessageBox.Show("Por favor ingresa todos los datos");
            }
            else
            {
                try
                {
                    int noExp = int.Parse(txtNoExpediente.Text);
                    int fkResponsable = int.Parse(cbResponsable.SelectedValue.ToString());

                    try
                    {
                        ConexionBD.iniciarConexion();
                        string consulta = "UPDATE salidas SET noExpediente =" + noExp + ",fkResponsable = " + fkResponsable + " WHERE ID =" + idSalida + " ";
                        comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                        comando.ExecuteNonQuery();
                        //MessageBox.Show("Registro actualizado correctamente");
                        //actualizarDatosLv();
                        
                        //formPrincipal.actualizarDatosLv();
                        //formPrincipal.lvSalidas.Clear();
                        this.Close();
                        //formPrincipal.btnEntradas_Click(null, null);
                        
                        

                    }
                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show("No se han podido actualizar las salidas:\n" + ex.Message, "Error (No se han podido actualziar los datos )", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                    finally
                    {
                        ConexionBD.cerrarConexion();
                        //cbResponsable.ResetText();
                       
                    }

                }
                catch
                {
                    MessageBox.Show("Los datos no se han podido ingresar");
                    txtNoExpediente.Focus();
                }

            }            
        }


        public void actualizarDatosLv()
        {
            formPrincipal.lvSalidas.Clear();


            formPrincipal.lvSalidas.View = View.Details;
            formPrincipal.lvSalidas.GridLines = true;
            formPrincipal.lvSalidas.FullRowSelect = true;
            //lvSalidas.HideSelection = true;
            formPrincipal.lvSalidas.Columns.Add("Id", 50);
            formPrincipal.lvSalidas.Columns.Add("No.Expediente", 100);
            formPrincipal.lvSalidas.Columns.Add("Responsable", 200);

            //Pantilla lvEntradas
     


            //tiempoActualizar();

            //obtenerNoExpNombreSalidas();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formPrincipal.actualizarDatosLv();
            this.Hide();
        }




    }
}
