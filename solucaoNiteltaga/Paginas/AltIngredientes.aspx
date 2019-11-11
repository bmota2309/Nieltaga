<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AltIngredientes.aspx.cs" Inherits="Paginas_Cadastrar" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class=""><label>Alteração de Ingredientes</label></div>
        <div class=""><label>Nome:<asp:TextBox ID="txtNome" runat="server"></asp:TextBox> </label></div>
        <div class=""><label>Marca:<asp:TextBox ID="txtMarca" runat="server"></asp:TextBox> </label></div>
        <div class=""><label>Quantidade:<asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox> </label></div>
        <div class=""><label>Valor Unitário: <asp:TextBox ID="txtValorUnit" runat="server"></asp:TextBox></label></div>
        <div>
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
        </div>
        <asp:Label ID="lblMensagem" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>