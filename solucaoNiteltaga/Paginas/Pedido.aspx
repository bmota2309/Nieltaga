<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="Pedido.aspx.cs" Inherits="Paginas_Pedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
     NIELTAGA - PEDIDO
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
  
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="TituloPagina" Runat="Server">
    
            
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Contentbody" Runat="Server">
    
    <!-- Conteúdo aqui!! --><br />
    <div class="btn col-1">
    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="SAIR" OnClick="btnSair_Click" Height="30px" />
    
        </div><br /><div class="navbar-light bg-light">
    <a id="barra"> CADASTRO DE PEDIDOS</a>
        </div>
    <div class="row form-group"  id="base" aria-valuetext="100">
        <div class="card text-center col-12">
  <div class="card-header">
    <ul class="nav nav-tabs card-header-tabs">
      <li class="nav-item col-sm-4">
        <a class="nav-link active" href="#">FAZER PEDIDO</a>

      </li>
      <li class="nav-item col-sm-4">
        <a class="nav-link" href="PedidosRealizados.aspx"   >PEDIDOS REALIZADOS</a>
      </li>
      <li class="nav-item col-sm-4">
        <a class="nav-link  " href="PedidosEntregues.aspx">PEDIDOS ENTREGUES</a>
      </li>
    </ul>
  </div>
  <div class="card-body shadow">

            <br /><asp:Label ID="dataPedido" cssClass="navbar bg-light font-weight-bold " runat="server" Text="dataPedido">DATA PEDIDO:</asp:Label>
            <asp:TextBox ID="txtDataPedido"  cssClass="form-control"  runat="server" OnTextChanged="txtDataPedido_TextChanged" TextMode="Date" ValidateRequestMode="Enabled"></asp:TextBox>
            <asp:Label ID="dataEntrega" CssClass="navbar bg-light font-weight-bold" runat="server" Text="dataEntrega">DATA ENTREGA:</asp:Label>
            <asp:TextBox ID="txtDataEntrega" CssClass="form-control" runat="server" CausesValidation="True" TextMode="Date" ValidateRequestMode="Enabled"></asp:TextBox>
            <asp:Label ID="observacao" CssClass="navbar bg-light font-weight-bold" runat="server" Text="observacao">OBSERVAÇÃO:</asp:Label>
            <asp:TextBox ID="txtObservacao" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Label ID="valorTotal" CssClass="navbar bg-light font-weight-bold" runat="server" Text="valorTotal">VALOR TOTAL:</asp:Label>
            <asp:TextBox ID="txtValorTotal" CssClass="form-control" runat="server" Rows="0" ValidateRequestMode="Enabled" ViewStateMode="Enabled" BorderStyle="Solid" Font-Bold="True" SkinID="R$" Text="0"></asp:TextBox>
      <br />
      <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
           
      <asp:Label ID="lblMensagem" cssClass="alert" runat="server" Text=""></asp:Label>
    
  </div>

</div> 
        </div>  
        
<!--
            <asp:DropDownList ID="ddlCardapio" runat="server" OnSelectedIndexChanged="ddlCardapio_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

            <asp:Button ID="btnOK" runat="server" CssClass="btn btn-primary" Text="Inserir" OnClick="btnOK_Click" />

            <asp:GridView ID="gdvCardapio" CssClass="table table-hover table-success tabela" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="CESTA" DataField="car_nome" />
                </Columns>
            </asp:GridView>
                -->
       
</asp:Content>
