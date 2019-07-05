using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace LawnTree.Clases
{
    class Conexion:DatosCustomer
    {
        //customer
        //insertar datos
        SqlConnection conectar;
        SqlCommand cmd = new SqlCommand();
        //visualizar datos
        SqlDataAdapter adapter;//tener acceso a la base de datos
        DataSet tabla; //comunica la base de datos con nuestro formulario
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

                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@Address_c", SqlDbType.VarChar, 200);
                cmd.Parameters.Add("@Phone", SqlDbType.Int);
                cmd.Parameters.Add("@Mail", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@PriceFirm", SqlDbType.Int);

                cmd.Parameters["@FirstName"].Value = FirstName;
                cmd.Parameters["@LastName"].Value = LastName;
                cmd.Parameters["@Address_c"].Value = Address_c;
                cmd.Parameters["@Phone"].Value = Phone;
                cmd.Parameters["@Mail"].Value = Mail;
                cmd.Parameters["@PriceFirm"].Value = PriceFirm;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos insertados");
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        public void visualizar(DataGrid data)
            
        {
            conectar = new SqlConnection();
            conectar.ConnectionString = conexion_string.string_conexion();

            try
            {
                conectar.Open();
                cmd.Connection = conectar;
                cmd.CommandText = "visualizar";

                adapter = new SqlDataAdapter(cmd);
                tabla = new DataSet();

                adapter.Fill(tabla);
                tabla.Tables[0].Columns.Remove(tabla.Tables[0].Columns[3]);
                tabla.Tables[0].Columns.Remove(tabla.Tables[0].Columns[3]);
                tabla.Tables[0].Columns.Remove(tabla.Tables[0].Columns[3]);
                
                data.ItemsSource = tabla.Tables[0].DefaultView;
                

            }
            catch (Exception ex)
            {

            }

        }




    }
}
