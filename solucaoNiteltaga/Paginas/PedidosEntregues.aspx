<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="PedidosEntregues.aspx.cs" Inherits="Paginas_PedidosEntregues" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">
    <!-- conteúdo aqui -->
    <div class="btn col-1">
        <br />
    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="SAIR" OnClick="btnSair_Click" Height="30px" />
            </div>
    <br />
    <div class="navbar-light bg-light">
    <a id="barra">PEDIDOS ENTREGUES</a>
        </div>
    <div class="row form-group"  id="base">
        <div class="card text-center col-12">
  <div class="card-header">
    <ul class="nav nav-tabs card-header-tabs">
      <li class="nav-item col-sm-4">
        <a class="nav-link" href="Pedido.aspx">FAZER PEDIDO</a>

      </li>
      <li class="nav-item col-sm-4">
        <a class="nav-link  " href="PedidosRealizados.aspx"   >PEDIDOS REALIZADOS</a>
      </li>
      <li class="nav-item col-sm-4">
        <a class="nav-link active" href="PedidosEntregues.aspx">PEDIDOS ENTREGUES</a>
      </li>
        <br />
        <br />
        <!-- CARD -->
        <div class="card text-white bg-success mb-3" style="max-width: 18rem;">
  <div class="card-header">PEDIDO Nº001</div>
  <div class="card-body">
    <h5 class="card-title">Valor R$150,00</h5>
    <p class="card-text">Entregue dia: 06/11/2019</p>
  </div>
</div>   <a class="toast" role="alert">---- </a>
        <div class=" card text-white bg-success mb-3" style="max-width: 18rem;">
  <div class="card-header ">PEDIDO Nº002</div>
  <div class="card-body">
      
    <h5 class="card-title ">Valor R$110,00</h5>
    <p class="card-text">Entregue dia: 06/11/2019</p>
  </div>
</div>  <a class="toast" role="alert">---- </a>
        <div class="card text-white bg-success mb-3" style="max-width: 18rem;">
  <div class="card-header">PEDIDO Nº003</div>
  <div class="card-body">
    <h5 class="card-title">Valor R$202,00</h5>
    <p class="card-text">Entregue dia: 06/11/2019</p>
  </div>
</div>   
        <a class="toast" role="alert">---- </a>
        <div class=" card text-white bg-success mb-3" style="max-width: 18rem;">
  <div class="card-header ">PEDIDO Nº004</div>
  <div class="card-body">
      
    <h5 class="card-title ">Valor R$80,00</h5>
    <p class="card-text">Entregue dia: 06/11/2019</p>
  </div>
</div>  
        

    </ul>
  
  <div class="card-body">
   
      <asp:Label ID="txtobjcardapio" runat="server" Text=""></asp:Label>
      <asp:MultiView ID="MultiView1" runat="server"></asp:MultiView>
            
    
  </div>
</div> 
        </div>

</asp:Content>

