<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="ProgressoEstoque.aspx.cs" Inherits="Paginas_ProgressoEstoque" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    NIELTAGA - ESTOQUE
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    
    <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">
    <div class="btn col-1">
        <br />
    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="SAIR" OnClick="btnSair_Click" Height="30px" />
            </div>
    <br />
    <div class="navbar-light bg-light">
    <a id="barra"> LISTA DE INGREDIENTES</a>
        </div>    

    <asp:GridView ID="GridView1" OnRowCommand="GridView1_RowCommand" CssClass="table table-hover table-success tabela" HorizontalAlign="Center" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
        <Columns>

            <asp:BoundField DataField="ing_nome"  HeaderText="INGREDIENTE"/>
            <asp:BoundField DataField="ing_marca" HeaderText="MARCA" DataFormatString="" />
            <asp:BoundField DataField="ing_valorUnitario" ItemStyle-CssClass ="text-center font-weight-bold" ControlStyle-Font-Size="Large" HeaderText="VALOR UNITÁRIO" DataFormatString="R$ {0:c2}" />
            <asp:BoundField DataField="ing_quantidade" ItemStyle-CssClass ="text-center font-weight-bold" ControlStyle-Font-Size="Large" HeaderText="QTD ESTOQUE (ml ou mg)" DataFormatString="{0:0ml/mg}" />
            
            <asp:BoundField DataField="porcentagem" HeaderText="%" ItemStyle-CssClass ="progress-bar progress-bar-striped progress-bar-animated" DataFormatString="{0:P}" />
         <asp:TemplateField>
 <ItemTemplate>
 <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar" CssClass="btn btn-warning"
CommandArgument='<%# Bind("ing_id")%>'>Alterar</asp:LinkButton>
 </ItemTemplate>
 </asp:TemplateField>
        </Columns>

        <FooterStyle BackColor="#CCCC99" ForeColor="Black" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White"  HorizontalAlign="Center"/>
        <SortedAscendingCellStyle BackColor="#F7F7F7" HorizontalAlign="Center" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B"  HorizontalAlign="Center"/>
        <SortedDescendingCellStyle BackColor="#E5E5E5" HorizontalAlign="Center"/>
        <SortedDescendingHeaderStyle BackColor="#242121" HorizontalAlign="Center" />
    </asp:GridView>
</asp:Content>

