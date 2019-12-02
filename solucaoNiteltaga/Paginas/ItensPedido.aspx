<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="ItensPedido.aspx.cs" Inherits="Paginas_ItensPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Itens Pedido
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/AdminLTE.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.0.0.min.js"></script>
    <script src="../Scripts/DataTables/jquery.dataTables.min.js"></script>
    <script src="../Scripts/DataTables/dataTables.buttons.min.js"></script>
    <script src="../Scripts/DataTables/buttons.flash.min.js"></script>
    <script src="../Scripts/DataTables/buttons.html5.min.js"></script>
    <script src="../Scripts/DataTables/buttons.print.min.js"></script>
    <script src="../Scripts/DataTables/buttons.colVis.min.js"></script>
    <script src="../Scripts/jszip.min.js"></script>
    <script src="../Scripts/pdfmake.min.js"></script>
    <script src="../Scripts/vfs_fonts.js"></script>

    <script src="../Scripts/projeto.js"></script>
    <script src="../Scripts/manipulacao.js"></script>
    <script src="../Scripts/JavaScript.js"></script>
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
      <div class="table-responsive">
          <div class="row">
              
      <div class="col-6 text-right">
          <asp:Label ID="pedido" runat="server"  Text="PEDIDO N:"></asp:Label>

      </div>
              <div class="col- text-left">
              
      <asp:TextBox ID="txtPedido" Enabled="false" Font-Size="Small" runat="server" Width="93px"></asp:TextBox><br />
          </div>
          </div>
          <div class="row">
              <div class="col-3 text-right text-right">
                  <asp:Label ID="slItem" runat="server" Text="Cadápio:"></asp:Label>
              </div>
              <div class="col-3 text-left">
                  <asp:DropDownList ID="ddlCardapio" runat="server">
      </asp:DropDownList>
              </div>
              <div class="col-3 text-right">
              
      <asp:Label ID="quantidade" runat="server" Text="Quantidade:"></asp:Label>

          </div>
              <div class="col-3 text-left">
              
      <asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
          </div>
          </div>
          <div class="row">

          </div>
          <div class="col-auto">
              
      <asp:Button ID="btInserir" runat="server" CssClass="btn btn-default" Text="INSERIR" OnClick="btInserir_Click" />
          </div>
          <div class="row">
              <div class="col-4">
          </div>
              <div class="col-4">
      <asp:Label ID="lblMensagem" CssClass="modal-default" runat="server"></asp:Label>
          </div>
              <div class="col-4">
              
          </div>
          </div>
          
      </div>
      <div class="col bg-white alert-dark shadow"> 
          <div  id="Grid" role="grid" aria-dropeffect="move">
          <asp:GridView ID="GridView1" OnRowCommand="GridView1_RowCommand" GridLines="Horizontal" BorderStyle="None" AutoGenerateColumns="False" runat="server" CssClass="table table-hover table-success tabela" BackColor="White" BorderColor="#CCCCCC" BorderWidth="1px" CellPadding="4" ForeColor="Black" >
              <Columns>

                  <asp:BoundField DataField="CARDAPIO" HeaderText="CARDAPIO" ItemStyle-CssClass="shadow font-weight-bold"/>
                  <asp:BoundField DataField="QTD" HeaderText="QTD" />
                  <asp:BoundField DataField="car_valorunitario" HeaderText="VALOR UNITÁRIO" DataFormatString="R$ {0:c2}" />
                  <asp:BoundField DataField="VALOR_TOTAL" HtmlEncodeFormatString="true" HeaderText="VALOR TOTAL" DataFormatString="R$ {0:c2}" />
                  <asp:TemplateField>
 <ItemTemplate>
 <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar" CssClass="btn btn-danger"  OnClientClick="return confirm ('DESEJA EXCLUIR ESTE ITEM?')"
CommandArgument='<%# Bind("itp_id")%>'>Excluir</asp:LinkButton>
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
              <asp:Label ID="lblTotal" runat="server" Text="Total:"></asp:Label>
              <asp:Label ID="txtTotal" runat="server" Text="" CssClass="callout-danger"  ></asp:Label>
              <br />
          <asp:Button ID="back" runat="server" Text="FINALIZAR" CssClass="btn btn-bitbucket" PostBackUrl="~/Paginas/PedidosRealizados.aspx"/>

          
      </div>
      </div>
      
        



      <!-- Fim do conteúdo -->
      <br />
      <%--<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Paginas/Pedido.aspx">VOLTAR</asp:LinkButton>--%>
  </div>
  <div class="card-body">

            
    <script src="../Scripts/projeto.js"></script>
  </div>
            
            
</div> 

        </div>

       


</asp:Content>

