using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDB
{
     public class ConnectionSQLServer
    {


private SqlConnection con;

        public SqlConnection getConnectionSqlServer()
        {

            string _conexao = ConfigurationManager.ConnectionStrings["SQLSERVER"].ConnectionString;
            con = new SqlConnection();
            con.ConnectionString = _conexao;
            con.Open();
            return con;

        }
       
        //public SqlDataReader ExecutarRetorno(string query)
        //{

            
        //    var cmd = new SqlCommand(query, con);
        //    return cmd.ExecuteReader();
        //}
        //public void Dispose()
        //{
         
        //   if (con.State == System.Data.ConnectionState.Open)
        //  {
                
        //       con.Close();
        //    }
        //}

    }
}

