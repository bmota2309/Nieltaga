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
    <!--Menu aquí -->
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
      <asp:Label ID="titulo" runat="server" Text="Inclusão de Itens!" CssClass="badge-danger"></asp:Label>
      <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
          <Columns>
              <asp:BoundField ID="txtPedido" DataField="ped_id" HeaderText="PEDIDO" ControlStyle-CssClass="card-title" >
<ControlStyle CssClass="card-title bg-danger"></ControlStyle></asp:BoundField>
                  
                  <asp:BoundField DataField="itp_id" HeaderText="ITEM PEDIDO" ControlStyle-CssClass="card-title" >
<ControlStyle CssClass="card-title bg-secondary"></ControlStyle>
                    </asp:BoundField>
          </Columns>
      </asp:GridView>
      <br />
      <asp:Label ID="pedido" runat="server" Text="PEDIDO N:"></asp:Label>
      <asp:TextBox ID="txtPedido" runat="server"></asp:TextBox><br />
      <asp:Label ID="descricao" runat="server" Text="Descricao:"></asp:Label>
      <asp:TextBox ID="txtDescricao" runat="server"></asp:TextBox><br />
      <asp:Label ID="txtQuantidade" runat="server" Text="Quantidade:"></asp:Label>
      <asp:TextBox ID="quantidade" runat="server"></asp:TextBox>
      <asp:Button ID="btInserir" runat="server" Text="INSERIR" OnClick="btInserir_Click" />
      <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
      <!-- Fim do conteúdo -->
      <br />
      <%--<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Paginas/Pedido.aspx">VOLTAR</asp:LinkButton>--%>
  </div>
  <div class="card-body">

            
    
  </div>
            
            
</div> 

        </div>

       


</asp:Content>

