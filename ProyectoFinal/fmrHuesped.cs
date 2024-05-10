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
    public partial class frmHuesped : Form
    {
        public string strCat;
        AccesoDatos comando = new AccesoDatos();
        public frmHuesped()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Huesped huesped = new Huesped( txtIDHuesped.Text, txtNombres.Text, txtApellidos.Text, int.Parse(txtnumIdentificacionHuesped.Text), txtDireccion.Text, txtEmail.Text, int.Parse(txtTelefono.Text), txtTipodeHuesped.Text);
            strCat = "INSERT INTO [dbo].[HSD_HUESPED]\r\n           ([HSD_ID]\r\n           ,[HSD_NOMBRE]\r\n           ,[HSD_APELLIDO]\r\n           ,[HSD_NUMERO_IDENTIFICACION]\r\n           ,[HSD_DIRECCION]\r\n           ,[HSD_EMAIL]\r\n           ,[HSD_TELEFONO]\r\n           ,[HSD_TIPO_HUESPED])\r\n     VALUES\r\n           ( ";
            strCat = strCat + "'" + txtIDHuesped.Text + "', '" + txtNombres.Text + "', '"
+ txtApellidos.Text + "', "
+ int.Parse(txtnumIdentificacionHuesped.Text) + ", '"
+ txtDireccion.Text + "', '"
+ txtEmail.Text + "', "
+ int.Parse(txtTelefono.Text) + ", '"+ txtTipodeHuesped.Text + "') ";

            comando.SqlCommand(strCat);
        }

        private void frmHuesped_Load(object sender, EventArgs e)
        {

        }
    }
}
