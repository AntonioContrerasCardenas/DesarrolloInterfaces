using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ddl
{
    internal class Conexion
    {

        private string cadenaConexion = "Data Source=DAMX-YY; Initial Catalog=db.Sistema; Integrated Security=True; TrustServerCertificate=True";
        //private string cadenaConexion = "Data Source=Antonio\\SQLEXPRESS; Initial Catalog=db.Sistema; User ID=Antonio; Password=dam; TrustServerCertificate=True";

        SqlConnection sqlConnection;

        public SqlConnection EstablecerConexion()
        {
            try
            {
                sqlConnection = new SqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return sqlConnection;
        }

        public bool EjecutarComandoSinRetornarDatos(string strComando)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = EstablecerConexion();
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable EjecutarComandoRetornarDatos(string strComando)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = strComando;
                sqlCommand.Connection = EstablecerConexion();
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(strComando, sqlConnection);
                da.Fill(dt);
                sqlConnection.Close();

                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataSet EjecutarSentencia(SqlCommand sqlComando)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand = sqlComando;
                sqlCommand.Connection = EstablecerConexion();
                adapter.SelectCommand = sqlCommand;
                sqlConnection.Open();
                adapter.Fill(ds);
                sqlConnection.Close();
                return ds;

            }
            catch (Exception)
            {
                return ds;
                throw;
            }
        }
    }
}
