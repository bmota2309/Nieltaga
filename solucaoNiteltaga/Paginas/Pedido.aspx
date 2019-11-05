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
    <div class="row col-12"  id="base">
        <div class="col-md-4" id="bloco1">
            <div class="row col-4" ><a>hello</a> </div>
        </div>
        <div class="col-md-4" id="centro">
            <div class="row col-4">
                <a>Heloo</a>
            </div>
        </div>
        <div class="col-md-4" id="bloco2">
            <div class="row col-md-4">
            <asp:Label ID="lblMensagem" runat="server" Text="">Sucesso</asp:Label>
            <asp:Label ID="cardapio" runat="server" CssClass="form-control" Text="cardapio"></asp:Label>
            <asp:DropDownList ID="txtCardapio" CssClass="form-control" runat="server">
            </asp:DropDownList>
            <br /><asp:Label ID="quantidade" CssClass="input-group-text" runat="server" Text="quantidade">Quantidade mg/ml:</asp:Label>
            <asp:TextBox ID="txtQuantidade" cssClass="form-control" runat="server"></asp:TextBox>
            <br /><asp:Label ID="dataPedido" CssClass="input-group-text" runat="server" Text="dataPedido">Data pedido:</asp:Label>
            <asp:TextBox ID="txtDataPedido"  cssClass="form-control"  runat="server" OnTextChanged="txtDataPedido_TextChanged"></asp:TextBox>
            <asp:Button ID="btnSalvar" CssClass="btn btn-light" runat="server" Text="Salvar" />
            </div>
     </div>
   </div>
</asp:Content>
