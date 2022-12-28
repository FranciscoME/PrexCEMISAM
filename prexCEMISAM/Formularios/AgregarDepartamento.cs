using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

using prexCEMISAM.Herramientas;


namespace prexCEMISAM.Formularios
{
    public partial class AgregarDepartamento : Form
    {
        OleDbCommand cmd;     
           

        public AgregarDepartamento()
        {
            InitializeComponent();
        }

        private void btnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            string nDepartamento = txtNombreDepartamento.Text.ToUpper();
            if (nDepartamento != "")
            {
                try
                {
                    ConexionBD.iniciarConexion();
                    string insertar = "insert into departamento (nombreDepartamento) values ('" + nDepartamento + "')";
                    OleDbCommand cmd = new OleDbCommand(insertar, ConexionBD.conexionbd);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado correctamente ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    txtNombreDepartamento.Text = "";
                    this.Close();
                }
                catch (DBConcurrencyException ex)
                {
                    MessageBox.Show("Error de Comunicacion:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
            else
            {
                MessageBox.Show("Por favor verifica que los campos esten completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void agregarNuevoDepartamento()
        {

           
        }

        private void btnNuevoDepartamento_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarDepartamento_Load(object sender, EventArgs e)
        {

        }
    }
}

