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
                
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="Select" TypeName="LucratividadeBD" UpdateMethod="Select">
                <SelectParameters>
                    <asp:SessionParameter DefaultValue="" Name="codigo" SessionField="ID" Type="Int32" />
                </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="codigo" Type="Int32" />
                </UpdateParameters>
                    </asp:ObjectDataSource>
            </div>
                <%--<div class="row">
                    <div class="col-6">
                    <asp:DropDownList ID="ddlListaPedidos" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
                <div class="col-6">
                    <asp:Button ID="Button2" runat="server" Text="BUSCAR" CssClass="text-left btn btn-lg btn-info" OnClick="Button2_Click" />
                </div>
                </div>--%>
                

                
                
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-outline-dark" NavigateUrl="~/Paginas/PedidosEntregues.aspx">VOLTAR AOS PEDIDOS ENTREGUES</asp:HyperLink>
                <div class="row">
                    <div class="col-6 card card-header bg-warning shadow text-right text-monospace">
                <H2>
                    RESUMO DO PEDIDO
                </H2>
                </div>
                <div class="col-6 bg-light shadow text-left">
                    <asp:Label ID="custo" runat="server"  Text="-*-*-*-*-CUSTO:" ForeColor="Teal" Font-Bold="true"></asp:Label>
                <asp:Label ID="txtTotalCusto" runat="server" Text=""></asp:Label>
                    <br />
                <asp:Label ID="venda" runat="server" Text="-*-*-*-*-PEDIDO:" ForeColor="Teal" Font-Bold="true"></asp:Label>
                <asp:Label ID="txtVenda" runat="server" Text=""></asp:Label>
                    <br />
                <asp:Label ID="lucro" runat="server" Text="-*-*-*-*-LUCRO:" ForeColor="Teal" Font-Bold="true"></asp:Label>
                <asp:Label ID="txtLucro" runat="server" Text=""></asp:Label>
                </div>
                </div>
                
                <div class="row">
                     <div class="col-6 shadow">
                    <asp:GridView ID="GridView1" AutoGenerateColumns="false" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                    <Columns>
                        <asp:BoundField DataField="CARDAPIO" HeaderText="CARDAPIO" ControlStyle-CssClass="card-header">
<ControlStyle CssClass="card-header"></ControlStyle>
                            </asp:BoundField>
                        <asp:BoundField DataField="INGREDIENTE" HeaderText="INGREDIENTE" ControlStyle-CssClass="card-header">
<ControlStyle CssClass="card-header"></ControlStyle>
                            </asp:BoundField>
                        <asp:BoundField DataField="QUANTIDADE" HeaderText="QUANTIDADE" ControlStyle-CssClass="card-header">
<ControlStyle CssClass="card-header"></ControlStyle>
                            </asp:BoundField>
                        <asp:BoundField DataField="CUSTO" HeaderText="CUSTO" ControlStyle-CssClass="card-header" DataFormatString="R$ {0:c2}">
<ControlStyle CssClass="card-header"></ControlStyle>
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
                </div>
                <div class="col-6 bg-white" >
                    <%--Grafico--%>
                    <asp:chart runat="server" ID="ctl00" BackImageTransparentColor="Red" CssClass="alert-danger" DataSourceID="ObjectDataSource1" EnableTheming="True" Width="514px" Height="281px" Palette="Chocolate"><Series><asp:Series Name="Series1" ChartType="Bar" XValueMember="INGREDIENTE" YValueMembers="CUSTO" LegendText="#TOTAL{C} #VAL{C}" YValuesPerPoint="2"></asp:Series></Series><ChartAreas><asp:ChartArea Name="ChartArea1" BackColor="White" BackGradientStyle="Center" BackHatchStyle="LargeCheckerBoard">
                        <AxisY Title="CUSTOS" TitleFont="Microsoft Sans Serif, 8pt, style=Italic">
                        </AxisY>
                        <AxisX Title="INGREDIENTES UTILIZADOS">
                        </AxisX>
                        </asp:ChartArea></ChartAreas>
                        <Annotations>
                            <asp:LineAnnotation Name="LineAnnotation1" ClipToChartArea="ChartArea1">
                            </asp:LineAnnotation>
                            <asp:Border3DAnnotation BorderSkin-PageColor="Transparent" BorderSkin-SkinStyle="Raised" LineColor="" Name="Border3DAnnotation1" Text="Border3DAnnotation1">
                            </asp:Border3DAnnotation>
                        </Annotations>
                    </asp:chart>

                </div>
                </div>
                
               
                
                
                <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>

                
                

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

