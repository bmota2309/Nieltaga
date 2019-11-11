<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="Receitas.aspx.cs" Inherits="Paginas_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet"/>
    <link href="../Content/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contentbody" Runat="Server">
    
   <div class="row form-group"  id="base">
        
            <!--Lista de peidos aquí -->
       
       <asp:Label ID="quantidade" CssClass="navbar bg-dark" runat="server" Text="quantidade">Quantidade:</asp:Label>
       <asp:TextBox ID="txtQuantidade" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
       <asp:Label ID="ingrediente" CssClass="navbar bg-dark" runat="server" Text="ingrediente">Valor:</asp:Label>
       <asp:TextBox ID="txtIngrediente" CssClass="form-control" runat="server" TextMode="Number" Rows="1"></asp:TextBox>
       <asp:Button ID="btnSalvar" CssClass="btn btn-dark" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
       <asp:Label ID="lblMensagem" CssClass="alert" runat="server" Text=""></asp:Label>
     </div>
 
</asp:Content>

