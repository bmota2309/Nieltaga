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
    private void Carrega()
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds = bd.SelectAll();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
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
                
            default:
                break;
        }
    }
}