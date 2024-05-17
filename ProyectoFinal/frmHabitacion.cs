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

        public frmHabitacion()
        {
            InitializeComponent();
            btnGrabar.Text = "Nuevo";
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            txtIDHabitacion.Enabled = true;
            txtNombre.Enabled= false;
            txtDescripcion.Enabled=false;
            txtCapacidadP.Enabled=false;
            txtPrecio.Enabled=false;
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
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
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
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
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
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
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
    }
}
