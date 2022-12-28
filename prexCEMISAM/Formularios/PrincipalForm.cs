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
using prexCEMISAM.Clases;
using System.Collections;
using System.Text.RegularExpressions;

namespace prexCEMISAM.Formularios
{
    public partial class PrincipalForm : Form
    {
        OleDbDataAdapter adaptador;
        OleDbCommand comando;
        DataSet ds;
        int idSalida;

        ListViewItem listaSalidas = new ListViewItem();
        
        //string fecha = DateTime.Now.ToString("dd/MM/yyyy");

        private BindingSource bindingsource1 = new BindingSource();       
        DataTable tabla;

        //ListViewItem listaExpSal;
        
        //DateTime hora2 = DateTime.Parse(hora1);

        //DateTime hora = DateTime.;

        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtNoExpediente.Text == "" || cbDepartamento.Text == "" || cbResponsable.Text == "")
                {
                    MessageBox.Show("Verifique que todos los campos esten llenos");
                    txtNoExpediente.Focus();
                    actualizarDatosLv();
                }
                else
                {

                    int idFecha = obtenerIdFecha();
                    string hora = DateTime.Now.ToString("hh:mm:ss tt");
                    //MessageBox.Show(hora.ToString());
                    int noExpediente = int.Parse(txtNoExpediente.Text);
                    bool existeRegistro =buscaRepetidoSalida(noExpediente);
                    int idResponsable = int.Parse(cbResponsable.SelectedValue.ToString());
                    //MessageBox.Show("El responsable seleccionado es "+responsable.ToString()+"");


                    Salidas salida = new Salidas(hora, noExpediente, int.Parse(cbResponsable.SelectedValue.ToString()), idFecha);

                    //MessageBox.Show(idFecha.ToString());

                    if (existeRegistro == true)
                    {
                        MessageBox.Show("Este Registro ya se encuentra en salidas");
                        //limpiarSalidas();
                    }
                    else 
                    { 
                         try
                        {
                            ConexionBD.iniciarConexion();
                            string consulta = "insert into salidas (hora,noExpediente,fkResponsable,fkFecha) values ('" + salida.Hora + "'," + salida.NoExpdiente + "," + salida.FkResponsable + "," + salida.FkFecha + ")";
                            comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                            comando.ExecuteNonQuery();

                            //MessageBox.Show("Registro insertado correctmente");
                            //agregaraListView(noExpediente, responsable);

                            
                        }
                        catch (DBConcurrencyException ex)
                        {
                            MessageBox.Show("No se han podigo ingresar las salidas\n" + ex);
                        }

                        finally
                        {
                            ConexionBD.cerrarConexion();
                        }
                        //agrega el ultimo elemento ingresado
                        agregaraSalidas();
                    }


                   
                }
            }

            catch
            {
                MessageBox.Show("Por favor verifique los datos ingresados ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
            
        }

        private bool buscaRepetidoSalida(int _noExpediente)
        {
             int idFecha=obtenerIdFecha();
             
             bool existe = false;

            try
            {
                ConexionBD.iniciarConexion();
                string consultaRepetido = "SELECT noExpediente from salidas where noExpediente = " + _noExpediente + " and fkFecha = " + idFecha + " AND entregado=false AND cancelado=false";
                comando = new OleDbCommand(consultaRepetido,ConexionBD.conexionbd);
                //comando.ExecuteNonQuery();

                OleDbDataReader dr = comando.ExecuteReader();


                if (dr.Read())
                {
                    
                    existe = true;

                }
                else
                {
                    
                    existe = false;
                }
                                
            }
            catch(OleDbException ex)
            {
                MessageBox.Show("Error al consultar salidas repetidas:\n"+ex);
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
            return existe;

        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            //
            this.WindowState = FormWindowState.Maximized;
            dateTimePicker1.Enabled = false;
            
            //Plantilla lvSalidas
            lvSalidas.View = View.Details;
            lvSalidas.GridLines = true;
            lvSalidas.FullRowSelect = true;
            //lvSalidas.HideSelection = true;
            lvSalidas.Columns.Add("Id", 50);
            lvSalidas.Columns.Add("No.Expediente");
            lvSalidas.Columns.Add("Responsable", 200);
           
            
            //Pantilla lvEntradas
            lvEntradas.View = View.Details;
            lvEntradas.GridLines = true;
            lvEntradas.FullRowSelect = false;
            lvEntradas.Columns.Add("Id", 50);
            lvEntradas.Columns.Add("No. de expediente", 100);
            lvEntradas.Columns.Add("Responsable", 200);

                    
            //Cargar los departamentos del comboBox de departamentos
            obtenerDepartamentosInicio();
            fijarFecha();
            //Fijar en la base de datos la fecha de hoy
            //obtenerDatos();

            //tiempoActualizar();
            //obtenerNoExpNombreSalidas();
            actualizarDatosLv();
        }

        private void fijarFecha()
        {
            try
            {
                ConexionBD.iniciarConexion();
                string fechahoy = DateTime.Now.ToString("MM/dd/yyyy");

                string consulta = "insert into fecha (fecha) values(#" + fechahoy + "#)";
                comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                comando.ExecuteNonQuery();
                //MessageBox.Show("La fecha se ha generado con exito");

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                //No genera nada por que la fecha ha sido creada previamente
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        
        }

        private void obtenerResponsablesPorDepartamento(int idDepartamento)
        {
            try
            {
                //int ex = 3;
                ConexionBD.iniciarConexion();
                DataSet ds= new DataSet();
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
                MessageBox.Show(":\n" + ex.Message, "Error (Obtener responsables por departamento)", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void cbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idDepartamento = obtenerDepartamentos();
            //MessageBox.Show(idDepartamento.ToString());
            obtenerResponsablesPorDepartamento(idDepartamento);
        }

        private void cbDepartamento_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void PrincipalForm_Click(object sender, EventArgs e)
        {
            

        }

        private void cbDepartamento_Click(object sender, EventArgs e)
        {
            
        }

        public void obtenerDepartamentosInicio()
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

        private int obtenerIdFecha()
        {
            int id=0;
            //fecha dia de hoy
            //string fechaHoy = DateTime.Now.ToString("MM/dd/yyyy");
            string fechaHoy = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            
            try
            {
                ConexionBD.iniciarConexion();
                string consulta = "select id from fecha where fecha=#" + fechaHoy + "#";
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


        public void agregaraListView(int _noexp,string _nomResp, int _idFecha)
        {
            //string nombreResponsable = obtenerNombreResponsable(idResponsable);
                        
            //string[] sal = new string[2];
            //string noExp = _noexp.ToString();
            //ListViewItem listaSalidas;

            //sal[0] = noExp;
            //sal[1] = _nomResp;
            
            //listaSalidas = new ListViewItem(sal);

            //lvSalidas.Items.Add(listaSalidas);
        }

        //public void obtenerDatos()
        //{
            //try
            //{
            //    ConexionBD.iniciarConexion();

            //    string consulta = "Select noExpediente,fKResponsable from salidas where fkFecha =0 ";

            //    comando = new OleDbCommand(consulta, ConexionBD.conexionbd);

            //    OleDbDataReader reader = comando.ExecuteReader();

            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            int sal1 = reader.GetInt32(0);
            //            int sal2 = reader.GetInt32(1);

            //            MessageBox.Show("No Exp:" + sal1.ToString() + "fkResponsable" + sal2.ToString() + "");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Registros no encontrados");
            //    }
            //    reader.Close();
            //}
            //catch (DBConcurrencyException ex)
            //{
            //    MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}
            //catch
            //{
            //    MessageBox.Show("Error al obtener los datos por fecha");
            //}
            //finally
            //{
            //    ConexionBD.cerrarConexion();
            //}
                      

        //}

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
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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

        private void obtenerNoExpNombreSalidas()
        {
            
            //ListViewItem listaSalidas = new ListViewItem();
            //listaSalidas.SubItems.Clear();
            int noEx=0;
            int idSalida = 0;
            int idResponsable;
            string nombreResponsable="";
            DataSet dsSalida = new DataSet();
            int idFecha=obtenerIdFecha();

            try
            {
                //Variable sqlCommand
                OleDbCommand comando = new OleDbCommand();
                
                //ConexionBD.iniciarConexion();
                
                mostrarSalidasdgv();

                dgvSalidas.DataSource = bindingsource1;

                dgvSalidas.Refresh();

                int numRenglones = dgvSalidas.RowCount ;
                string[] sal = new string[3];

            //MessageBox.Show(numRenglones.ToString());
            //int ncuenta = Convert.ToInt32(dataGridView2[1, 2].Value.ToString());

            for (int fila = 0; fila < numRenglones; fila++)
            {
                for (int columna = 2; columna <= 2; columna++)
                {
                     idSalida = int.Parse( dgvSalidas.Rows[fila].Cells[0].Value.ToString());
                     noEx = int.Parse(dgvSalidas.Rows[fila].Cells[1].Value.ToString());
                     idResponsable =int.Parse( dgvSalidas.Rows[fila].Cells[2].Value.ToString());
                     nombreResponsable = obtenerNombreResponsable(idResponsable);
                    //MessageBox.Show("El valor de la celda es: " + idSalida);

                    
                    string noExp = noEx.ToString();

                    sal[0] = idSalida.ToString();
                    sal[1] = noExp;
                    sal[2] = nombreResponsable;

                    listaSalidas = new ListViewItem(sal);

                    lvSalidas.Items.Add(listaSalidas);
                }
            }

               


            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("ERROR (obtener nombre salidas)");
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }           

            
        }

        //Agrega a salidas por cada boton guardar
        private void agregaraSalidas()
        {

            
            //listaSalidas.SubItems.Clear();
            int noEx = 0;
            
            
           

            ConexionBD.iniciarConexion();
            string maximo = "SELECT MAX(Id) FROM salidas";
            comando = new OleDbCommand(maximo, ConexionBD.conexionbd);
            string max = comando.ExecuteScalar().ToString();
            //MessageBox.Show(max);          
           
           


            string[] sal = new string[3];

            string noExp = noEx.ToString();

            sal[0] = max;
            sal[1] = txtNoExpediente.Text;
            sal[2] = cbResponsable.Text;

            listaSalidas = new ListViewItem(sal);

            lvSalidas.Items.Add(listaSalidas);
                    
                

                //string consulta = "Select Id,noExpediente,fkResponsable,fkFecha from salidas where fkFecha=" + idFecha + "";
                //adaptador1 = new OleDbDataAdapter(consulta, ConexionBD.conexionbd);
                //adaptador1.Fill(dsSalida);

                //int r = dsSalida.Tables[0].Rows.Count;
                //r = r - 1;
                //MessageBox.Show("No de renglones:" + r.ToString());
                //for (int i = 0; i <= r; i++)
                //{
                //    if (ds != null)
                //    {
                //        idSalida = int.Parse(dsSalida.Tables[0].Rows[i][0].ToString());
                //        noEx = int.Parse(dsSalida.Tables[0].Rows[i][1].ToString());
                //        idResponsable = int.Parse(dsSalida.Tables[0].Rows[i][2].ToString());
                //        nombreResponsable = obtenerNombreResponsable(idResponsable);
                //        //MessageBox.Show("" + noEx.ToString() + "" + nombreResponsable + "");

                //        string[] sal = new string[3];
                //        string noExp = noEx.ToString();

                //        sal[0] = idSalida.ToString();
                //        sal[1] = noExp;
                //        sal[2] = nombreResponsable;

                //        listaSalidas = new ListViewItem(sal);

                //        lvSalidas.Items.Add(listaSalidas);
                //        //MessageBox.Show("El id de la salida es: "+idSalida.ToString());
                //    }
                //    else
                //    {
                //        MessageBox.Show("No existen registros actualmente");
                //    }
                //}

            ConexionBD.cerrarConexion();
            txtNoExpediente.Text = "";


        }

        private void mostrarSalidasdgv()
        {
            
            try
            {
                ConexionBD.iniciarConexion();
                //string con = "Select * From costos";
                int fechaSalida= obtenerIdFecha();
                string consulta = "Select Id,noExpediente,fkResponsable,fkFecha from salidas where fkFecha="+fechaSalida+" AND entregado=false AND cancelado=false";

                adaptador = new OleDbDataAdapter(consulta, ConexionBD.conexionbd);

                OleDbCommandBuilder comando = new OleDbCommandBuilder(adaptador);

                tabla = new DataTable();

                adaptador.Fill(tabla);

                bindingsource1.DataSource = tabla;

                dgvSalidas.DataSource = bindingsource1;
            }

            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("ERROR (mostrar salidas por fecha (mostrarSalidasdgv))");
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }            

        }


        private void mostrarEntradasdgv()
        {
            try
            {
                ConexionBD.iniciarConexion();
                //string con = "Select * From costos";
                string consulta = "Select Id,noExpediente,fkResponsable,fkFecha from entradas where fkFecha=114";

                adaptador = new OleDbDataAdapter(consulta, ConexionBD.conexionbd);

                OleDbCommandBuilder comando = new OleDbCommandBuilder(adaptador);

                tabla = new DataTable();

                adaptador.Fill(tabla);

                bindingsource1.DataSource = tabla;

                dgvEntradas.DataSource = bindingsource1;
            }

            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("Error al mostrar entradas");
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }

        }


        private void obtenerNoExpNombreEntradas()
        {
            int noEx = 0;
            int idSalida = 0;
            int idResponsable = 0;
            string nombreResponsable="";
            DataSet dsEntrada = new DataSet();

            try
            {
                int idFecha = obtenerIdFecha();
                ConexionBD.iniciarConexion();
                string consulta = "Select Id,noExpediente,fkResponsable,fkFecha from entradas where fkFecha = " + idFecha + " AND cancelado=false";
                adaptador = new OleDbDataAdapter(consulta, ConexionBD.conexionbd);
                adaptador.Fill(dsEntrada);
                int r = dsEntrada.Tables[0].Rows.Count - 1;
                int rExisten = dsEntrada.Tables[0].Rows.Count;
                string[] ent = new string[3];
                ListViewItem listaEntradas;


                if (rExisten >= 0)
                {
                    for (int i = 0; i <= r; i++)
                    {

                        idSalida = int.Parse(dsEntrada.Tables[0].Rows[i][0].ToString());
                        noEx = int.Parse(dsEntrada.Tables[0].Rows[i][1].ToString());
                        idResponsable = int.Parse(dsEntrada.Tables[0].Rows[i][2].ToString());
                        nombreResponsable = obtenerNombreResponsable(idResponsable);
                        
                        ent[0] = idSalida.ToString();
                        ent[1] = noEx.ToString();
                        ent[2] = nombreResponsable;

                        listaEntradas = new ListViewItem(ent);
                        lvEntradas.Items.Add(listaEntradas);
                        //MessageBox.Show("El id de la salida es: " + idSalida.ToString());

                    }
                }
                else
                {
                    MessageBox.Show("No existen registros  de entrada actualmente");
                }
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }             

        }

        public void btnEntradas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software elaborado por el L.I. Francisco Márquez Estrada\nPara uso exclusivo del Centro Michoacano de Salud Mental.");
            Application.Exit();

            
        }

        private void lvSalidas_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
            lvSalidas.DoDragDrop(lvSalidas.SelectedItems, DragDropEffects.Copy);
        }

        private void lvSalidas_DragDrop(object sender, DragEventArgs e)
        {
           
        }

        private void lvSalidas_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lvEntradas_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item.ToString(), DragDropEffects.Copy | DragDropEffects.Move);
            lvEntradas.DoDragDrop(lvEntradas.SelectedItems, DragDropEffects.Copy);
        }

        private void lvEntradas_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lvEntradas_DragDrop(object sender, DragEventArgs e)
        {
            string ecomleto  = e.Data.GetData(DataFormats.Text).ToString();
            //int eId = int.Parse(ecomleto.Substring(15, 2));                        
            int noExpediente = 0;
            int idSal = 0;
            int fkResponsable = 0;
            int fkFecha = 0;
            string hora = DateTime.Now.ToString("hh:mm:ss tt");
            
            int idSalida = int.Parse(Regex.Replace(ecomleto, @"[^\d]", ""));           

            //MessageBox.Show(result.ToString());

            Entradas entrada;

            try
            {
                //ConexionBD.iniciarConexion();
                string consulta = "Select Id,noExpediente,fkResponsable,fkFecha from salidas where id=" + idSalida + " AND entregado=false";
                adaptador = new OleDbDataAdapter(consulta, ConexionBD.conexionbd);
                DataSet dsEntradas = new DataSet();
                adaptador.Fill(dsEntradas);
                int r = dsEntradas.Tables[0].Rows.Count - 1;

                for (int i = 0; i <= r; i++)
                {
                    if (dsEntradas != null)
                    {
                        idSal = int.Parse(dsEntradas.Tables[0].Rows[i][0].ToString());
                        noExpediente = int.Parse(dsEntradas.Tables[0].Rows[i][1].ToString());
                        fkResponsable = int.Parse(dsEntradas.Tables[0].Rows[i][2].ToString());
                        fkFecha = int.Parse(dsEntradas.Tables[0].Rows[i][3].ToString());

                        entrada = new Entradas(hora,idSal, noExpediente, fkResponsable, fkFecha);

                        try
                        {
                            ConexionBD.iniciarConexion();
                            string consulta2 = "Insert into entradas(hora,idSal,noExpediente,fkResponsable,fkFecha) values ('" + entrada.Hora + "','" + entrada.IdSal + "','" + entrada.NoExpediente + "','" + entrada.FkResponsable + "','" + entrada.FkFecha + "')";
                            comando = new OleDbCommand(consulta2, ConexionBD.conexionbd);
                            comando.ExecuteNonQuery();
                            entregado(idSalida);
                        }

                        catch (DBConcurrencyException ex)
                        {
                            MessageBox.Show(":\n" + ex.Message, "Error al insertar la entrada", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        finally
                        {
                            ConexionBD.cerrarConexion();
                        }

                        //Agregar a la lista 


                    }
                }
                
                
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error al insertar la entrada", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            //catch
            //{
            //    MessageBox.Show("Error Al ingresar las entradas");
            //}
            finally
            {
                ConexionBD.cerrarConexion();
            }



            foreach (ListViewItem itemS in lvSalidas.SelectedItems)
            {
                lvSalidas.Items.Remove(itemS);
                lvEntradas.Items.Add(itemS);

                //agregaraEntradas(idSalida);

                //MessageBox.Show(itemS.SubItems[2].ToString());
            }
            
        }

        private void entregado(int idSalida)
        {
            try
            {
                ConexionBD.iniciarConexion();
                string consulta = "UPDATE salidas SET entregado = true WHERE Id ="+idSalida+"";
                comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                comando.ExecuteNonQuery();
                actualizarEntradas(); actualizarEntradas();
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error al marcar salida como entregado:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
           
        }

        private void restaurado(int idSalida)
        {
            try
            {
                ConexionBD.iniciarConexion();
                string consulta = "UPDATE salidas SET entregado = false WHERE Id =" + idSalida + "";
                comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                comando.ExecuteNonQuery();
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(" Error al restaurar la entrada:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }

        }

        private void lvEntradas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void actualizarDatosLv()
        {
            lvSalidas.Clear();
            lvEntradas.Clear();

            lvSalidas.View = View.Details;
            lvSalidas.GridLines = true;
            lvSalidas.FullRowSelect = true;
            //lvSalidas.HideSelection = true;
            lvSalidas.Columns.Add("Id", 50);
            lvSalidas.Columns.Add("No.Expediente", 100);
            lvSalidas.Columns.Add("Responsable", 200);

            //Pantilla lvEntradas
            lvEntradas.View = View.Details;
            lvEntradas.GridLines = true;
            lvEntradas.FullRowSelect = true;
            lvEntradas.Columns.Add("Id", 50);
            lvEntradas.Columns.Add("No. de expediente", 100);
            lvEntradas.Columns.Add("Responsable", 200);
            

            //tiempoActualizar();
            
            obtenerNoExpNombreSalidas();
            obtenerNoExpNombreEntradas();
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string cadIdSalida = lvSalidas.SelectedItems[0].ToString();
                idSalida = int.Parse(Regex.Replace(cadIdSalida, @"[^\d]", ""));
                modificarSalida(idSalida);
                btnSalidas.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha seleccionado un elemento no valido para modificar\n" +ex);
            }

            
            //Al hacer clic en modificar salidas
             

             
             //string cadNoExp = lvSalidas.sub
             //MessageBox.Show(cadNoExp.ToString());

             
           
           
             //ModificarSalidas formModificarSalidas = new ModificarSalidas();
             
             //formModificarSalidas.txtNoExpediente.Text = lvSalidas.SelectedItems[1].ToString();

             //formModificarSalidas.Show();
             
             

        }

        private void modificarSalida(int id)
        {

            //string hora = DateTime.Now.ToString("hh:mm:ss tt");           
            //MessageBox.Show(hora.ToString());
            //int noExpediente = int.Parse(txtNoExpediente.Text);
            //MessageBox.Show(id.ToString());
            //int idResponsable = int.Parse(cbResponsable.SelectedValue.ToString());
            DataSet dsSalida = new DataSet();
            
            try
            {
                ConexionBD.iniciarConexion();
                string consulta = "Select noExpediente from salidas where Id=" + id + "";
                comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(dsSalida);
                ModificarSalidas formModificarSalidas = new ModificarSalidas();

                int noExp = int.Parse(dsSalida.Tables[0].Rows[0][0].ToString());

                formModificarSalidas.txtNoExpediente.Text = noExp.ToString();
                formModificarSalidas._idSalida = id;

                formModificarSalidas.Show();


                //cbResponsable.Text = obtenerNombreResponsable(fkResp);
                //cbDepartamento.Text = "";

                //cbDepartamento.Text = obtenerDepartamentoporResponsable(fkResp);

                //MessageBox.Show("El numero de expediente es:" + sa);

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("error al mostrar las salidas:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                ConexionBD.cerrarConexion();
                
            }

        }

        

        private string obtenerDepartamentoporResponsable(int resp)
        {
            DataSet dsDepartamento = new DataSet();
            string nomDepa = "";
            try
            {
                ConexionBD.iniciarConexion();
                string consulta = "Select nombreDepartamento from departamento where Id=" + resp + "";
                comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(dsDepartamento);

                nomDepa = dsDepartamento.Tables[0].Rows[0][0].ToString();               


                //MessageBox.Show("El numero de expediente es:" + sa);

            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
            return nomDepa;
        }

        

        private void soloDigitaNumeros(KeyPressEventArgs e)
        {
            //Para obligar que solo se ingresen numeros
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                //Permitir teclas de control (retroceso)
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                { 
                    //El resto de las pulsaciones se omiten
                    e.Handled = true;
                }

        }

        private void txtNoExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDigitaNumeros(e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarDatosLv();
            btnSalidas.Enabled = true;
            groupBox1.BackColor = Color.Red;
        }

        private void cANCELARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Esta usted seguro que desea cancelar el recibo del paciente con el ID?\n" + dataGridView2[0, renglon].Value.ToString(), "EliminarRegistro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            if (MessageBox.Show("Esta usted seguro que desea cancelar esta salida?", "Cancelar salidas", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string cadIdSalida = lvSalidas.SelectedItems[0].ToString();
                    idSalida = int.Parse(Regex.Replace(cadIdSalida, @"[^\d]", ""));

                    try
                    {
                        ConexionBD.iniciarConexion();
                        string consulta = "UPDATE salidas set cancelado = true WHERE Id = " + idSalida + "";
                        comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro cancelado !!\nAhora solo actualiza las listas","Correcto",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                    }
                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show("Error al marcar como entregado la salida:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                    finally
                    {
                        ConexionBD.cerrarConexion();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha seleccionado un elemento no valido para cancelar\n" + ex);
                }
                finally
                {
                    ConexionBD.cerrarConexion();
                }
            } 
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //ListViewItem item1 = lvSalidas.FindItemWithText(txtBuscar.Text, false, 0, true);
            //string cadIdSalida = item1.ToString();
            //idSalida = int.Parse(Regex.Replace(cadIdSalida, @"[^\d]", ""));
            //string idSalida2 = Regex.Replace(cadIdSalida, @"[^\d]", "");



            //lvSalidas.FindItemWithText("2020");
            


            //SearchTextInListView(listaSalidas, idSalida2);
            //item1.Selected = true;
            //item1.EnsureVisible();
            //if (item1 != null)
            //{
                
                
            //    MessageBox.Show("Calling FindItemWithText passing 'brack': "
            //            + idSalida.ToString());
                

            //    //lvSalidas.Items[2].Focused=true;
            //    //lvSalidas.Items[2].Selected = true;
            //}
                
            //else
            //    MessageBox.Show("Calling FindItemWithText passing 'brack': null");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarExpediente();
        }

        private void buscarExpediente()
        {
            limpiarSalidas();

            int noEx = 0;
            int idSalida = 0;
            int idResponsable;
            string nombreResponsable = "";
            DataSet dsSalida = new DataSet();
            int idFecha = obtenerIdFecha();

            //Deshabilitar salidas
            btnSalidas.Enabled = false;

            try
            {
                //Variable sqlCommand
                OleDbCommand comando = new OleDbCommand();
                
                //ConexionBD.iniciarConexion();
                
                busquedaSalidasdgv();

                dgvSalidas.DataSource = bindingsource1;

                dgvSalidas.Refresh();

                int numRenglones = dgvSalidas.RowCount;
                string[] sal = new string[3];

                //MessageBox.Show(numRenglones.ToString());
                //int ncuenta = Convert.ToInt32(dataGridView2[1, 2].Value.ToString());

                for (int fila = 0; fila < numRenglones; fila++)
                {
                    for (int columna = 2; columna <= 2; columna++)
                    {
                        idSalida = int.Parse(dgvSalidas.Rows[fila].Cells[0].Value.ToString());
                        noEx = int.Parse(dgvSalidas.Rows[fila].Cells[1].Value.ToString());
                        idResponsable = int.Parse(dgvSalidas.Rows[fila].Cells[2].Value.ToString());
                        nombreResponsable = obtenerNombreResponsable(idResponsable);
                        //MessageBox.Show("El valor de la celda es: " + idSalida);


                        string noExp = noEx.ToString();

                        sal[0] = idSalida.ToString();
                        sal[1] = noExp;
                        sal[2] = nombreResponsable;

                        listaSalidas = new ListViewItem(sal);

                        lvSalidas.Items.Add(listaSalidas);
                    }
                }

                groupBox1.BackColor = Color.Yellow;
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show("Error al buscar el expediente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("No se ha encontrado ningun expediente");
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }

            //obtenerNoExpNombreSalidas();
        }

        private void busquedaSalidasdgv()
        {

            try
            {
                ConexionBD.iniciarConexion();
                //string con = "Select * From costos";
                int id = int.Parse(txtBuscar.Text.ToString());
                
                int fechaSalida = obtenerIdFecha();
                string consulta = "Select Id,noExpediente,fkResponsable,fkFecha from salidas where noExpediente="+id+" AND fkFecha = "+fechaSalida+" and entregado=false AND cancelado=false";

                adaptador = new OleDbDataAdapter(consulta, ConexionBD.conexionbd);

                OleDbCommandBuilder comando = new OleDbCommandBuilder(adaptador);

                tabla = new DataTable();

                adaptador.Fill(tabla);

                bindingsource1.DataSource = tabla;

                dgvSalidas.DataSource = bindingsource1;

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros con ese numero de expediente","Sin resultados",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                }
                    
                
            }

            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch
            {
                MessageBox.Show("ERROR (mostrar salidas por fecha (mostrarSalidasdgv))");
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }

        }

        private void limpiarSalidas()
        {
            lvSalidas.Clear();
            lvSalidas.View = View.Details;
            lvSalidas.GridLines = true;
            lvSalidas.FullRowSelect = true;
            //lvSalidas.HideSelection = true;
            lvSalidas.Columns.Add("Id", 50);
            lvSalidas.Columns.Add("No.Expediente", 100);
            lvSalidas.Columns.Add("Responsable", 200);
        }

        private void actualizarEntradas()
        {
            lvEntradas.Clear();
            lvEntradas.View = View.Details;
            lvEntradas.GridLines = true;
            lvEntradas.FullRowSelect = true;
            lvEntradas.Columns.Add("Id", 50);
            lvEntradas.Columns.Add("No. de expediente", 100);
            lvEntradas.Columns.Add("Responsable", 200);

            obtenerNoExpNombreEntradas();
        }



        //private void agregaraEntradas(int idSal)
        //{

        //    DataSet dsEntradas = new DataSet();
        //    ListViewItem listaEntradas = null;
            
            

        //        try
        //        {
        //            ConexionBD.iniciarConexion();
        //            //MessageBox.Show(idSal.ToString());
        //            string datosEntradas = "SELECT noExpediente,fkResponsable FROM salidas where Id=" + idSal + "";
        //            //ConexionBD.iniciarConexion();
        //           adaptador = new OleDbDataAdapter(datosEntradas, ConexionBD.conexionbd);
        //           adaptador.Fill(dsEntradas);
                    

        //            string[] sal = new string[3];
        //            sal[0] = obtenerMaxIdEntrada().ToString();
        //            sal[1] = dsEntradas.Tables[0].Rows[0][0].ToString();
        //            int idResponsable = int.Parse(dsEntradas.Tables[0].Rows[0][1].ToString());
        //            //sal[2] = obtenerNombreResponsable(idResponsable);
        //            sal[2] = "hello";
        //            listaEntradas = new ListViewItem(sal);

        //            lvEntradas.Items.Add(listaEntradas);
                
        //        }
        //        catch (DBConcurrencyException ex)
        //        {
        //            MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //        }
        //        //catch
        //        //{
        //        //    MessageBox.Show("ERROR no se han podido agregar los datos a entradas");
        //        //}
        //        finally
        //        {
        //            ConexionBD.cerrarConexion();
        //        }
        // }

        private int obtenerMaxIdEntrada()
        {
            int max = 0;
            try
            {
                string maximo = "SELECT MAX(Id) FROM entradas";
                comando = new OleDbCommand(maximo, ConexionBD.conexionbd);
                ConexionBD.iniciarConexion();
                max = int.Parse(comando.ExecuteScalar().ToString());
                max = max + 1;
            }
            catch (DBConcurrencyException ex)
            {
                MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            //catch
            //{
            //    MessageBox.Show("ERROR No se pudo obtener el idMax de entradas");
            //}
            finally
            {
                ConexionBD.cerrarConexion();
            }

            return max;
        }
           

                    

        

       

        private void rESTAURARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string cadIdSalida = lvEntradas.SelectedItems[0].ToString();
                idSalida = int.Parse(Regex.Replace(cadIdSalida, @"[^\d]", ""));

                OleDbCommand comando2 = new OleDbCommand();

                try
                {
                    ConexionBD.iniciarConexion();
                    string consulta = "Select idSal from entradas where Id = " + idSalida + "";
                    comando = new OleDbCommand(consulta, ConexionBD.conexionbd);
                    int idSal = int.Parse(comando.ExecuteScalar().ToString());

                    try
                    {
                        string consRestaura = "UPDATE salidas SET entregado= false WHERE Id =" + idSal + "";
                        string entradaCancelado = "UPDATE entradas SET cancelado= true WHERE Id =" + idSalida + "";
                        comando = new OleDbCommand(consRestaura, ConexionBD.conexionbd);
                        comando2 = new OleDbCommand(entradaCancelado, ConexionBD.conexionbd);
                        comando.ExecuteNonQuery();
                        comando2.ExecuteNonQuery();
                        MessageBox.Show("Registro Restaurado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        actualizarDatosLv();

                    }

                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show("No se ha podido restaurar esta entrada de expediente:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                    finally
                    {
                        ConexionBD.cerrarConexion();
                    }

                }
                catch (DBConcurrencyException ex)
                {
                    actualizarDatosLv();
                    MessageBox.Show("Intente actualziar sus datos\n"+ex);
                    //MessageBox.Show(":\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                finally
                {
                    ConexionBD.cerrarConexion();
                }
            }
            catch
            { 
                MessageBox.Show("No ha seleccionado una entrada valida","Error", MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);

            }
            
            //restaurado(int idSalida)
        }

        private void lvEntradas_MouseHover(object sender, EventArgs e)
        {
            //actualizarDatosLv();
            actualizarEntradas();
        }

        private void lvEntradas_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           string sal= dateTimePicker1.Value.ToString("MM/dd/yyyy");
          
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calendario Habilitado:\nRecuerde colocar la fecha de hoy al realizar las salidas y/o entradas.");
            dateTimePicker1.Enabled = true;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloDigitaNumeros(e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software elaborado por el L.I. Francisco Márquez Estrada\nPara uso exclusivo del Centro Michoacano de Salud Mental.");
            Application.Exit();
        }
    }
}
