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
<body ID="BId">
    
    <form id="form1" runat="server">
        <!-- Login-->
        <div class="container shadow col-md-4" id="login" >
            <div class="inner fade-in-lightbox border border-dark bg-light">
                <div class="col text-center  " id="titulo">
                    <asp:Label ID="lblTitulo" runat="server"> <h1>Bomboniere Nieltaga</h1></asp:Label>
                </div>
                <div class="row" id="nome">
                    <div class="col-4 text-dark text-right">
                    <asp:Label ID="lblNome" runat="server"  Font-Bold="True" Text="NOME:"></asp:Label>
                </div>
                <div class="col-6 text-left" >
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                </div>

                <div class="row" id="cpf">
                    <div class="col-4 text-dark text-right">
                    <asp:Label ID="lblCpf" runat="server" Font-Bold="true" Text="CPF:"></asp:Label>
                </div>
                <div class="col-6 text-left" >
                    <asp:TextBox ID="txtCpf" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                    <div class="col-6 text-right">
                   <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>

                </div>
                    <div class="col-6 text-left">
                    <asp:Button ID="Button1" runat="server" Text="Entrar" OnClick="btnEntrar_Click" CssClass="btn btn-success"  />

                </div>
                </div>
                

            </div>
            
        </div>
        <div class="footer">
            <a>Bomboniere Nieltaga ® - Controle e gerenciamento</a>
        </div>


        
            </form>
</body>
</html>
