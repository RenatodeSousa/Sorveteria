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
    public partial class CadastroMesa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            String QtdLugar = textQtdLugar.Text;

            
           



            InsertBanco(QtdLugar );
            LBL.Text = "Dados registrados com sucesso!";
        }

        private void InsertBanco(String QtdLugar)
        {
            
            Controller c = new Controller();
            Mesa mesa = new Mesa();
            mesa.QtdLugar = QtdLugar;
            c.InsertMesa(mesa);
        }

        private void ListarDados()
        {
            GDVMesa.DataSource = new Controller().SelectMesa();
            GDVMesa.DataBind();
        }
        protected void BtnListar_Click(object sender, EventArgs e)
        {
            ListarDados();
            LBL.Text = "Dados carregados com sucesso!";
        }
    }
    }
