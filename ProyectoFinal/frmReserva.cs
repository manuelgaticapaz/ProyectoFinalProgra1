using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal
{
    public partial class frmReserva : Form
    {

        public static SqlConnection cnx;
        ////Joaquin
        //public string cadenaConexión = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n";
        //Manuel
        public string cadenaConexión = "Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True";
        int noches = 0;
        double precioNoche = 0;
        double precioTotal = 0;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservaciones.SelectedRows.Count > 0)
                {
                    TimeSpan dif = DateTime.Parse(dtpSalida.Text) - DateTime.Parse(dtpIngreso.Text);
                    int dias = dif.Days + 1;
                    noches = dias;
                    DataGridViewRow row = dgvReservaciones.SelectedRows[0];
                    txtNivel.Text = row.Cells["Nivel"].Value.ToString();
                    txtIdHabitacion.Text = row.Cells["Id"].Value.ToString();
                    txtCapacidad.Text = row.Cells["Capacidad"].Value.ToString();
                    txtNombrePuerta.Text = row.Cells["Nombre Puerta"].Value.ToString();
                    lblPrecioEstadia.Text = "Q." + Math.Round((double.Parse(row.Cells["Precio"].Value.ToString()) * dias), 2);
                    precioTotal = Math.Round((double.Parse(row.Cells["Precio"].Value.ToString()) * dias), 2);
                    precioNoche = precioTotal / noches;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("Error al ver disponibilidad: " + a.Message);
            }
        }

        public frmReserva()
        {
            InitializeComponent();
            cmbIdHuesped.Enabled = false;
            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();
            txtNivel.Enabled = false;
            txtIdHabitacion.Enabled = false;
            txtCapacidad.Enabled = false;
            txtNombrePuerta.Enabled = false;    


            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 5);
            dti = aDat.ObtieneData(cmd);

            cmbNombreReserva.Items.Clear();
            cmbIDReserva.Items.Clear();

            cmbNombreReserva.DisplayMember = "Nombre";
            cmbNombreReserva.ValueMember = "Nombre";
            cmbNombreReserva.DataSource = dti;

            cmbIDReserva.DisplayMember = "Identificación";
            cmbIDReserva.ValueMember = "Nombre";
            cmbIDReserva.DataSource = dti;

            cmbIdHuesped.DisplayMember = "Id";
            cmbIdHuesped.ValueMember = "Nombre";
            cmbIdHuesped.DataSource = dti;

        }

        private void btnVerDisponibilidad_Click(object sender, EventArgs e)
        {
            cmbNombreReserva.Enabled = false;
            cmbIDReserva.Enabled = false;
            txtCantidadPersonas.Enabled = false;
            dtpIngreso.Enabled = false;
            dtpSalida.Enabled = false;
            try 
            {
                TimeSpan dif = DateTime.Parse(dtpSalida.Text) - DateTime.Parse(dtpIngreso.Text);
                int dias = dif.Days + 1;
                noches = dias;
                DataTable dti = new DataTable();
                AccesoDatos aDat = new AccesoDatos();
                Reservacion resv1 = new Reservacion(0, cmbIdHuesped.Text, int.Parse(txtCantidadPersonas.Text), dtpIngreso.Value, dtpSalida.Value);
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 4);
                cmd.Parameters.AddWithValue("@cantPersonas", resv1.CantidadPersonas);
                cmd.Parameters.AddWithValue("@fechaIngreso", resv1.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaSalida", resv1.FechaFinal);
                dti = aDat.ObtieneData(cmd);
                dgvReservaciones.DataSource = dti;
                dgvReservaciones.SelectionChanged += dataGridView1_SelectionChanged;
                lblCantidadNoches.Text = noches.ToString();


            }
            catch (Exception a)
            {
                MessageBox.Show("Error al ver disponibilidad: " + a.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                Reservacion resv1 = new Reservacion(0, cmbIdHuesped.Text, int.Parse(txtIdHabitacion.Text),int.Parse(txtCantidadPersonas.Text), dtpIngreso.Value, dtpSalida.Value, noches, precioNoche, precioTotal);
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 0);
                cmd.Parameters.AddWithValue("@idHuesped", resv1.IdHuesped);
                cmd.Parameters.AddWithValue("@idHabitacion", resv1.IdHabitacion);
                cmd.Parameters.AddWithValue("@fechaIngreso", resv1.FechaInicio);
                cmd.Parameters.AddWithValue("@fechaSalida", resv1.FechaFinal);
                cmd.Parameters.AddWithValue("@noches", resv1.CantNoches);
                cmd.Parameters.AddWithValue("@precioNoche", resv1.Precio); 
                cmd.Parameters.AddWithValue("@precioTotal", resv1.PrecioFinal);  
                cnx.Open();                                                        
                cmd.ExecuteNonQuery();                                             
                cnx.Close();                                                       
                                                                                   
                MessageBox.Show("Reservación generada...");                             
                this.Close();                                                      
            }
            catch (Exception a)
            {
                MessageBox.Show("Error al generar reservación: " + a.Message);
            }
        }
    }
}
