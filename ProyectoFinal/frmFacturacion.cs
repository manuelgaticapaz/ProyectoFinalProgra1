using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmFacturacion : Form
    {
        public static SqlConnection cnx;
        ////Joaquin
        //public string cadenaConexión = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n";
        //Manuel
        public string cadenaConexión = "Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True";

        public frmFacturacion()
        {
            InitializeComponent();
            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            cmbIdentificacionHuesped.Enabled = false;
            cmbNombreHuesped.Enabled = false;
            chkNuevosDatosFacturacion.Visible = false;
            txtNombre.Enabled = false;
            txtNit.Enabled = false;
            txtDireccion.Enabled = false;


            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 8);
            dti = aDat.ObtieneData(cmd);

            cmbIdReservacion.Items.Clear();
            cmbIdentificacionHuesped.Items.Clear();
            cmbNombreHuesped.Items.Clear();

            cmbNombreHuesped.DisplayMember = "Nombre";
            cmbNombreHuesped.ValueMember = "Nombre";
            cmbNombreHuesped.DataSource = dti;

            cmbIdentificacionHuesped.DisplayMember = "Identificación";
            cmbIdentificacionHuesped.ValueMember = "Nombre";
            cmbIdentificacionHuesped.DataSource = dti;

            cmbIdReservacion.DisplayMember = "Id";
            cmbIdReservacion.ValueMember = "Nombre";
            cmbIdReservacion.DataSource = dti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbIdReservacion.Enabled = false;
            btnVerGastos.Visible = false;
            chkNuevosDatosFacturacion.Visible = true;
            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();
            txtNombre.Enabled = false;
            txtNit.Enabled = false;
            txtDireccion.Enabled = false;

            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_cargo", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 1);
            cmd.Parameters.AddWithValue("@idReservacion", int.Parse(cmbIdReservacion.Text));
            dti = aDat.ObtieneData(cmd);
            dgvFacturacion.DataSource = dti;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            if (chkCSV.Checked) 
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {

                    Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                    Title = "Save as CSV File"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                        {
                            writer.WriteLine("Factura No. " + cmbIdReservacion.Text);

                            writer.WriteLine("Hotel: Los Otakos");
                            writer.WriteLine("NIT: 8967487-1");
                            string currentDate = DateTime.Now.ToString();
                            writer.WriteLine("Fecha de Generación: " + currentDate);
                            writer.WriteLine();
                            writer.WriteLine();
                            if (chkNuevosDatosFacturacion.Checked)
                            {
                                writer.WriteLine("Nombre: " + txtNombre.Text);
                                writer.WriteLine("Nit: " + txtNit.Text);
                                writer.WriteLine("Dirección: " + txtDireccion.Text);

                            }
                            else
                            {
                                writer.WriteLine("Nombre: " + cmbNombreHuesped.Text);
                                writer.WriteLine("Nit: " + cmbIdentificacionHuesped.Text);
                                writer.WriteLine("Dirección: Ciudad" );

                            }
                            writer.WriteLine();
                            writer.WriteLine();


                            // Escribir los encabezados de columna
                            for (int i = 0; i < dgvFacturacion.Columns.Count; i++)
                            {
                                writer.Write(dgvFacturacion.Columns[i].HeaderText);
                                if (i < dgvFacturacion.Columns.Count - 1)
                                {
                                    writer.Write(";");
                                }
                            }
                            writer.WriteLine();

                            // Escribir las filas de datos
                            for (int i = 0; i < dgvFacturacion.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvFacturacion.Columns.Count; j++)
                                {
                                    writer.Write(dgvFacturacion.Rows[i].Cells[j].Value?.ToString());
                                    if (j < dgvFacturacion.Columns.Count - 1)
                                    {
                                        writer.Write(";");
                                    }
                                }
                                writer.WriteLine();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving file: " + ex.Message);
                    }
                }
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                    Title = "Save as Text File"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                        {
                            writer.WriteLine("Factura No. " + cmbIdReservacion.Text);

                            writer.WriteLine("Hotel: Los Otakos");
                            writer.WriteLine("NIT: 8967487-1");
                            string currentDate = DateTime.Now.ToString();
                            writer.WriteLine("Fecha de Generación: " + currentDate);
                            writer.WriteLine();
                            writer.WriteLine();
                            if (chkNuevosDatosFacturacion.Checked)
                            {
                                writer.WriteLine("Nombre: " + txtNombre.Text);
                                writer.WriteLine("Nit: " + txtNit.Text);
                                writer.WriteLine("Dirección: " + txtDireccion.Text);

                            }
                            else
                            {
                                writer.WriteLine("Nombre: " + cmbNombreHuesped.Text);
                                writer.WriteLine("Nit: " + cmbIdentificacionHuesped.Text);
                                writer.WriteLine("Dirección: Ciudad");

                            }
                            writer.WriteLine();
                            writer.WriteLine();

                            // Escribir los encabezados de columna
                            for (int i = 0; i < dgvFacturacion.Columns.Count; i++)
                            {
                                writer.Write(dgvFacturacion.Columns[i].HeaderText);
                                if (i < dgvFacturacion.Columns.Count - 1)
                                {
                                    writer.Write("\t");
                                }
                            }
                            writer.WriteLine();

                            // Escribir las filas de datos
                            for (int i = 0; i < dgvFacturacion.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvFacturacion.Columns.Count; j++)
                                {
                                    writer.Write(dgvFacturacion.Rows[i].Cells[j].Value?.ToString());
                                    if (j < dgvFacturacion.Columns.Count - 1)
                                    {
                                        writer.Write("\t");
                                    }
                                }
                                writer.WriteLine();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                }
            }


            
        }

        private void chkNuevosDatosFacturacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuevosDatosFacturacion.Checked)
            {
                txtNombre.Enabled = true;
                txtNit.Enabled = true;
                txtDireccion.Enabled = true;

            }
            else
            {
                txtDireccion.Clear();
                txtNombre.Clear();
                txtNit.Clear();

                txtNombre.Enabled = false;
                txtNit.Enabled = false;
                txtDireccion.Enabled = false;
            }
        }
    }
}
