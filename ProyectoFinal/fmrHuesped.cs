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
    public partial class frmHuesped : Form
    {
        public static SqlConnection cnx;

        public frmHuesped()
        {
            InitializeComponent();
            btnGrabar.Text = "Nuevo";
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            txtIDHuesped.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtnumIdentificacionHuesped.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            txtTipodeHuesped.Enabled = false;   
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Huesped huesped = new Huesped( txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, int.Parse(txtnumIdentificacionHuesped.Text), txtDireccion.Text, txtEmail.Text, int.Parse(txtTelefono.Text), txtTipodeHuesped.Text);
            strCat = "INSERT INTO [dbo].[HSD_HUESPED]\r\n           ([HSD_ID]\r\n           ,[HSD_NOMBRE]\r\n           ,[HSD_APELLIDO]\r\n           ,[HSD_NUMERO_IDENTIFICACION]\r\n           ,[HSD_DIRECCION]\r\n           ,[HSD_EMAIL]\r\n           ,[HSD_TELEFONO]\r\n           ,[HSD_TIPO_HUESPED])\r\n     VALUES\r\n           ( ";
            strCat = strCat + "'" + txtIDHuesped.Text + "', '" + txtNombres.Text + "', '"+ txtApellidos.Text + "', "+ int.Parse(txtnumIdentificacionHuesped.Text) + ", '"+ txtDireccion.Text + "', '"
+ txtEmail.Text + "', "
+ int.Parse(txtTelefono.Text) + ", '"+ txtTipodeHuesped.Text + "') ";
=======
            btnGrabar.Text = "Grabar";
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            txtIDHuesped.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtnumIdentificacionHuesped.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtTipodeHuesped.Enabled = true;
>>>>>>> ad5fb319f92e5417d44c6d6a76b48984b3191fce

            if (txtIDHuesped.Text != "")
            {
                Huesped huesped = new Huesped(txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, long.Parse(txtnumIdentificacionHuesped.Text), txtDireccion.Text, txtEmail.Text, int.Parse(txtTelefono.Text), txtTipodeHuesped.Text);
                cnx = new SqlConnection("Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True");
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


    }
}
