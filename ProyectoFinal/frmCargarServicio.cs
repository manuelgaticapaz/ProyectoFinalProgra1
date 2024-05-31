using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmCargarServicio : Form
    {
        public static SqlConnection cnx;
        ////Joaquin
        //public string cadenaConexión = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n";
        //Manuel
        public string cadenaConexión = "Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True";
        public double totalSinDescuento, totalDescuento, totalFinal;

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvHabitaciones.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dgvHabitaciones.SelectedRows[0];
                    cmbHuesped.Text = row.Cells["Nombre"].Value.ToString();
                    cmbIdHuesped.Text = row.Cells["Identificación"].Value.ToString();
                    cmbIdReservacion.Text = row.Cells["Id"].Value.ToString();

                }

            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }
        }

        public frmCargarServicio()
        {
            InitializeComponent();
            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();
            cmbServicio.Enabled = false;
            cmbIdServicio.Enabled = false;
            txtCantidad.Enabled = false;
            txtDescripcion.Enabled = false;
            txtDescuentoTotal.Enabled = false;
            txtDescuentoUnitario.Enabled = false;
            chkDescuentoTotal.Enabled = false;
            chkDescuentoUnitario.Enabled = false;
            cmbPrecioUnitario.Enabled = false;
            btnCargarServicio.Visible = false;

            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_reservacion", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 8);
            dti = aDat.ObtieneData(cmd);
            dgvHabitaciones.DataSource = dti;
            dgvHabitaciones.SelectionChanged += dataGridView1_SelectionChanged;

            cmbHuesped.Items.Clear();
            cmbIdHuesped.Items.Clear();
            cmbIdReservacion.Items.Clear();

            cmbHuesped.DisplayMember = "Nombre";
            cmbHuesped.ValueMember = "Nombre";
            cmbHuesped.DataSource = dti;

            cmbIdHuesped.DisplayMember = "Identificación";
            cmbIdHuesped.ValueMember = "Nombre";
            cmbIdHuesped.DataSource = dti;

            cmbIdReservacion.DisplayMember = "Id";
            cmbIdReservacion.ValueMember = "Nombre";
            cmbIdReservacion.DataSource = dti;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DataTable dti = new DataTable();
            AccesoDatos aDat = new AccesoDatos();

            btnSeleccionar.Enabled= false;
            cmbHuesped.Enabled = false;
            cmbIdHuesped.Enabled = false;
            cmbIdReservacion.Enabled = false;
            dgvHabitaciones.Enabled = false;
            cmbServicio.Enabled = true;
            cmbIdServicio.Enabled = true;
            txtCantidad.Enabled = true;
            txtDescripcion.Enabled = true;
            chkDescuentoTotal.Enabled = true;
            chkDescuentoUnitario.Enabled = true;

            cnx = new SqlConnection(cadenaConexión);
            SqlCommand cmd = new SqlCommand("sp_cargo", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orden", 3);
            dti = aDat.ObtieneData(cmd);

            cmbServicio.Items.Clear();
            cmbIdServicio.Items.Clear();
            cmbIdServicio.Items.Clear();

            cmbServicio.DisplayMember = "Nombre";
            cmbServicio.ValueMember = "Nombre";
            cmbServicio.DataSource = dti;

            cmbIdServicio.DisplayMember = "Id";
            cmbIdServicio.ValueMember = "Nombre";
            cmbIdServicio.DataSource = dti;

            cmbPrecioUnitario.DisplayMember = "Precio";
            cmbPrecioUnitario.ValueMember = "Nombre";
            cmbPrecioUnitario.DataSource = dti;



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();


        }

        private void chkDescuentoUnitario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescuentoUnitario.Checked)
            {
                txtDescuentoUnitario.Enabled = true;
                txtDescuentoTotal.Enabled = false;
                txtDescuentoTotal.Text = "";
                chkDescuentoTotal.Checked = false;

            }
            else
            {
                txtDescuentoUnitario.Enabled = false;
                txtDescuentoTotal.Enabled = false;
                txtDescuentoTotal.Text = "";
                chkDescuentoTotal.Checked = false;
            }
        }

        private void chkDescuentoTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDescuentoTotal.Checked)
            {
                txtDescuentoTotal.Enabled = true;
                txtDescuentoUnitario.Enabled = false;
                txtDescuentoUnitario.Text = "";
                chkDescuentoUnitario.Checked = false;

            }
            else
            {
                txtDescuentoTotal.Enabled = false;
                txtDescuentoUnitario.Enabled = false;
                txtDescuentoUnitario.Text = "";
                chkDescuentoUnitario.Checked = false;

            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            cmbServicio.Enabled = false;
            cmbIdServicio.Enabled = false;
            txtCantidad.Enabled = false;
            txtDescripcion.Enabled = false;
            chkDescuentoTotal.Enabled = false;
            chkDescuentoUnitario.Enabled = false;
            txtDescuentoTotal.Enabled = false;
            txtDescuentoUnitario.Enabled = false;
            btnCalcular.Enabled = false;
            totalSinDescuento = Math.Round(double.Parse(txtCantidad.Text) * double.Parse(cmbPrecioUnitario.Text), 2);
            lblPrecioSinDescuento.Text = "Q." + totalSinDescuento.ToString("0.00");
            if (chkDescuentoTotal.Checked)
            {
                totalDescuento = Math.Round(double.Parse(txtDescuentoTotal.Text), 2);
                lblTotalDescuento.Text = "- Q." + totalDescuento.ToString("0.00");
            }if (chkDescuentoUnitario.Checked)
            {
                totalDescuento = Math.Round((int.Parse(txtCantidad.Text) * double.Parse(txtDescuentoUnitario.Text)), 2);
                lblTotalDescuento.Text = "- Q." + totalDescuento.ToString("0.00");
            }
            else
            {
                totalDescuento = 0;
                lblTotalDescuento.Text = "- Q." + totalDescuento.ToString("0.00");
            }    
            totalFinal = totalSinDescuento - totalDescuento;
            lblPrecioTotal.Text = "Q." + totalFinal.ToString("0.00");
            btnCargarServicio.Visible = true;

        }

        private void btnCargarServicio_Click(object sender, EventArgs e)
        {
            try
            {
                
                    cnx = new SqlConnection(cadenaConexión);
                    SqlCommand cmd = new SqlCommand("sp_cargo", cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@orden", 0);
                    cmd.Parameters.AddWithValue("@idServicio", int.Parse(cmbIdServicio.Text));
                    cmd.Parameters.AddWithValue("@idReservacion", int.Parse(cmbIdReservacion.Text));
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@cantidad", int.Parse(txtCantidad.Text));
                    cmd.Parameters.AddWithValue("@total", totalFinal);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    MessageBox.Show("Cargo a Reservación Id. "+cmbIdReservacion.Text+"... ");
                    this.Close();


                
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a.Message);
            }
        }
    }
}
