using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace LawnTree.Clases
{
    class Conexion
    {
        SqlConnection conectar;
        SqlCommand cmd = new SqlCommand();

        public void insertar()
        {
            conectar = new SqlConnection();
            conectar.ConnectionString = conexion_string.string_conexion();
            try
            { 
                conectar.Open();
                cmd.Connection = conectar;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insertar";

                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar,50);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }
    }
}
