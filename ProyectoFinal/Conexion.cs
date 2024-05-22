using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Conexion
    {
        public static SqlConnection cn;


        public Conexion()
        {
            ////base joaquin
            cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Proyecto X;Data Source=DESKTOP-TAVF458\\SQLEXPRESS\r\n");
            //base Manuel
            //cn = new SqlConnection("Data Source=Kensi\\MSSQLSERVER01;Initial Catalog=proyectoP1;Integrated Security=True");
        }

        public void Abrir_cn()
        {
            try
            {
                if (cn.State == ConnectionState.Broken || cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Cerrar_cn()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}
