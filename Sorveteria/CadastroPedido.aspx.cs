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
    public partial class CadastroPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CarregarCombo();
            }

        }
       
           
      
            private void ListarDados()
        {
            GDVPedido.DataSource = new Controller().SelectPedido();
            GDVPedido.DataBind();
        }


        private void CarregarCombo()
        {
            DropDownMesa.DataSource = new Controller().SelectMesa();
            DropDownMesa.DataValueField = "id";
            DropDownMesa.DataTextField = "id";
            DropDownMesa.DataBind();


            DropDownProduto.DataSource = new Controller().SelectProduto();
            DropDownProduto.DataValueField = "id";
            DropDownProduto.DataTextField = "nome";
            DropDownProduto.DataBind();
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            ListarDados();
            
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {

            String NomeCliente = textNomeCliente.Text;
           int numMesa = Convert.ToInt32(DropDownMesa.SelectedItem.Value);
            String prod = DropDownProduto.SelectedItem.Value;
           



            InsertBanco(NomeCliente, numMesa, prod);
            LBL.Text = "Dados registrados com sucesso!";
        }

        private void InsertBanco(String NomeCliente, int numMesa, String prod)
        {
                        
            Controller c = new Controller();
            Pedido pedido = new Pedido();
            pedido.NomeCliente= NomeCliente;
            pedido.idMesa = numMesa;
            pedido.NomeProduto = prod;
            
            c.InsertPedido(pedido);
        }
        
       
    }
}