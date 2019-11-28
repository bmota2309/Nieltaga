<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="ProgressoEstoque.aspx.cs" Inherits="Paginas_ProgressoEstoque" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    
    <link href="../Content/style.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">
    <%--<div class="card-body">
                <table class="table table-bordered">
                  <thead>                  
                    <tr>
                      <th style="width: 10px">#</th>
                      <th>Task</th>
                      <th>Progress</th>
                      <th style="width: 40px">Label</th>
                    </tr>
                  </thead>
                  <tbody>
                    <tr>
                      <td>1.</td>
                      <td>Update software</td>
                      <td>
                        <div class="progress progress-xs">
                          <div class="progress-bar progress-bar-danger" style="width: 55%"></div>
                        </div>
                      </td>
                      <td><span class="badge bg-danger">55%</span></td>
                    </tr>
                    <tr>
                      <td>2.</td>
                      <td>Clean database</td>
                      <td>
                        <div class="progress progress-xs">
                          <div class="progress-bar bg-warning" style="width: 70%"></div>
                        </div>
                      </td>
                      <td><span class="badge bg-warning">70%</span></td>
                    </tr>
                    <tr>
                      <td>3.</td>
                      <td>Cron job running</td>
                      <td>
                        <div class="progress progress-xs progress-striped active">
                          <div class="progress-bar bg-primary" style="width: 30%"></div>
                        </div>
                      </td>
                      <td><span class="badge bg-primary">30%</span></td>
                    </tr>
                    <tr>
                      <td>4.</td>
                      <td>Fix and squish bugs</td>
                      <td>
                        <div class="progress progress-xs progress-striped active">
                          <div class="progress-bar bg-success" style="width: 90%"></div>
                        </div>
                      </td>
                      <td><span class="badge bg-success">90%</span></td>
                    </tr>
                  </tbody>
                </table>
              </div>--%>
    

    <asp:GridView ID="GridView1" CssClass="table table-hover table-success tabela" HorizontalAlign="Center" AutoGenerateColumns="False" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
        <Columns>

            <asp:BoundField DataField="ing_nome"  HeaderText="INGREDIENTE"/>
            <asp:BoundField DataField="ing_marca" HeaderText="MARCA" DataFormatString="" />
            <asp:BoundField DataField="ing_quantidade" ItemStyle-CssClass ="text-center font-weight-bold" ControlStyle-Font-Size="Large" HeaderText="QTD ESTOQUE (ml ou mg)" DataFormatString="{0:0ml/mg}"  >
            
            </asp:BoundField>
            <asp:BoundField DataField="porcentagem" HeaderText="%" ItemStyle-CssClass ="progress-bar progress-bar-striped progress-bar-animated" DataFormatString="{0:P1}" />
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

