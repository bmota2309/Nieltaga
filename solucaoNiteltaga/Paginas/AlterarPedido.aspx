<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="AlterarPedido.aspx.cs" Inherits="Paginas_AlterarPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Alteração de pedidos.
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">

            <br /><asp:Label ID="dataPedido" cssClass="navbar bg-light font-weight-bold" runat="server" Text="dataPedido">DATA PEDIDO:</asp:Label>
            <asp:TextBox ID="txtDataPedido"  cssClass="form-control"  runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="dataEntrega" CssClass="navbar bg-light font-weight-bold" runat="server" Text="dataEntrega">DATA ENTREGA:</asp:Label>
            <asp:TextBox ID="txtDataEntrega" CssClass="form-control" runat="server" CausesValidation="True" TextMode="Date"></asp:TextBox>
            <asp:Label ID="observacao" CssClass="navbar bg-light font-weight-bold" runat="server" Text="observacao">OBSERVAÇÃO:</asp:Label>
            <asp:TextBox ID="txtObservacao" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Label ID="valorTotal" CssClass="navbar bg-light font-weight-bold" runat="server" Text="valorTotal">VALOR TOTAL:</asp:Label>
            <asp:TextBox ID="txtValorTotal" CssClass="form-control" runat="server" TextMode="Number" Rows="1"></asp:TextBox>
            <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
           <asp:Label ID="lblMensagem" cssClass="alert" runat="server" Text=""></asp:Label>
      
</asp:Content>

