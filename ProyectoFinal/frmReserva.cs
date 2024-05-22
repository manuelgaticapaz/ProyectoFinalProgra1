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
        public string cadenaConexión = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n";
        //Manuel
        //public string cadenaConexión = "Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True";
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;

        public frmReserva()
        {
            InitializeComponent();
            cmbIdHuesped.Enabled = false;
            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

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


        //private void InitializeBindingSources()
        //{
        //    DataTable dti = new DataTable();
        //    AccesoDatos aDat = new AccesoDatos();

        //    cnx = new SqlConnection(cadenaConexión);
        //    SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@orden", 5);
        //    dti = aDat.ObtieneData(cmd);

        //    bindingSource1 = new BindingSource();
        //    bindingSource1.DataSource = dti;

        //    bindingSource2 = new BindingSource();
        //    bindingSource2.DataSource = dti;
        //}
        //private void ComboBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(cmbNombreReserva.Text))
        //    {
        //        bindingSource1.Filter = $"Nombre LIKE '%{cmbNombreReserva.Text}%'";
        //    }
        //    else
        //    {
        //        bindingSource1.RemoveFilter();
        //    }
        //}

        //private void ComboBox2_TextChanged(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(cmbIDReserva.Text))
        //    {
        //        bindingSource2.Filter = $"Identificación LIKE '%{cmbIDReserva.Text}%'";
        //    }
        //    else
        //    {
        //        bindingSource2.RemoveFilter();
        //    }
        //}



    }
}
