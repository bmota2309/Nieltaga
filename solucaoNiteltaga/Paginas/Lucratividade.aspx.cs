using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Lucratividade : System.Web.UI.Page
{

    private void Carrega()
    {
        LucratividadeBD bd = new LucratividadeBD();
        DataSet ds = bd.Select(Convert.ToInt32(Convert.ToInt32(Session["ID"])));
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();


        double total = bd.totalizaCusto(Convert.ToInt32(Session["ID"]));
        txtTotalCusto.Text = (String.Format("R$ {0:c2}", Convert.ToString(total)));

        ItemPedidoBD ibd = new ItemPedidoBD();
        double totalP = ibd.totalizaItens(Convert.ToInt32(Session["ID"]));
        txtVenda.Text = (String.Format("R$ {0:c2}", Convert.ToString(totalP)));

        double resultado = totalP - total;
        txtLucro.Text = (String.Format("R$ {0:c2}", resultado.ToString())); 

        
    }

    //private void CarregaPedidos()
    //{
    //    LucratividadeBD lucratividadeBD = new LucratividadeBD();
    //    DataSet ds = lucratividadeBD.SelectAll();
    //    ddlListaPedidos.DataSource = ds.Tables[0].DefaultView;
    //    ddlListaPedidos.DataTextField = "ped_id";
    //    ddlListaPedidos.DataValueField = "ped_id";
    //    ddlListaPedidos.DataBind();
    //    ddlListaPedidos.Items.Insert(0, "Selecione");
        
    //}

    //private void CarregaSelecao()
    //{
        
    //    LucratividadeBD bd = new LucratividadeBD();
    //        Lucratividade lucro = new Lucratividade();
    //        int codigo = Convert.ToInt32(ddlListaPedidos.SelectedItem.Value);
    //        string texto = ddlListaPedidos.SelectedItem.Text;
    //        lucro.selecionaID = texto;
    //        DataSet ds = bd.Select(Convert.ToInt32(codigo));
    //        GridView1.DataSource = ds.Tables[0].DefaultView;
    //        GridView1.DataBind();

    //    double total = bd.totalizaCusto(Convert.ToInt32(codigo));
    //    txtTotalCusto.Text = (String.Format("R$ {0:c2}", Convert.ToString(total)));

    //    ItemPedidoBD ibd = new ItemPedidoBD();
    //    double totalP = ibd.totalizaItens(Convert.ToInt32(codigo));
    //    txtVenda.Text = (String.Format("R$ {0:c2}", Convert.ToString(totalP)));

    //    double resultado = totalP - total;
    //    txtLucro.Text = (String.Format("R$ {0:c2}", resultado.ToString()));

    //    LucratividadeBD bdl = new LucratividadeBD();
    //    DataSet dst = bdl.Select(Convert.ToInt32(Convert.ToInt32(codigo)));
    //    GridView1.DataSource = ds.Tables[0].DefaultView;
    //    GridView1.DataBind();


    //}




    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
        if (!IsPostBack)
        {
            //CarregaPedidos();
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

    //protected void Button2_Click(object sender, EventArgs e)
    //{

    //    CarregaSelecao();

    //    if (!IsPostBack)
    //    {
    //        CarregaPedidos();
    //        CarregaSelecao();
            
    //    }

    //}
}