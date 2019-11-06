<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="Pedido.aspx.cs" Inherits="Paginas_Pedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
     Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
  
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TituloPagina" Runat="Server">
    <div class="row col-md-12">
            <div class="col-md-12"  id="titulo">
        <a id="barra"> CADASTRO DE PEDIDOS</a>
            </div>
        </div>
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contentbody" Runat="Server">

    <!-- Conteúdo aqui!! -->
    <div class="row form-group"  id="base">
        <div class="col-md-4" id="bloco1">
            <div class="row bg-info" >
                <h3>&nbsp;&nbsp;&nbsp;PEDIDOS ENTREGUES</h3>
            </div>
        </div>
        <div class="col-md-4" id="centro">
            <div class="row  bg-info">
            <h3>&nbsp;&nbsp;&nbsp;PEDIDOS REALIZADOS</h3>
        </div>
            <!--Lista de peidos aquí -->
            <a>Pedido 1</a>
        </div>
        <div class="col-md-4" id="bloco2">
            <div class="row bg-info">
                <h3>&nbsp;&nbsp;&nbsp&nbsp;&nbsp;FAZER PEDIDO</h3>
            </div>
            <br /><asp:Label ID="dataPedido" cssClass="navbar bg-dark" runat="server" Text="dataPedido">Data pedido:</asp:Label>
            <asp:TextBox ID="txtDataPedido"  cssClass="form-control"  runat="server" OnTextChanged="txtDataPedido_TextChanged" TextMode="Date"></asp:TextBox>
            <asp:Label ID="dataEntrega" CssClass="navbar bg-dark" runat="server" Text="dataEntrega">Data Entrega:</asp:Label>
            <asp:TextBox ID="txtDataEntrega" CssClass="form-control" runat="server" CausesValidation="True" TextMode="Date"></asp:TextBox>
            <asp:Label ID="observacao" CssClass="navbar bg-dark" runat="server" Text="observacao">Observação:</asp:Label>
            <asp:TextBox ID="txtObservacao" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Label ID="valorTotal" CssClass="navbar bg-dark" runat="server" Text="valorTotal">Valor Total:</asp:Label>
            <asp:TextBox ID="txtValorTotal" CssClass="form-control" runat="server" TextMode="Number" Rows="1"></asp:TextBox>
            <asp:Button ID="btnSalvar" CssClass="btn btn-dark" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
           <asp:Label ID="lblMensagem" cssClass="alert" runat="server" Text=""></asp:Label>
     </div>
   </div>
</asp:Content>
