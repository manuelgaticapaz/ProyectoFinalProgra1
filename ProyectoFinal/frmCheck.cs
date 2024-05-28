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
                    cmbIdReservación.Text = row.Cells["No. Reservación"].Value.ToString();

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
            cmbIdReservación.Items.Clear();

            cmbNombreHuesped.DisplayMember = "Nombre";
            cmbNombreHuesped.ValueMember = "Nombre";
            cmbNombreHuesped.DataSource = dti;

            cmbIdHuesped.DisplayMember = "Identificación";
            cmbIdHuesped.ValueMember = "Nombre";
            cmbIdHuesped.DataSource = dti;

            cmbIdReservación.DisplayMember = "No. Reservación";
            cmbIdReservación.ValueMember = "Nombre";
            cmbIdReservación.DataSource = dti;

        }

    }
}
