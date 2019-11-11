<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LisIngredientes.aspx.cs" Inherits="Paginas_Listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
       <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
 <Columns>
 <asp:TemplateField>
 <ItemTemplate>
 <asp:LinkButton ID="lbAlterar" runat="server" CommandName="Alterar"
CommandArgument='<%# Bind("fun_codigo")%>'>Alterar</asp:LinkButton>
 </ItemTemplate>
 </asp:TemplateField>
 <asp:TemplateField>
 <ItemTemplate>
 <asp:LinkButton ID="lbDeletar" runat="server" CommandName="Deletar"
CommandArgument='<%# Bind("fun_codigo")%>'>Excluir</asp:LinkButton>
 </ItemTemplate>
 </asp:TemplateField>
 </Columns>
 </asp:GridView> 
    </form>
    <a href="Cadastrar.aspx">Cadastrar.aspx</a>
</body>
</html>
