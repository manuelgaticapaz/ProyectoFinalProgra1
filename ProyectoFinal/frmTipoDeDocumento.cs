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
    public partial class frmTipoDeDocumento : Form
    {
        public static SqlConnection cnx; 
        public frmTipoDeDocumento()
        {
            InitializeComponent();
            btnGrabar.Text = "Nuevo";
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
            txtID.Enabled = false;
            txtNombres.Enabled = false;
            txtDescripcion.Enabled = false;
            txtFactor.Enabled = false;


           
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
            btnGrabar.Text = "Grabar";
            btnModificar.Enabled = true;
            btnBorrar.Enabled = true;
            txtID.Enabled = true;
            txtNombres.Enabled = true;
            txtDescripcion.Enabled = true;
            txtFactor.Enabled = true;

            if(txtID.Text != "")
            {
                TipodeDocumento tipoDeDocumento = new TipodeDocumento(txtID.Text, txtNombres.Text, txtDescripcion.Text, txtFactor.Text);
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
                SqlCommand cmd = new SqlCommand("sp_tipo_documento", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 0);

                cmd.Parameters.AddWithValue("@id", tipoDeDocumento.IdTDoc);
                cmd.Parameters.AddWithValue("@nombre", tipoDeDocumento.NombreTDoc);
                cmd.Parameters.AddWithValue("@descripcion", tipoDeDocumento.DescripcionTDoc);
                cmd.Parameters.AddWithValue("@factor", tipoDeDocumento.FactorTDoc);


                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Tipo de documento grabado...");
                this.Close();
            }

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                TipodeDocumento tipoDeDocumento = new TipodeDocumento(txtID.Text, txtNombres.Text, txtDescripcion.Text, txtFactor.Text);
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
                SqlCommand cmd = new SqlCommand("sp_tipo_documento", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 1);

                cmd.Parameters.AddWithValue("@id", tipoDeDocumento.IdTDoc);
                cmd.Parameters.AddWithValue("@nombre", tipoDeDocumento.NombreTDoc);
                cmd.Parameters.AddWithValue("@descripcion", tipoDeDocumento.DescripcionTDoc);
                cmd.Parameters.AddWithValue("@factor", tipoDeDocumento.FactorTDoc);


                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Tipo de documento modificado...");
                this.Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                TipodeDocumento tipoDeDocumento = new TipodeDocumento(txtID.Text, txtNombres.Text, txtDescripcion.Text, txtFactor.Text);
                cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
                SqlCommand cmd = new SqlCommand("sp_tipo_documento", cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@orden", 2);

                cmd.Parameters.AddWithValue("@id", tipoDeDocumento.IdTDoc);
                cmd.Parameters.AddWithValue("@nombre", tipoDeDocumento.NombreTDoc);
                cmd.Parameters.AddWithValue("@descripcion", tipoDeDocumento.DescripcionTDoc);
                cmd.Parameters.AddWithValue("@factor", tipoDeDocumento.FactorTDoc);


                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();

                MessageBox.Show("Tipo de documento eliminado...");
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
