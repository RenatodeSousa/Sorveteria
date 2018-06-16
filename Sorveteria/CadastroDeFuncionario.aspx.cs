using controleDB;
using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sorveteria
{
    public partial class CadastroDeFuncionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            String Nome = textNomeFuncionario.Text;

            String Endereco = textEnderecoFuncionario.Text;
            String Cargo = textCargoFuncionario.Text;
            String Login = textLoginFuncionario.Text;
            String Senha = textSenhaFuncionario.Text;
           
            InsertBanco(Nome, Endereco, Cargo,Login,Senha);
            LBL.Text = "Dados registrados com sucesso!";
        }

        private void InsertBanco(String Nome, String Endereco, String Cargo, String Login, String Senha)
        {



            Controller c = new Controller();
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = Nome;
            funcionario.Endereco= Endereco;
            funcionario.Cargo = Cargo;
            funcionario.Login = Login;
            funcionario.Senha = Senha;
            c.InsertFuncionario(funcionario);
        }


        private void ListarDados()
        {
            GDVFuncionario.DataSource = new Controller().SelectFuncionario();
            GDVFuncionario.DataBind();
        }
        protected void BtnListar_Click(object sender, EventArgs e)
        {
            ListarDados();
            LBL.Text = "Dados carregados com sucesso!";
        }

        protected void GDVFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnVoltar_Click(object sender, EventArgs e)
        {
           
        }
    }
    }
