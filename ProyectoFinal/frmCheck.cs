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

namespace ProyectoFinal
{
    public partial class frmCheck : Form
    {

        public static SqlConnection cnx;
        ////Joaquin
        //public string cadenaConexión = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n";
        //Manuel
        public string cadenaConexión = "Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True";


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCheckIn.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvCheckIn.SelectedRows[0];
                    cmbNombreHuesped.Text = row.Cells["Nombre"].Value.ToString();
                    cmbIdHuesped.Text = row.Cells["Identificación"].Value.ToString();
                    cmbIdReservacion.Text = row.Cells["Id"].Value.ToString();

                }

            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }
        }
        private void dataGridView1_SelectionChanged2(object sender, EventArgs e)
        {
            try
            {
                if (dgvCheckIn.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvCheckIn.SelectedRows[0];
                    cmbNombreHuespedOut.Text = row.Cells["Nombre"].Value.ToString();
                    cmbIdHuespedOut.Text = row.Cells["Identificación"].Value.ToString();
                    cmbIdReservacionOut.Text = row.Cells["Id"].Value.ToString();

                }

            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }
        }

        public frmCheck()
        {
            InitializeComponent();

            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 6);
            dti = aDat.ObtieneData(cmd);
            dgvCheckIn.DataSource = dti;
            dgvCheckIn.SelectionChanged += dataGridView1_SelectionChanged;

            cmbNombreHuesped.Items.Clear();
            cmbIdHuesped.Items.Clear();
            cmbIdReservacion.Items.Clear();

            cmbNombreHuesped.DisplayMember = "Nombre";
            cmbNombreHuesped.ValueMember = "Nombre";
            cmbNombreHuesped.DataSource = dti;

            cmbIdHuesped.DisplayMember = "Identificación";
            cmbIdHuesped.ValueMember = "Nombre";
            cmbIdHuesped.DataSource = dti;

            cmbIdReservacion.DisplayMember = "Id";
            cmbIdReservacion.ValueMember = "Nombre";
            cmbIdReservacion.DataSource = dti;

            DataTable dti2 = new DataTable();
            AccesoDatos aDat2 = new AccesoDatos();

            SqlCommand cmd2 = new SqlCommand("sp_reservacion", cnx);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@orden", 8);
            dti2 = aDat2.ObtieneData(cmd2);
            dgvCheckOut.DataSource = dti2;
            dgvCheckOut.SelectionChanged += dataGridView1_SelectionChanged2;

            cmbNombreHuespedOut.Items.Clear();
            cmbIdHuespedOut.Items.Clear();
            cmbIdReservacionOut.Items.Clear();

            cmbNombreHuespedOut.DisplayMember = "Nombre";
            cmbNombreHuespedOut.ValueMember = "Nombre";
            cmbNombreHuespedOut.DataSource = dti2;

            cmbIdHuespedOut.DisplayMember = "Identificación";
            cmbIdHuespedOut.ValueMember = "Nombre";
            cmbIdHuespedOut.DataSource = dti2;

            cmbIdReservacionOut.DisplayMember = "Id";
            cmbIdReservacionOut.ValueMember = "Nombre";
            cmbIdReservacionOut.DataSource = dti2;


        }

        private void btnEjecutarCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkCheckIn.Checked)
                {
                    cnx = new SqlConnection(cadenaConexión);
                    SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orden", 7);
                    cmd.Parameters.AddWithValue("@idReservacion", int.Parse(cmbIdReservacion.Text));

                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    MessageBox.Show("Check In Completo... ");
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Error: Debe hacer click en el cuadro Check In" );

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }
        }

        private void btnEjecutarCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkCheckOut.Checked)
                {
                    cnx = new SqlConnection(cadenaConexión);
                    SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orden", 9);
                    cmd.Parameters.AddWithValue("@idReservacion", int.Parse(cmbIdReservacionOut.Text));

                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    MessageBox.Show("Check Out Completo... ");
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Error: Debe hacer click en el cuadro Check Out");

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }

        }
    }
}
