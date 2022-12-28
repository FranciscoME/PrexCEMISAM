using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prexCEMISAM.Herramientas;
using System.Data.OleDb;

namespace prexCEMISAM.Formularios
{
    public partial class formModificarResponsable : Form
    {
        OleDbDataAdapter adaptador;
        OleDbCommand comando;

        public formModificarResponsable()
        {
            InitializeComponent();
        }

        private void formModificarResponsable_Load(object sender, EventArgs e)
        {
            obtenerDepartamentosInicio();
        }



        private void obtenerDepartamentosInicio()
        {
            try
            {
                ConexionBD.iniciarConexion();
                DataSet ds = new DataSet();
                string consulDep = "Select * from departamento";
                adaptador = new OleDbDataAdapter(consulDep, ConexionBD.conexionbd);
                adaptador.Fill(ds);
                adaptador.Dispose();
                ConexionBD.cerrarConexion();

                cbDepartamento.DataSource = ds.Tables[0];
                cbDepartamento.ValueMember = "Id";
                cbDepartamento.DisplayMember = "nombreDepartamento";
                cbDepartamento.SelectedIndex = -1;
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("No se han podido cargar los departamentos");
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }

        private void cbResponsable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private int obtenerDepartamentos()
        {
            int idDepartamento;
            return idDepartamento = int.Parse(cbDepartamento.SelectedValue.ToString());
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
                MessageBox.Show("No se han podido obtener los responsables por departamento:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
            //MessageBox.Show(idDepartamento.ToString());
            obtenerResponsablesPorDepartamento(idDepartamento);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNuevoResponsable.Text.ToUpper();
                int idResp = int.Parse(cbResponsable.SelectedValue.ToString());

                if (nombre != "")
                {

                    try
                    {
                        string consActResp = "UPDATE responsable SET nombreResponsable='" + nombre + "' WHERE Id =" + idResp + "";
                        ConexionBD.iniciarConexion();
                        comando = new OleDbCommand(consActResp, ConexionBD.conexionbd);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Actualizacion exitosa \nReinicie la aplicacion para reflejar los cambios","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                        this.Hide();
                    }
                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show("No se ha podido actualizar el nuevo responsable:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                    finally
                    {
                        ConexionBD.cerrarConexion();
                        cbResponsable.ResetText();
                    }
                }
                else 
                {
                    MessageBox.Show("Por favor introduce el nuevo nombre del responsable");
                }
            }
            catch
            {
                MessageBox.Show("Favor de Ingresar todos los campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
