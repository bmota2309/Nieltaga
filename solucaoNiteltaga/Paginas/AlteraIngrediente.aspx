<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="AlteraIngrediente.aspx.cs" Inherits="Paginas_AlteraIngrediente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    
    <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">
    <div class="btn col-1">
        <br />
    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="SAIR" OnClick="btnSair_Click" Height="30px" />
            </div>
    <br />
    <div class="navbar-light bg-light">
    <a id="barra"> ALTERA INGREDIENTE</a>
        </div>

    <div class="row">
        <div class="col-6">
            <p>
            <asp:Label ID="Label2" CssClass="text-monospace" runat="server" Text="INGREDIENTE:"></asp:Label>
            <asp:TextBox ID="txtNome" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
        </p>
        </div>
        <div class="col-6">
            <p>
            <asp:Label ID="Label3" CssClass="text-monospace" runat="server" Text="MARCA:"></asp:Label>
        <asp:TextBox ID="txtMarca" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
        </p>
        </div>
        <div class="col-6">
            <p>
            <asp:Label ID="Label4" CssClass="text-monospace" runat="server" Text="QUANTIDADE:"></asp:Label>
        <asp:TextBox ID="txtQuantidade" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
        </p>
        </div>
        <div class="col-6">
            <p>
            <asp:Label ID="Label5" CssClass="text-monospace" runat="server" Text="VALOR:"></asp:Label>
        <asp:TextBox ID="txtvalorUnitario" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
        </p>
        </div>
        <div class="col-6">
            <p>
                <asp:Label ID="vlMax" CssClass="text-monospace" runat="server" Text="Unidade compra:"></asp:Label>
                <asp:TextBox ID="txtQtdMax" Enabled="false" CssClass="form-control form-control-sm" runat="server"></asp:TextBox>
            
        </p>
        </div>
        <asp:Button ID="btnSalvar" CssClass="btn btn-success" runat="server"  OnClick="btnSalvar_Click" OnClientClick="return confirm ('DESEJA ALTERAR?')" Text="Salvar" />

    </div>
            
      
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
</asp:Content>

