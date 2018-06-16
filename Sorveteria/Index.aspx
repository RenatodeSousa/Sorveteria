<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Sorveteria.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Projeto Soveteria</title>
    <link href="wgrafael.css" rel="stylesheet" type="text/css" />
     <style>
   body{
    background-image: url(fundo.jpg);
}
     </style>
</head>
<body>
    <form id="form1" runat="server">
        <font size="20" class="text"> Páginas de Controle da Sorveteria</font>

<!-- MENU inicio -->
<div id="menu">

<!-- MENU com subcategoria inicio -->
<div class="btn" onclick="window.location='#'">Funcionário
	<ul>
    	<li onclick="window.location='CadastroDeFuncionario.aspx'">Cadastro</li>
        
    </ul>
</div><div class="separador"></div>

<div class="btn" onclick="window.location=''#'">Produto
	<ul>
    	<li onclick="window.location='CadastroProduto.aspx'">Cadastro</li>
       
  
    </ul>
</div><div class="separador"></div>

<div class="btn" onclick="window.location=''#'">Pedido
	<ul>
    	<li onclick="window.location='CadastroPedido.aspx'">Cadastro</li>
      
  
    </ul>
</div><div class="separador"></div>

<div class="btn" onclick="window.location=''#'">Mesa
	<ul>
    	<li onclick="window.location='CadastroMesa.aspx'">Cadastro</li>
      
  
    </ul>
</div><div class="separador"></div>


</div>
<p>&nbsp;</p>
<!-- MENU Fim -->
        <div>
        </div>
    </form>
</body>
</html>
