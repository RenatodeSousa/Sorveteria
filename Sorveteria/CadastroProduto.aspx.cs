using controleDB;
using System;
using Entidade;

namespace Sorveteria
{
    public partial class CadastroProduto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            String Nome = textNomeProduto.Text;
             
            String Sabor = textSaborProduto.Text;
           Decimal   Valor = Convert.ToDecimal(textValorProduto.Text);
            
              

            InsertBanco(Nome, Sabor, Valor);
            LBL.Text = "Dados registrados com sucesso!";
        }

        private void InsertBanco(String Nome, String Sabor, Decimal Valor)
        {
                        


            Controller c = new Controller();
            Produto produto= new Produto();
            produto.Nome = Nome;
            produto.Sabor = Sabor;
            produto.Valor = Valor;
            c.InsertProduto(produto);
        }
        private void ListarDados()
        {
            GDVProduto.DataSource = new Controller().SelectProduto();
            GDVProduto.DataBind();
        }
        protected void BtnListar_Click(object sender, EventArgs e)
        {
            ListarDados();
            LBL.Text = "Dados carregados com sucesso!";
        }

        protected void textValorProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
