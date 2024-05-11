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
    public partial class frmServicio : Form
    {

        public static SqlConnection cnx;
        public frmServicio()
        {
            InitializeComponent();
        }

        private void frmServicio_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Servicio servicio = new Servicio( txtIDServicios.Text, txtDescripcion.Text, double.Parse(txtCosto.Text), txtHoraInicio.Text, txtHoraFinal.Text, txtDisponibilidad.Text, txtReservas.Text);
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
        private void frmServicio_Loadobject (object sender, EventArgs e)
        {

        }
    }
}
