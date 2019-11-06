<%@ Page Title="" Language="C#" MasterPageFile="~/Paginas/MasterPage.master" AutoEventWireup="true" CodeFile="Itens.aspx.cs" Inherits="Paginas_Itens" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TituloPagina" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="Contentbody" Runat="Server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
<button id="btAbrirModal">Abrir Modal</button>
<div id="modal" class="hide">
    <div class="modal-bg"></div>
    <div class="modal-content">
        <h3>Hello World</h3>
        <a class="modal-close">&#215;</a>
    </div>
</div>
</asp:Content>

