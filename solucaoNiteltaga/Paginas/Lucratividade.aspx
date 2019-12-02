<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="Lucratividade.aspx.cs" Inherits="Paginas_Lucratividade" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Lucratividade
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    
        <link href="../Content/bootstrap.min.css" rel="stylesheet" />
        <link href="../Content/style.css" rel="stylesheet" />
        <script src="../Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">
    <!-- Conteúdo aqui!! --><br />
    <div class="btn col-1">
    <asp:Button ID="Button1" CssClass="btn btn-dark" runat="server" Text="SAIR" OnClick="btnSair_Click" Height="30px" />
    
        </div><br />
    <div class="navbar-light bg-light">
    <a id="barra"> LUCROS</a>
        </div>
    <div class="row form-group"  id="base" aria-valuetext="100">
        <div class="card text-center col-12">
  <div class="card-header">
    <ul class="nav nav-tabs card-header-tabs">
      <li class="nav-item col-sm-4">
        <a class="nav-link active" href="#">ITENS VENDIDOS</a>
      </li>
    </ul>
  </div>
            <div class="col-12">
                <div class="col-12">
                <%--<asp:Chart ID="Chart1" runat="server" DataSourceID="ObjectDataSource1" Height="345px" Width="510px" AlternateText="Titulo do gráfico" Palette="Chocolate" PaletteCustomColors="255, 128, 0; Yellow; Red" RightToLeft="Yes">
                <Series>
                    <asp:Series Name="Series1"  XValueMember="car_nome" YValueMembers="custo" YValuesPerPoint="4" Legend="ITENS" LabelBorderDashStyle="DashDotDot" LegendMapAreaAttributes="1" LegendPostBackValue="2" LegendText="3" LegendToolTip="4" YValueType="Auto" ChartType="StackedBar"></asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1" AlignWithChartArea="NotSet">
                        <AxisY Title="CUSTO" ArrowStyle="SharpTriangle" InterlacedColor="Red">
                            <StripLines>
                                <asp:StripLine BackImageTransparentColor="Blue" />
                            </StripLines>
                        </AxisY>
                        <AxisX Title="Receitas">
                        </AxisX>
                    </asp:ChartArea>
                </ChartAreas>
                <Annotations>
                    <asp:LineAnnotation Name="LineAnnotation1">
                    </asp:LineAnnotation>
                </Annotations>
            </asp:Chart>--%>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="LucratividadeBD"></asp:ObjectDataSource>
            </div>
                <asp:DropDownList ID="ddlListaPedidos" runat="server">

                </asp:DropDownList>
                <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
                <%--<asp:GridView ID="GridView2" runat="server">

                </asp:GridView>--%>
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" CssClass="embed-responsive ml-auto">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />

                </asp:GridView>
                <asp:Label ID="custo" runat="server" Text="CUSTO:" Font-Bold="true"></asp:Label>
                <asp:Label ID="txtTotalCusto" runat="server" Text="Label"></asp:Label>
                
                

            </div>
            
            
  <%--<div class="card-body shadow">

            <br /><asp:Label ID="dataPedido" cssClass="navbar bg-light font-weight-bold " runat="server" Text="dataPedido">DATA PEDIDO:</asp:Label>
            <asp:TextBox ID="txtDataPedido"  cssClass="form-control"  runat="server" OnTextChanged="txtDataPedido_TextChanged" TextMode="Date" ValidateRequestMode="Enabled"></asp:TextBox>
            <asp:Label ID="dataEntrega" CssClass="navbar bg-light font-weight-bold" runat="server" Text="dataEntrega">DATA ENTREGA:</asp:Label>
            <asp:TextBox ID="txtDataEntrega" CssClass="form-control" runat="server" CausesValidation="True" TextMode="Date" ValidateRequestMode="Enabled"></asp:TextBox>
            <asp:Label ID="observacao" CssClass="navbar bg-light font-weight-bold" runat="server" Text="observacao">OBSERVAÇÃO:</asp:Label>
            <asp:TextBox ID="txtObservacao" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Label ID="valorTotal" CssClass="navbar bg-light font-weight-bold" runat="server" Text="valorTotal">VALOR TOTAL:</asp:Label>
            <asp:TextBox ID="txtValorTotal" CssClass="form-control" runat="server" Rows="0" ValidateRequestMode="Enabled" ViewStateMode="Enabled" BorderStyle="Solid" Font-Bold="True" SkinID="R$"></asp:TextBox>
      <br />
      <asp:Button ID="btnSalvar" CssClass="btn btn-primary" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
           
      <asp:Label ID="lblMensagem" cssClass="alert" runat="server" Text=""></asp:Label>
    
  </div>--%>

</div> 
        </div>  
    <div class="container">
        <div class="row">
            <div class="col-12">

            </div>
        </div>

    </div>
</asp:Content>

