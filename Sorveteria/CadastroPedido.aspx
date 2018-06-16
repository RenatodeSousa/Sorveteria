<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroPedido.aspx.cs" Inherits="Sorveteria.CadastroPedido" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <style>
  
        * {border: 1px solid double;  }
    </style>
    <title>Pedidos</title>
    <style type="text/css">
     
        
    .cab {
	font-size: 16px;
	color: #F39;
	text-align: center;
	font-weight: bold;
	font-family: "Times New Roman", Times, serif;
}
    .text {
	text-align: center;
	font-size: 18px;
	color: #F39;
	font-weight: bold;
}
    </style>
</head>
<body>

<form id="form1" runat="server">
        <div class="text">
       <br />Cadastro de Pedidos<br />
            <br />
   
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2"><span class="cab">Nome do Cliente</span></td>
                <td>
                    <asp:TextBox ID="textNomeCliente" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><span class="cab">Numero da Mesa</span></td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownMesa" runat="server"></asp:DropDownList>
                &nbsp;
                    </td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2"><span class="cab">Produto</span></td>
                <td>
                    <asp:DropDownList ID="DropDownProduto" runat="server"></asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td>
                    &nbsp;
                    <asp:Button ID="BtnSalvar" runat="server" Text="Salvar" OnClick="BtnSalvar_Click" style="height: 26px" />
                    
                &nbsp;&nbsp;
                    <asp:Button ID="BtnListar" runat="server" Text="Listar" OnClick="BtnListar_Click" />
                    &nbsp;&nbsp;
                    <asp:Button ID="BtnVoltar" runat="server" Text="Voltar" OnClick="BtnListar_Click" PostBackUrl="~/Index.aspx" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7" >
                    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;
                    </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="LBL" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GDVPedido" runat="server" Height="176px" Width="412px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
     </form>
</body>
</html>
