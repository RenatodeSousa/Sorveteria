using Entidade;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDB
{
    public class Controller
    {
        SqlConnection con;
        
        public Controller()
        {
            con = new SqlConnection
            (ConfigurationManager.ConnectionStrings["SQLSERVER"].ConnectionString);
        }

        public bool InsertFuncionario(Funcionario funcionario)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PR_INSERIR_FUNCIONARIO";
            cmd.Parameters.Add(new SqlParameter("@Nome", funcionario.Nome));
            cmd.Parameters.Add(new SqlParameter("@Endereco", funcionario.Endereco));
            cmd.Parameters.Add(new SqlParameter("@Cargo", funcionario.Cargo));
            cmd.Parameters.Add(new SqlParameter("@Login", funcionario.Login));
            cmd.Parameters.Add(new SqlParameter("@Senha", funcionario.Senha));
            
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }

        

        public bool InsertProduto(Produto produto)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PR_INSERIR_PRODUTO";
            cmd.Parameters.Add(new SqlParameter("@Nome", produto.Nome));
            cmd.Parameters.Add(new SqlParameter("@Sabor", produto.Sabor));
            cmd.Parameters.Add(new SqlParameter("@Valor", produto.Valor));
            
            

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }


        public bool InsertPedido(Pedido pedido)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PR_INSERIR_PEDIDO";
            cmd.Parameters.Add(new SqlParameter("@NOMECLIENTE", pedido.NomeCliente));
            cmd.Parameters.Add(new SqlParameter("@IDMESA", pedido.idMesa));
            cmd.Parameters.Add(new SqlParameter("@NOMEPRODUTO", pedido.NomeProduto));
           



            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }




        public bool InsertMesa(Mesa mesa)
        {

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PR_INSERIR_MESA";
            cmd.Parameters.Add(new SqlParameter("@QtdLugar", mesa.QtdLugar));



            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            return true;

        }

        public DataTable SelectMesa()
       {

            DataTable dt = new DataTable();
           SqlCommand scomand = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
           con.Open();

            scomand = new SqlCommand("PR_CONSULTAR_MESA", con);
            scomand.CommandType = CommandType.StoredProcedure;

            ad.SelectCommand = scomand;
            ad.Fill(dt);
            con.Close();
return dt;

        }
        public DataTable SelectProduto()
        {

            DataTable dt = new DataTable();
            SqlCommand scomand = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            con.Open();

            scomand = new SqlCommand("PR_CONSULTAR_PRODUTO", con);
            scomand.CommandType = CommandType.StoredProcedure;

            ad.SelectCommand = scomand;
            ad.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable SelectPedido()
        {

            DataTable dt = new DataTable();
            SqlCommand scomand = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            con.Open();

            scomand = new SqlCommand("PR_CONSULTAR_PEDIDO", con);
            scomand.CommandType = CommandType.StoredProcedure;

            ad.SelectCommand = scomand;
            ad.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable SelectFuncionario()
        {

            DataTable dt = new DataTable();
            SqlCommand scomand = new SqlCommand();
            SqlDataAdapter ad = new SqlDataAdapter();
            con.Open();

            scomand = new SqlCommand("PR_CONSULTAR_FUNCIONARIO", con);
            scomand.CommandType = CommandType.StoredProcedure;

            ad.SelectCommand = scomand;
            ad.Fill(dt);
            con.Close();
            return dt;

        }

       
    }

}

