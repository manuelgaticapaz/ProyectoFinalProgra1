using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    class AccesoDatos : Conexion
    {
        public int SqlCommand(string strSql)
        {
            SqlCommand sqlCmd = new SqlCommand();
            int Resultado = 0;

            sqlCmd.CommandText = strSql;
            sqlCmd.Connection = cn;

            try
            {
                Abrir_cn();
                sqlCmd.ExecuteNonQuery();
                Resultado = 1;
            }

            catch (Exception ex)
            {
                Resultado = 0;
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                Cerrar_cn();
                sqlCmd.Dispose();
            }

            return Resultado;


        }



        public DataTable ObtieneData(SqlCommand strSql)
        {
            SqlCommand sqlCmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                dt.Clear();
             //   sqlCmd.CommandText = strSql;
                sqlCmd.Connection = cn;
               // sqlCmd.CommandText = (@strSql);
                da.SelectCommand = strSql;
                da.Fill(dt);
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                Cerrar_cn();
                sqlCmd.Dispose();
            }
            return dt;
        }

    }
}
