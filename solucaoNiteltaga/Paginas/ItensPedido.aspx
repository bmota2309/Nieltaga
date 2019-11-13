<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="ItensPedido.aspx.cs" Inherits="Paginas_ItensPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Itens Pedido
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">
    <!--Conteúdo aquí -->
    <div class="btn     col-1">
        <br />
    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="SAIR" OnClick="btnSair_Click" Height="30px" />
            </div>
    <br />
    <div class="navbar-light bg-light">
    <a id="barra"> LISTA DE PEDIDOS</a>
        </div>
    <div class="row form-group"  id="base">
        <div class="card text-center col-12">
  <div class="card-header">
    <ul class="nav nav-tabs card-header-tabs">
      <li class="nav-item col-sm-4">
        <a class="nav-link active" >CARDÁPIO</a>
       </li>
        
    </ul>
      <!-- Conteudo aqui-->
     

      <!-- Fim do conteúdo -->
      <br />
      <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Paginas/Pedido.aspx">VOLTAR</asp:LinkButton>
  </div>
  <div class="card-body">

            
    
  </div>
            
            
</div> 

        </div>

       


</asp:Content>

