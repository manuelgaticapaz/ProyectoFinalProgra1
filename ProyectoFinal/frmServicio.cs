using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmServicio : Form
    {
        public string StrCat;
        AccesoDatos comando = new AccesoDatos();
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
            StrCat = "INSERT INTO [dbo].[SVC_SERVICIO]\r\n           ([SVC_ID]\r\n           ,[SVC_DESCRIPCION]\r\n           ,[SVC_VALOR]\r\n           ,[SVC_HORA_INICIO]\r\n           ,[SVC_HORA_FINAL]\r\n           ,[SVC_DISPONIBILIDAD]\r\n           ,[SVC_RESERVAS]\r\n ) values(";
            StrCat = StrCat + "'" + txtIDServicios.Text + "', '" + txtDescripcion.Text + "', " + double.Parse(txtCosto.Text) + ", '" + txtHoraInicio.Text + "', '" + txtHoraFinal.Text + "', '" + Convert.ToBoolean(int.Parse(txtDisponibilidad.Text)) + "',  '" + Convert.ToBoolean(int.Parse(txtReservas.Text)) + "') ";
            comando.SqlCommand(StrCat);
        }
        private void frmServicio_Loadobject (object sender, EventArgs e)
        {

        }
    }
}
