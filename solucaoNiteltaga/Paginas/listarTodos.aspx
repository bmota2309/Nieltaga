<%@ Page Language="C#" AutoEventWireup="true" CodeFile="listarTodos.aspx.cs" Inherits="Paginas_listarTodos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 100px">
            <i class="fa fa-home"></i>

            <asp:DropDownList ID="ddlCardapio" runat="server" OnSelectedIndexChanged="ddlCardapio_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

            <asp:Button ID="btnOK" runat="server" CssClass="btn btn-primary" Text="Inserir" OnClick="btnOK_Click" />

            <br />
            <br />

            <asp:GridView ID="gdvCardapio" CssClass="table table-hover table-success tabela" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="ITEM" DataField="car_nome" />
                </Columns>
            </asp:GridView>

            <br />

            <style>
                .azul {
                    color: blue;
                }

                .vermelho {
                    color: red;
                }
            </style>

            <i class="fa fa-thumbs-up fa-4x azul" id="joinha" estado="1"></i>
            <br />
            <asp:TextBox ID="txtPalavra" runat="server"></asp:TextBox>
            <a href="#" class="btn btn-success botao">Adicionar</a>

            <ul id="ullista" class="lista">
            </ul>
            <br />

            <a href="#" class="btn btn-warning varrer">Varrer</a>
            <p class="ler"></p>
        </div>
    </form>
</body>
</html>
