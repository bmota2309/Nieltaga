using solucaoNiteltaga.Persistencia;
using solucaoNiteltaga.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Paginas_PedidosRealizados : System.Web.UI.Page
{
    private void CarregaGrid(string termo)
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds;
        if (termo != "")
            ds = bd.Search(termo);
        else
            ds = bd.SelectAll();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
        int registros = ds.Tables[0].Rows.Count;
        if (registros == 0)
            lblMensagem.Text = "<h1 class='text-center alert alert-danger'> PEDIDO Nº " + termo + " NÃO ENCONTRADO<h1>";
        else
            lblMensagem.Text = "<h6 class='text-center alert alert-success'>FORAM ENCONTRADO(S) " + registros + " PEDIDO(S) </h6>";
    }
    private void Carrega()
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds = bd.SelectAll();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            Carrega();
        }
        if (!Page.IsPostBack)
        {
            CarregaGrid("");
        }
       
    }

    
    /* Altera ou exclui Pedido*/
    
    protected void btnSair_Click(object sender, EventArgs e)
    {
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }
    }
    
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int codigo = 0;
        switch (e.CommandName)
        {
            case "Alterar":
                codigo = Convert.ToInt32(e.CommandArgument);
                Session["ID"] = codigo;
                Response.Redirect("AlterarPedido.aspx");
                break;
            case "Deletar":
                codigo = Convert.ToInt32(e.CommandArgument);
                PedidoBD bd = new PedidoBD();
                bd.Delete(codigo);
                Carrega();
                break;
            case "Entregar":
                PedidoBD bde = new PedidoBD();
                Session["ID"] = codigo;
                Carrega();
                break;

            default:
                break;
        }
    }

    protected void btnPesquisa_Click(object sender, EventArgs e)
    {
        string termo = txtPesquisa.Text.Trim();
        if (termo != string.Empty)
        {
            CarregaGrid(termo);
        }
        else
        {
            CarregaGrid("");
            txtPesquisa.Focus();
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void lbEntrega(object sender, EventArgs e)
    {
        PedidoBD bd = new PedidoBD();
        Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));

        if (bd.Update(pedido))
        {
            lblMensagem.Text = " <p class='alert alert-success'>Funcionário alterado com sucesso</p>";
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}