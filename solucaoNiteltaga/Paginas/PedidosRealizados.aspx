<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="PedidosRealizados.aspx.cs" Inherits="Paginas_PedidosRealizados" %>

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
        <a class="nav-link" href="Pedido.aspx">FAZER PEDIDO</a>

      </li>
      <li class="nav-item col-sm-4">
        <a class="nav-link active" href="PedidosRealizados.aspx">PEDIDOS REALIZADOS</a>
      </li>
      <li class="nav-item col-sm-4">
        <a class="nav-link " href="PedidosEntregues.aspx">PEDIDOS ENTREGUES</a>

      </li>
    </ul>
  </div>
  <div class="card-body">
   
      <asp:Label ID="txtobjcardapio" runat="server" Text=""></asp:Label>
      <asp:MultiView ID="MultiView1" runat="server"></asp:MultiView>
            
    
  </div>
            
        <asp:GridView  ID="GridView1" CssClass="col" runat="server" OnRowCommand="GridView1_RowCommand" PageSize="1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Dotted" BorderWidth="2px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            
            <Columns >
 <asp:TemplateField ControlStyle-CssClass="btn btn-info">
 <ItemTemplate>
 <asp:LinkButton  ID="lbAlterar" runat="server" CommandName="Alterar" 
CommandArgument='<%# Bind("PEDIDO")%>'>Alterar</asp:LinkButton>

 </ItemTemplate>

<ControlStyle CssClass="btn btn-info"></ControlStyle>
 </asp:TemplateField>
 <asp:TemplateField ControlStyle-CssClass="btn btn-danger">
 <ItemTemplate>
 <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar" OnClientClick="return confirm ('DESEJA EXCLUIR ESTE PEDIDO?')"
CommandArgument='<%# Bind("PEDIDO")%>'>Excluir</asp:LinkButton>
 </ItemTemplate>

<ControlStyle CssClass="btn btn-danger"></ControlStyle>
 </asp:TemplateField>
 </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
</div> 

        </div>

</asp:Content>

