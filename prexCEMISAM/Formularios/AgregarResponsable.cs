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
    public partial class AgregarResponsable : Form
    {
        OleDbDataAdapter adaptador;
        OleDbCommand comando;
        

        public AgregarResponsable()
        {
            InitializeComponent();
        }

        private void AgregarResponsable_Load(object sender, EventArgs e)
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
                MessageBox.Show("No se ha podido cargar los departamentos");
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }

            

            //MessageBox.Show(cbDepartamento.SelectedValue.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnguardarResp_Click(object sender, EventArgs e)
        {
            string nuevoResp = txtnomRes.Text.ToUpper();
            if (nuevoResp != "")
            {
                try
                {
                    ConexionBD.iniciarConexion();
                    int idDepartamento = int.Parse(cbDepartamento.SelectedValue.ToString());
                    string consulta = "insert into responsable(nombreResponsable,fkDepartamento) values ('" + nuevoResp + "'," + idDepartamento + ")";
                    comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Responsable registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch
                {
                    MessageBox.Show("No se ha podido ingresar el responsable\nPor favor verifica los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
                finally
                {
                    ConexionBD.cerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("Por favor verifica los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            
        }
    }
}
