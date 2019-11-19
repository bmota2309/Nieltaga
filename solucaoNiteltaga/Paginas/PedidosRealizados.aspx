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

    <div class="btn col-1">
        <br />
    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="SAIR" OnClick="btnSair_Click" Height="30px" />
            </div>
    <br />
    <div class="navbar-light bg-light">
    <a id="barra"> LISTA DE PEDIDOS</a>
        </div>
    <div class="row form-group"  id="base">
        <div class="card text-center col-12">
  <div class="card-header ">
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
            <div class="card-body shadow col-12">
                <div class="row">
                    <div class="col-4 text-right form-text shadow bg-light">
                        <asp:Label ID="lblDigite" CssClass="active h6" runat="server" Text="PESQUISAR PEDIDO:"></asp:Label>
                    </div>
                    <div class="col-4 text-right m-0">
                        <asp:TextBox ID="txtPesquisa" CssClass="form-control form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="col-4 text-left">
                        <asp:Button ID="btnPesquisa" CssClass="btn btn-dark" runat="server" Text="PESQUISAR" OnClick="btnPesquisa_Click" />
                    </div>
                    <div class="col-12">
                        <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <asp:GridView  ID="GridView1" AutoGenerateColumns="false" CssClass="col-12 shadow" runat="server" OnRowCommand="GridView1_RowCommand" PageSize="1" BackColor="White" BorderColor="#CCCCCC" BorderStyle="Dotted" BorderWidth="2px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
              
                  <Columns>
               <asp:BoundField DataField="PEDIDO" HeaderText="PEDIDO" />
               <asp:BoundField DataField="DT.PEDIDO" HeaderText="DATA PEDIDO" DataFormatString="{0:d}" />
               <asp:BoundField DataField="DT.ENTREGA" HeaderText="DATA ENTREGA" DataFormatString="{0:d}" />
               <asp:BoundField DataField="OBSERVAÇÃO" HeaderText="OBSERVAÇÃO"/>
               <asp:BoundField DataField="R$" HeaderText="R$"/>
                  </Columns>
                     
            <Columns>
           
                    
 <asp:TemplateField ControlStyle-CssClass="btn btn-info">
 <ItemTemplate>
 <asp:LinkButton  ID="lbAlterar" runat="server" CommandName="AdcItem" 
PostBackUrl="~/Paginas/ItensPedido.aspx">+Adicionar Itens</asp:LinkButton>

 </ItemTemplate>

<ControlStyle CssClass="btn btn-info"></ControlStyle>
 </asp:TemplateField>
 <asp:TemplateField ControlStyle-CssClass="btn btn-danger">
 <ItemTemplate>
 <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar"  OnClientClick="return confirm ('DESEJA EXCLUIR ESTE PEDIDO?')"
CommandArgument='<%# Bind("PEDIDO")%>'>Excluir</asp:LinkButton>
 </ItemTemplate>
 </asp:TemplateField>
 <asp:TemplateField ControlStyle-CssClass="btn btn-warning">
 <ItemTemplate>
 <asp:LinkButton ID="lbEntrega" runat="server" CommandName="Entregar" OnClick="lbEntrega" OnClientClick="return confirm ('DESEJA ENTREGAR ESTE PEDIDO?')"
CommandArgument='<%# Bind("PEDIDO")%>'>Entregar</asp:LinkButton>
 </ItemTemplate>
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

        </div>

</asp:Content>

