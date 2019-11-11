<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/style.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.min.js"></script>
        <script src="../Scripts/jquery-3.4.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" id="container">
            <div class="row" id="titulo">
                <div class="row col-md-12 "><asp:Label ID="lblTitulo" runat="server" Text=""> <h1>Bomboniere Nieltaga</h1></asp:Label></div> 
            </div>
            <div class="row" id="nome">    
                <div class="col-md-1 "><asp:Label ID="lblNome" runat="server" Font-Bold="True" Text="NOME:"></asp:Label></div> 
                <div class="col-md-11"><asp:TextBox ID="txtNome" runat="server" CssClass="form-control col-sm-3"></asp:TextBox></div> 
            </div>
            <div class="row" id="cpf">
                <div class="col-md-1"><asp:Label ID="lblCpf" runat="server" Font-Bold Text="CPF:"></asp:Label></div>
                <div class="col-md-11"><asp:TextBox ID="txtCpf" runat="server" CssClass="form-control col-sm-3" TextMode="Password"></asp:TextBox></div>
            </div>    
                <div class="col">
                    <asp:Button ID="btnEntrar" runat="server" Text="Entrar" OnClick="btnEntrar_Click" button type="button" CssClass="btn btn-success"  /> </div>
              
                <div>
                    <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
                </div> 
        </div> 
            
            
            </form>
</body>
</html>
