<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="Ingrediente.aspx.cs" Inherits="Paginas_Ingrediente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
     <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">
    <asp:GridView ID="GridView1"  OnRowCommand="GridView1_RowCommand" runat="server" AutoGenerateColumns="false" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
           
        <Columns>
            <asp:BoundField DataField="ing_nome"  HeaderText="INGREDIENTE"/>
            <asp:BoundField DataField="ing_marca" HeaderText="MARCA" DataFormatString="" />
            <asp:BoundField DataField="ing_valorUnitario" ItemStyle-CssClass ="text-center font-weight-bold" ControlStyle-Font-Size="Large" HeaderText="VALOR UNITÁRIO" DataFormatString="{R$0:c2}" />
            <asp:BoundField DataField="ing_quantidade" ItemStyle-CssClass ="text-center font-weight-bold" ControlStyle-Font-Size="Large" HeaderText="QTD ESTOQUE (ml ou mg)" DataFormatString="{0:0ml/mg}" />
            
            <asp:BoundField DataField="porcentagem" HeaderText="%" ItemStyle-CssClass ="progress-bar progress-bar-striped progress-bar-animated" DataFormatString="{0:P}" />
           <%-- <asp:BoundField DataField="ing_quantidadeMax" HeaderText="INGREDIENTE" />  --%>
 <asp:TemplateField>
 <ItemTemplate>
 <asp:LinkButton ID="lbAlterar" CssClass="btn btn-warning" runat="server" CommandName="Alterar"
CommandArgument='<%# Bind("ing_id")%>'>Alterar</asp:LinkButton>
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
    <asp:Label ID="lbMensagem" runat="server" Text="Label"></asp:Label>
</asp:Content>

