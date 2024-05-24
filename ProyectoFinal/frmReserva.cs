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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservaciones.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada

                DataGridViewRow row = dgvReservaciones.SelectedRows[0];
                //txtIDHabitacion.Text = row.Cells["Id"].Value.ToString();
                //txtTipoHabitacion.Text = row.Cells["Tipo Habitación"].Value.ToString();
                //txtNivelHabitacion.Text = row.Cells["Nivel"].Value.ToString();
                //txtEntradaHabitacion.Text = row.Cells["Entrada Habitación"].Value.ToString();
                //txtDisponibilidad.Text = row.Cells["Disponible"].Value.ToString();
                //if (txtDisponibilidad.Text == "True")
                //{
                //    chbDisponibilidad.Checked = true;

                //}
                //else { chbDisponibilidad.Checked = false; }
            }
        }

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

        private void btnVerDisponibilidad_Click(object sender, EventArgs e)
        {
            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            Reservacion resv1 = new Reservacion(0, cmbIdHuesped.Text, int.Parse(txtCantidadPersonas.Text),dtpIngreso.Value, dtpSalida.Value);
            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 4);
            cmd.Parameters.AddWithValue("@cantPersonas", resv1.CantidadPersonas);
            cmd.Parameters.AddWithValue("@fechaIngreso",resv1.FechaInicio);
            cmd.Parameters.AddWithValue("@fechaSalida", resv1.FechaFinal);
            dti = aDat.ObtieneData(cmd);
            dgvReservaciones.DataSource = dti;
            dgvReservaciones.SelectionChanged += dataGridView1_SelectionChanged;


        }
    }
}
