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
    public partial class frmServicio : Form
    {

        public static SqlConnection cnx;
        public frmServicio()
        {
            InitializeComponent();
            btnGrabar.Text = "Nuevo";
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            txtIDServicios.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCosto.Enabled = false;
            txtHoraInicio.Enabled = false;
            txtHoraFinal.Enabled = false;
            txtDisponibilidad.Enabled = false;
            txtReservas.Enabled = false;

        }

        private void frmServicio_Load(object sender, EventArgs e)
        {
            btnGrabar.Text = "Nuevo";
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            txtIDServicios.Enabled = false;
            txtDescripcion.Enabled = false;
            txtCosto.Enabled = false;
            txtHoraInicio.Enabled = false;
            txtHoraFinal.Enabled = false;
            txtDisponibilidad.Enabled = false;
            txtReservas.Enabled = false;
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {


            btnGrabar.Text = "Grabar";
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            txtIDServicios.Enabled = true;
            txtDescripcion.Enabled = true;
            txtCosto.Enabled = true;
            txtHoraInicio.Enabled = true;
            txtHoraFinal.Enabled = true;
            txtDisponibilidad.Enabled = true;
            txtReservas.Enabled = true;

            if (txtIDServicios.Text != "")
            {
                Servicio servicio = new Servicio(txtIDServicios.Text, txtDescripcion.Text, double.Parse(txtCosto.Text), txtHoraInicio.Text, txtHoraFinal.Text, txtDisponibilidad.Text, txtReservas.Text);
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
                SqlCommand cmd = new SqlCommand("sp_servicio", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 0);

                cmd.Parameters.AddWithValue("@id", servicio.IdServicio);
                cmd.Parameters.AddWithValue("@descripcion", servicio.Descripcion);
                cmd.Parameters.AddWithValue("@valor", servicio.Valor);
                cmd.Parameters.AddWithValue("@horaInicio", servicio.Horainicio);
                cmd.Parameters.AddWithValue("@horaFinal", servicio.Horafinal);
                cmd.Parameters.AddWithValue("@disponibilidad", servicio.Disponibilidad);
                cmd.Parameters.AddWithValue("@reservas", servicio.Reservas);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Servicio grabado...");
                this.Close();
            }
        }
        private void frmServicio_Loadobject(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIDServicios.Text != "")
            {
                Servicio servicio = new Servicio(txtIDServicios.Text, txtDescripcion.Text, double.Parse(txtCosto.Text), txtHoraInicio.Text, txtHoraFinal.Text, txtDisponibilidad.Text, txtReservas.Text);
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
                SqlCommand cmd = new SqlCommand("sp_servicio", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 1);

                cmd.Parameters.AddWithValue("@id", servicio.IdServicio);
                cmd.Parameters.AddWithValue("@descripcion", servicio.Descripcion);
                cmd.Parameters.AddWithValue("@valor", servicio.Valor);
                cmd.Parameters.AddWithValue("@horaInicio", servicio.Horainicio);
                cmd.Parameters.AddWithValue("@horaFinal", servicio.Horafinal);
                cmd.Parameters.AddWithValue("@disponibilidad", servicio.Disponibilidad);
                cmd.Parameters.AddWithValue("@reservas", servicio.Reservas);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Servicio modificado...");
                this.Close();
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtIDServicios.Text != "")
            {
                Servicio servicio = new Servicio(txtIDServicios.Text, txtDescripcion.Text, double.Parse(txtCosto.Text), txtHoraInicio.Text, txtHoraFinal.Text, txtDisponibilidad.Text, txtReservas.Text);
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
                SqlCommand cmd = new SqlCommand("sp_servicio", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 2);

                cmd.Parameters.AddWithValue("@id", servicio.IdServicio);
                cmd.Parameters.AddWithValue("@descripcion", servicio.Descripcion);
                cmd.Parameters.AddWithValue("@valor", servicio.Valor);
                cmd.Parameters.AddWithValue("@horaInicio", servicio.Horainicio);
                cmd.Parameters.AddWithValue("@horaFinal", servicio.Horafinal);
                cmd.Parameters.AddWithValue("@disponibilidad", servicio.Disponibilidad);
                cmd.Parameters.AddWithValue("@reservas", servicio.Reservas);

                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Servicio eliminado...");
                this.Close();

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

