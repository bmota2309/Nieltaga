<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarIngrediente.aspx.cs" Inherits="Paginas_Cadastrar" %>

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
        <asp:Label runat="server" Text="Cadastro Ingredientes"></asp:Label>
        <p>
            <asp:Label ID="txNome" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" Width="143px"></asp:TextBox>
        </p>
        <asp:Label ID="txMarca" runat="server" Text="Marca"></asp:Label>
        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="txQuantidade" runat="server" Text="Quantidade"></asp:Label>
            <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="txvalorUnitario" runat="server" Text="Valor Unitario"></asp:Label>
        <asp:TextBox ID="txtvalorUnitario" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Quantidade Máxima:"></asp:Label>
            <asp:TextBox ID="txtquantidadeMax" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
        </p>
        <p>
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
