using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Persistencia;


public partial class Paginas_PedidosEntregues : System.Web.UI.Page
{
    static void ItensPedido(int id)
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds = bd.SelectAll();

    }
    
        private void CarregaGrid(string termo)
    {
        PedidoBD bd = new PedidoBD();
        DataSet dse;
        if (termo != "")
            dse = bd.Search(termo);
        else
            dse = bd.SelectAll();
        GridView1.DataSource = dse.Tables[0].DefaultView;
        GridView1.DataBind();
        int registros = dse.Tables[0].Rows.Count;
        if (registros == 0)
            lblMensagem.Text = "<h1 class='text-center alert alert-danger'> PEDIDO Nº " + termo + " NÃO ENCONTRADO<h1>";
        else
            lblMensagem.Text = "<h6 class='text-center alert alert-success'>FORAM ENCONTRADO(S) " + registros + " PEDIDO(S) </h6>";
    }
    private void Carrega()
    {
        PedidoBD bd = new PedidoBD();
        DataSet dse = bd.SelectAllE();
        GridView1.DataSource = dse.Tables[0].DefaultView;
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        {
            Carrega();
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




    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int codigo = 0;
        switch (e.CommandName)
        {
            case "lucro":
                codigo = Convert.ToInt32(e.CommandArgument);
                Session["ID"] = codigo;
                Response.Redirect("Lucratividade.aspx");

                break;
            default:
                break;

        }
    }
}