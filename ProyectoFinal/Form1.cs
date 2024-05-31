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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void huespedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHuesped frmHuesped = new frmHuesped();
            frmHuesped.ShowDialog();
        }

        private void nuevoEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicio frmServicio = new frmServicio();
            frmServicio.ShowDialog();

        }


        private void promociónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmTipoDeDocumento frmTipoDeDocumento = new frmTipoDeDocumento();
            frmTipoDeDocumento.ShowDialog();
        }

        

        private void tiposDeHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitacion frmHabitacion = new frmHabitacion();
            frmHabitacion.ShowDialog();
        }

        private void reservacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReserva frmReserva  = new frmReserva();
            frmReserva.ShowDialog();
        }

        private void agregarEditarHabitaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHabitacionCatalogo frmHabitacionCatalogo = new frmHabitacionCatalogo();
            frmHabitacionCatalogo.ShowDialog();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheck frmCheck = new frmCheck();
            frmCheck.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargarServicio frmCargarServicio = new frmCargarServicio();
            frmCargarServicio.ShowDialog();
        }

        private void facturaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturacion frmFacturacion = new frmFacturacion();
            frmFacturacion.ShowDialog();
        }
    }
}
