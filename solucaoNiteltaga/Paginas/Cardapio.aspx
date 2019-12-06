<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="Cardapio.aspx.cs" Inherits="Paginas_Cardapio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
        <link href="../Content/style.css" rel="stylesheet" />
        <script src="../Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">
    <div class="row">
        <div class="col-12">
            <!-- Conteúdo aqui!! -->
            <br />
    <div class="btn col-1">
    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="SAIR" OnClick="btnSair_Click" Height="30px" />
    
        </div><br />
    <div class="navbar-light bg-light">
    <a id="barra"> CARDAPIO</a>
        </div>
    <div class="row form-group"  id="base" aria-valuetext="100">
        <div class="card text-center col-12">
  <div class="card-header">
    <ul class="nav nav-tabs card-header-tabs">
      <li class="nav-item col-sm-4">
        <a class="nav-link active" href="#">CADASTRO</a>
      </li>
    </ul>
  </div>
            <div class="row text-monospace">
                <div class="col-6">
                    <p>
            <asp:Label ID="Label2" CssClass="text-right" runat="server" Text="NOME"></asp:Label>
            <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                    </p>
                </div>
                <div class="col-6">
                    <p>
                        <asp:Label ID="Label3" CssClass="text-left" runat="server" Text="VALOR UNITÁRIO"></asp:Label>
        <asp:TextBox ID="txtvalorUnitario" CssClass="form-control" runat="server"></asp:TextBox>
                    </p>
                    
                </div>
                <div class="col-6">
                    <p>
                        <asp:Label ID="Label1" runat="server" Text="EMBALAGEM"></asp:Label>
                    </p>
                    <p>
            <asp:DropDownList ID="ddlEmbalagem"  CssClass="form-control" runat="server">

            </asp:DropDownList>
        </p>
                </div>
                <div class="col-6">
                    <p>
                        <asp:Label ID="Label4" runat="server" Text="RECEITA"></asp:Label>
                    </p>
                    <p>
            <asp:DropDownList ID="ddlReceita"  CssClass="form-control" runat="server">

            </asp:DropDownList>
        </p>
                </div>
            </div>
            
        
        
        <p>
            <asp:Button ID="btnSalvar" CssClass="btn btn-group-lg btn-success" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
        </p>
        
        
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
        <div class="col-12 bg-light"><h3>LISTA DE CADÁPIO</h3></div>
        <div class="col-12 embed-responsive">
            <asp:GridView ID="GridView1" CssClass="col-12  table table-hover table-success tabela" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
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

