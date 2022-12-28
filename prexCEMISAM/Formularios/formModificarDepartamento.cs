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
    public partial class formModificarDepartamento : Form
    {
        OleDbDataAdapter adaptador;
        DataSet ds;

        public formModificarDepartamento()
        {
            InitializeComponent();
        }

        private void formModificarDepartamento_Load(object sender, EventArgs e)
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
                //MessageBox.Show("No se han podido obtener los departamentos");
            }

            finally
            {
                ConexionBD.cerrarConexion();
            }


        }

        private void btnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            int idDep = int.Parse(cbDepartamento.SelectedValue.ToString());
            string nomNuevoDep = txtNuevoDepartamento.Text.ToUpper();
            actualizarDepartamento(idDep,nomNuevoDep);
        }

        private void actualizarDepartamento(int _idDep, string _nomNuevoDep)
        {
            PrincipalForm pForm = new PrincipalForm();
            try
            {
                ConexionBD.iniciarConexion();
                //string insertar = "UPDATE departamento  SET (nombreDepartamento) values ('" + _nomNuevoDep + "') WHERE ID =" + _idDep + "";
                string actualizar = "UPDATE departamento SET nombreDepartamento ='" + _nomNuevoDep + "' WHERE Id =" + _idDep + " ";

                OleDbCommand cmd = new OleDbCommand(actualizar, ConexionBD.conexionbd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado correctamente\nReinicia la aplicacion para reflejar los cambios ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                //txtNombreDepartamento.Text = "";

                pForm.obtenerDepartamentosInicio();
                pForm.cbDepartamento.ResetText();
                this.Close();
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("No se ha podido actualizar el departamento:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
