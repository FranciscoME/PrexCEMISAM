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
    public partial class formEliminarResponsable : Form
    {
        OleDbDataAdapter adaptador;
        OleDbCommand comando;
        public formEliminarResponsable()
        {
            InitializeComponent();
        }

        private void formEliminarResponsable_Load(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //if (MessageBox.Show("Esta usted seguro que desea cancelar el recibo del paciente con el ID?\n" + dataGridView2[0, renglon].Value.ToString(), "EliminarRegistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    consulta = "UPDATE recibos SET cancelado = 'SI' WHERE Id=" + ncuenta + "";
            //    conbd.iniciarConexion();
            //    OleDbCommand cmd = new OleDbCommand(consulta, conbd.conexion);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("El recibo con el ID " + ncuenta + " ha sido cancelado");
            //    //dataGridView2.Rows.RemoveAt(renglon);
            //}
            if (cbResponsable.Text != "")
            {

            if (MessageBox.Show("Esta usted seguro que desea eliminar el responsable: \n" + cbResponsable.Text, "EliminarRegistro", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                int idResp = int.Parse(cbResponsable.SelectedValue.ToString());

                
                    try
                    {
                        string conElimResp = "DELETE FROM responsable WHERE Id = " + idResp + "";
                        ConexionBD.iniciarConexion();
                        comando = new OleDbCommand(conElimResp, ConexionBD.conexionbd);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Responsable eliminado correctamente\n Reinicia la aplicacion para reflejar los cambios.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show(":\n" + ex.Message, "Error al eliminar el departamento", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                    finally
                    {
                        ConexionBD.cerrarConexion();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Por favor selecciona el responsable a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void cbDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idDepartamento = obtenerDepartamentos();
            //MessageBox.Show(idDepartamento.ToString());
            obtenerResponsablesPorDepartamento(idDepartamento);
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
                MessageBox.Show(":\n" + ex.Message, "Error al obtener los responsables por departamento", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            finally
            {
                ConexionBD.cerrarConexion();
                cbResponsable.ResetText();
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
