﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_ProgressoEstoque : System.Web.UI.Page
{
    private void Carrega()
    {
        ProgressoEstoqueBD bd = new ProgressoEstoqueBD();
        //ProgressoEstoque pedido = bd.SelectAll(Convert.ToInt32(Session["ID"]));

        //txtPedido.Text = pedido.Codigo.ToString();

        //CardapioBD cardapioBD = new CardapioBD();
        DataSet ds = bd.SelectAll();
        //ddlCardapio.DataSource = ds.Tables[0].DefaultView;

        //ddlCardapio.DataTextField = "car_nome";
        //ddlCardapio.DataValueField = "car_id";
        //ddlCardapio.DataBind();
        //ddlCardapio.Items.Insert(0, "Selecione");
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();

    }
    protected void Page_Load(object sender, EventArgs e)
    {

        Carrega();

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        int codigo = 0;
        switch (e.CommandName)
        {
            case "Alterar":
                codigo = Convert.ToInt32(e.CommandArgument);
                Session["ID"] = codigo;
                Response.Redirect("AlteraIngrediente.aspx");
                break;
            //case "Deletar":
            //    codigo = Convert.ToInt32(e.CommandArgument);
            //    IngredientesBD bd = new IngredientesBD();
            //    bd.Delete(codigo);
            //    Carrega();
            //    break;
            default:
                break;
        }
    }

    protected void btnSair_Click(object sender, EventArgs e)
    {
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }
    }
}
