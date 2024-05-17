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
    public partial class frmHabitacion : Form
    {
        public static SqlConnection cnx;
        ////Joaquin
        //public string cadenaConexión = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n";
        //Manuel
        public string cadenaConexión = "Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True";

        public frmHabitacion()
        {
            InitializeComponent();
            btnGrabar.Text = "Nuevo";
            btnModificar.Enabled = false;
            btnBorrar.Enabled = true;
            txtIDHabitacion.Enabled = true;
            txtNombre.Enabled= false;
            txtDescripcion.Enabled=false;
            txtCapacidadP.Enabled=false;
            txtPrecio.Enabled=false;

            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_tipo_habitacion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 4);
            dti = aDat.ObtieneData(cmd);
            /*cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();*/
            dgvBuscaHabitacion.DataSource = dti;
            dgvBuscaHabitacion.SelectionChanged += dataGridView1_SelectionChanged;


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            btnGrabar.Text = "Grabar";
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            txtIDHabitacion.Enabled = true;
            txtNombre.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCapacidadP.Enabled = true;
            txtPrecio.Enabled = true;


            if(txtIDHabitacion.Text != "")
            {


             Habitacion habitacion = new Habitacion(int.Parse(txtIDHabitacion.Text), txtNombre.Text, txtDescripcion.Text, int.Parse(txtCapacidadP.Text), double.Parse(txtPrecio.Text));
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_tipo_habitacion", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 0);
                cmd.Parameters.AddWithValue("@id", habitacion.IdHabitacion);
                cmd.Parameters.AddWithValue("@nombre", habitacion.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", habitacion.Descripcion);
                cmd.Parameters.AddWithValue("@capacidadPersonas", habitacion.CapacidadP);
                cmd.Parameters.AddWithValue("@precio", habitacion.Precio);
            
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Tipo de habitación grabado...");
                this.Close();


            }

        }

      
        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (txtIDHabitacion.Text != "")
            {


                Habitacion habitacion = new Habitacion(int.Parse(txtIDHabitacion.Text), txtNombre.Text, txtDescripcion.Text, int.Parse(txtCapacidadP.Text), double.Parse(txtPrecio.Text));
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_tipo_habitacion", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 1);
                cmd.Parameters.AddWithValue("@id", habitacion.IdHabitacion);
                cmd.Parameters.AddWithValue("@nombre", habitacion.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", habitacion.Descripcion);
                cmd.Parameters.AddWithValue("@capacidadPersonas", habitacion.CapacidadP);
                cmd.Parameters.AddWithValue("@precio", habitacion.Precio);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Habitación modificada...");
                this.Close();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtIDHabitacion.Text != "")
            {
                Habitacion habitacion = new Habitacion(int.Parse(txtIDHabitacion.Text), txtNombre.Text, txtDescripcion.Text, int.Parse(txtCapacidadP.Text), double.Parse(txtPrecio.Text));
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_tipo_habitacion", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 2);
                cmd.Parameters.AddWithValue("@id", habitacion.IdHabitacion);
                cmd.Parameters.AddWithValue("@nombre", habitacion.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", habitacion.Descripcion);
                cmd.Parameters.AddWithValue("@capacidadPersonas", habitacion.CapacidadP);
                cmd.Parameters.AddWithValue("@precio", habitacion.Precio);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Habitación borrada...");
                this.Close();
            }



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBuscaHabitacion.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvBuscaHabitacion.SelectedRows[0];
                txtIDHabitacion.Text = row.Cells["Id"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtCapacidadP.Text = row.Cells["Capacidad"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
            }
        }

    }
}
