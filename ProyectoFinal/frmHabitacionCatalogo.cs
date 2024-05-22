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
    public partial class frmHabitacionCatalogo : Form
    {

        public static SqlConnection cnx;

        ////Joaquin
        public string cadenaConexión = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n";
        //Manuel
        //public string cadenaConexión = "Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True";

        public frmHabitacionCatalogo()
        {
            InitializeComponent();
            cmbIDTipoHabitacion.Visible = false;
            btnGrabar.Visible = false;
            txtIDHabitacion.Enabled = false;
            txtTipoHabitacion.Enabled=false;
            txtDisponibilidad.Visible=false;
            lblDisponibilidad.Visible = false;
            cmbTipoHabitacion.Visible = false;
            chbDisponibilidad.Enabled = false;
            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_catalogo_habitacion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 4);
            dti = aDat.ObtieneData(cmd);
            dgvCatalogoHabitacion.DataSource = dti;
            dgvCatalogoHabitacion.SelectionChanged += dataGridView1_SelectionChanged;

        }




        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCatalogoHabitacion.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada

                DataGridViewRow row = dgvCatalogoHabitacion.SelectedRows[0];
                txtIDHabitacion.Text = row.Cells["Id"].Value.ToString();
                txtTipoHabitacion.Text = row.Cells["Tipo Habitación"].Value.ToString();
                txtNivelHabitacion.Text = row.Cells["Nivel"].Value.ToString();
                txtEntradaHabitacion.Text = row.Cells["Entrada Habitación"].Value.ToString();
                txtDisponibilidad.Text = row.Cells["Disponible"].Value.ToString();
                if (txtDisponibilidad.Text == "True")
                {
                    chbDisponibilidad.Checked = true;

                }
                else { chbDisponibilidad.Checked = false; }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Visible = false;
            txtIDHabitacion.Enabled = false;
            txtTipoHabitacion.Visible = false;
            txtDisponibilidad.Enabled = true;
            cmbTipoHabitacion.Enabled = true ;
            cmbTipoHabitacion.Visible = true ;
            txtIDHabitacion.Text = "";
            txtTipoHabitacion.Text = "";
            txtDisponibilidad.Text = "";
            txtNivelHabitacion.Text = "";
            txtEntradaHabitacion.Text = "";
            dgvCatalogoHabitacion.Enabled = false;
            btnGrabar.Visible = true;
            chbDisponibilidad.Enabled = true;

            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_catalogo_habitacion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 5);
            dti = aDat.ObtieneData(cmd);

            cmbTipoHabitacion.Items.Clear();
            cmbIDTipoHabitacion.Items.Clear();

            cmbTipoHabitacion.DisplayMember = "Tipo Habitación";
            cmbTipoHabitacion.ValueMember = "Id";
            cmbTipoHabitacion.DataSource = dti;

            cmbIDTipoHabitacion.DisplayMember = "Id";
            cmbIDTipoHabitacion.ValueMember = "Tipo Habitación";
            cmbIDTipoHabitacion.DataSource = dti;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            HabitacionCatalogo hab1 = new HabitacionCatalogo( 0,int.Parse(cmbIDTipoHabitacion.Text),txtNivelHabitacion.Text,txtEntradaHabitacion.Text,chbDisponibilidad.Checked);
            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_catalogo_habitacion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 0);
            cmd.Parameters.AddWithValue("@hab_idthb", hab1.HabIdTipoHabitacion);
            cmd.Parameters.AddWithValue("@nivel", hab1.Nivel);
            cmd.Parameters.AddWithValue("@comentario", hab1.Comentario);
            if (chbDisponibilidad.Checked)
            {
                cmd.Parameters.AddWithValue("@disponible", 1);
            }else
            {
                cmd.Parameters.AddWithValue("@disponible", 0);
            }
            
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Habitación grabada...");
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            txtIDHabitacion.Enabled = true;
            txtTipoHabitacion.Visible = true;
            txtDisponibilidad.Visible = false;
            cmbTipoHabitacion.Enabled = true;
            cmbTipoHabitacion.Visible = true;
            chbDisponibilidad.Enabled = true;

            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmdo = new SqlCommand("sp_catalogo_habitacion", cnx);
            cmdo.CommandType = CommandType.StoredProcedure;
            cmdo.Parameters.AddWithValue("@orden", 5);
            dti = aDat.ObtieneData(cmdo);

           

            cmbTipoHabitacion.DisplayMember = "Tipo Habitación";
            cmbTipoHabitacion.ValueMember = "Id";
            cmbTipoHabitacion.DataSource = dti;

            cmbIDTipoHabitacion.DisplayMember = "Id";
            cmbIDTipoHabitacion.ValueMember = "Tipo Habitación";
            cmbIDTipoHabitacion.DataSource = dti;


            if (txtIDHabitacion.Text != "")
            {
                HabitacionCatalogo hab1 = new HabitacionCatalogo (int.Parse(txtIDHabitacion.Text), int.Parse(cmbIDTipoHabitacion.Text), txtNivelHabitacion.Text, txtEntradaHabitacion.Text, chbDisponibilidad.Checked);
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_catalogo_habitacion", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 1);
                cmd.Parameters.AddWithValue("@id", hab1.Id);
                cmd.Parameters.AddWithValue("@hab_idthb", hab1.HabIdTipoHabitacion);
                cmd.Parameters.AddWithValue("@nivel", hab1.Nivel);
                cmd.Parameters.AddWithValue("@comentario", hab1.Comentario);
                if (chbDisponibilidad.Checked)
                {
                    cmd.Parameters.AddWithValue("@disponible", 1);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@disponible", 0);
                }
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Habitacion modificada...");
                this.Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtIDHabitacion.Text != "")
            {
                HabitacionCatalogo hab1 = new HabitacionCatalogo(int.Parse(txtIDHabitacion.Text), 1, txtNivelHabitacion.Text, txtEntradaHabitacion.Text, chbDisponibilidad.Checked);
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_catalogo_habitacion", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 2);
                cmd.Parameters.AddWithValue("@id", hab1.Id);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Habitacion borrada...");
                this.Close();
            }
            
            }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
