<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarIngrediente.aspx.cs" Inherits="Paginas_Alterar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Alteração de Ingredientes"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Marca:"></asp:Label>
        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Quantidade:"></asp:Label>
            <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="Valor Unitário:"></asp:Label>
        <asp:TextBox ID="txtvalorUnitario" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnSalvar" runat="server"  OnClick="btnSalvar_Click" OnClientClick="return confirm ('DESEJA ALTERAR?')" Text="Salvar" />
        </p>
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
    </form>
</body>
</html>
