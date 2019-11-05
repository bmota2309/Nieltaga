<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Paginas/MasterPage.master" CodeFile="Pedidos.aspx.cs" Inherits="Paginas_Pedidos" %>

<!DOCTYPE html public "">


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- Incluindo o CSS do Bootstrap -->
    
</head>
    
<body>
    <asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
        Home
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
        
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    </asp:Content>
    <asp:Content ID="Content3" ContentPlaceHolderID="o=Contentbody" runat="server">
        Home
    </asp:Content>
    
            <!-- <asp:Label ID="cadastraPedido" runat="server" Text="Label">Cadastro de pedido.</asp:Label>
   <br /><asp:Label ID="itemPedido" runat="server" Text="Label">Item Pedido:</asp:Label>
   <asp:DropDownList ID="txtItemPedido" runat="server"></asp:DropDownList>
    <br /><asp:Label ID="dataPedido" runat="server" Text="Label">Data pedido:</asp:Label>
    <asp:TextBox ID="txtDataPedido" runat="server"></asp:TextBox>
    <br /><asp:Label ID="dataEntrega" runat="server" Text="Label">Data Entrega:</asp:Label>
    <asp:TextBox ID="txtDataEntrega" runat="server"></asp:TextBox>
    <br /><asp:Label ID="quantidade" runat="server" Text="Label">Quantidade:</asp:Label>
    <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
    <br /><asp:Button ID="salvar" runat="server" Text="Salvar" />
        -->
</body>
</html>
