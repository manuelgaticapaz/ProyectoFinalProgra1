﻿using System;
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
            txtIDHuesped.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtnumIdentificacionHuesped.Enabled = true;
            txtDireccion.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            txtTipodeHuesped.Enabled = false;

            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            ////Base Joaquin
            //cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
            //Base Manuel
            cnx = new SqlConnection("Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_huesped", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 4);
            dti = aDat.ObtieneData(cmd);
            /*cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();*/
            dgvBuscaHuesped.DataSource = dti;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
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

            if (txtIDHuesped.Text != "")
            {
                Huesped huesped = new Huesped(txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, long.Parse(txtnumIdentificacionHuesped.Text), txtDireccion.Text, txtEmail.Text, int.Parse(txtTelefono.Text), txtTipodeHuesped.Text);
                ////Base Joaquin
                //cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
                //Base Manuel
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            Huesped huesped = new Huesped(txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, long.Parse(txtnumIdentificacionHuesped.Text));
            ////Base Joaquin
            //cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
            //Base Manuel
            cnx = new SqlConnection("Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True");
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIDHuesped.Text != "")
            {
                Huesped huesped = new Huesped(txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, long.Parse(txtnumIdentificacionHuesped.Text), txtDireccion.Text, txtEmail.Text, int.Parse(txtTelefono.Text), txtTipodeHuesped.Text);
                ////Base Joaquin
                //cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
                //Base Manuel
                cnx = new SqlConnection("Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True");
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
                ////Base Joaquin
                //cnx = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
                //Base Manuel
                cnx = new SqlConnection("Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True");
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

    }
}