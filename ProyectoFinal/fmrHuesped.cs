using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal
{
    public partial class frmHuesped : Form
    {
        public static SqlConnection cnx;

        ////Joaquin
        public string cadenaConexión = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n";
        //Manuel
        //public string cadenaConexión = "Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True";

        public frmHuesped()
        {

            InitializeComponent();
            btnGrabar.Text = "Nuevo";

            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            txtIDHuesped.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtnumIdentificacionHuesped.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            txtTipodeHuesped.Enabled = false;

            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_huesped", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 4);
            dti = aDat.ObtieneData(cmd);
            /*cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();*/
            dgvBuscaHuesped.DataSource = dti;
            dgvBuscaHuesped.SelectionChanged += dataGridView1_SelectionChanged;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            btnGrabar.Text = "Grabar";
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            txtIDHuesped.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtnumIdentificacionHuesped.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtTipodeHuesped.Enabled = true;


            if (txtIDHuesped.Text != "")
            {   

                Huesped huesped = new Huesped(txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, long.Parse(txtnumIdentificacionHuesped.Text), txtDireccion.Text, txtEmail.Text, int.Parse(txtTelefono.Text), txtTipodeHuesped.Text);
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_huesped", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 0);
                cmd.Parameters.AddWithValue("@id", huesped.IdHuesped);
                cmd.Parameters.AddWithValue("@nombre", huesped.NombresHuesped);
                cmd.Parameters.AddWithValue("@apellido", huesped.ApellidosHuesped);
                cmd.Parameters.AddWithValue("@numIdentificacion", huesped.NumIdentificacionHuesped);
                cmd.Parameters.AddWithValue("@direccion", huesped.DireccionHuesped);
                cmd.Parameters.AddWithValue("@email", huesped.EmailHuesped);
                cmd.Parameters.AddWithValue("@telefono", huesped.TelefonoHuesped);
                cmd.Parameters.AddWithValue("@tipoHuesped", huesped.TipoHuesped);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Huesped grabado...");
                this.Close();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnBorrar.Enabled = true;
            txtIDHuesped.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtnumIdentificacionHuesped.Enabled = true;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            txtTipodeHuesped.Enabled = false;

            if (txtIDHuesped.Text != "")
            {
                DataTable dti = new DataTable();
                AccesoDatos aDat = new AccesoDatos();

                Huesped huesped = new Huesped(txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, long.Parse(txtnumIdentificacionHuesped.Text));
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_huesped", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 3);
                cmd.Parameters.AddWithValue("@id", huesped.IdHuesped);
                cmd.Parameters.AddWithValue("@nombre", huesped.NombresHuesped);
                cmd.Parameters.AddWithValue("@apellido", huesped.ApellidosHuesped);
                cmd.Parameters.AddWithValue("@numIdentificacion", huesped.NumIdentificacionHuesped);
                dti = aDat.ObtieneData(cmd);
                /*cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();*/
                dgvBuscaHuesped.DataSource = dti;

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            txtIDHuesped.Enabled = false;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtnumIdentificacionHuesped.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtTipodeHuesped.Enabled = true;


            if (txtIDHuesped.Text != "")
            {
                Huesped huesped = new Huesped(txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, long.Parse(txtnumIdentificacionHuesped.Text), txtDireccion.Text, txtEmail.Text, int.Parse(txtTelefono.Text), txtTipodeHuesped.Text);
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_huesped", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 1);
                cmd.Parameters.AddWithValue("@id", huesped.IdHuesped);
                cmd.Parameters.AddWithValue("@nombre", huesped.NombresHuesped);
                cmd.Parameters.AddWithValue("@apellido", huesped.ApellidosHuesped);
                cmd.Parameters.AddWithValue("@numIdentificacion", huesped.NumIdentificacionHuesped);
                cmd.Parameters.AddWithValue("@direccion", huesped.DireccionHuesped);
                cmd.Parameters.AddWithValue("@email", huesped.EmailHuesped);
                cmd.Parameters.AddWithValue("@telefono", huesped.TelefonoHuesped);
                cmd.Parameters.AddWithValue("@tipoHuesped", huesped.TipoHuesped);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Huesped modificado...");
                this.Close();
            }
                

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtIDHuesped.Text != "")
            {
                Huesped huesped = new Huesped(txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, long.Parse(txtnumIdentificacionHuesped.Text), txtDireccion.Text, txtEmail.Text, int.Parse(txtTelefono.Text), txtTipodeHuesped.Text);
                cnx = new SqlConnection(cadenaConexión);
                SqlCommand cmd = new SqlCommand("sp_huesped", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 2);
                cmd.Parameters.AddWithValue("@id", huesped.IdHuesped);
                cmd.Parameters.AddWithValue("@nombre", huesped.NombresHuesped);
                cmd.Parameters.AddWithValue("@apellido", huesped.ApellidosHuesped);
                cmd.Parameters.AddWithValue("@numIdentificacion", huesped.NumIdentificacionHuesped);
                cmd.Parameters.AddWithValue("@direccion", huesped.DireccionHuesped);
                cmd.Parameters.AddWithValue("@email", huesped.EmailHuesped);
                cmd.Parameters.AddWithValue("@telefono", huesped.TelefonoHuesped);
                cmd.Parameters.AddWithValue("@tipoHuesped", huesped.TipoHuesped);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("Huesped eliminado...");
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBuscaHuesped.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvBuscaHuesped.SelectedRows[0];
                txtIDHuesped.Text = row.Cells["Id"].Value.ToString();
                txtNombres.Text = row.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = row.Cells["Apellidos"].Value.ToString();
                txtnumIdentificacionHuesped.Text = row.Cells["No. Identificacion"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtTipodeHuesped.Text = row.Cells["Tipo Huesped"].Value.ToString();
            }
        }

        private void txtIDHuesped_TextChanged(object sender, EventArgs e)
        {

        }
    }
}