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
        
        <div class="table-responsive">
        <asp:GridView ID="GridView1" CssClass="shadow table table-hover table-warning tabela" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="1011px">
                <Columns>
                    <asp:BoundField DataField="ped_id" HeaderText="PEDIDO" ControlStyle-CssClass="card-header">
<ControlStyle CssClass="card-header"></ControlStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ped_valorTotal" HeaderText="VALOR" ControlStyle-CssClass="card-title" DataFormatString="{0:c2}" >
<ControlStyle CssClass="card-title"></ControlStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ped_dataEntrega" HeaderText="DT.ENTREGA" ControlStyle-CssClass="card-text" DataFormatString="{0:D}" >
<ControlStyle CssClass="card-text"></ControlStyle>
                    </asp:BoundField>
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
            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
            </div>
        </div>

</asp:Content>