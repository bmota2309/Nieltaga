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
    }
    //private void CarregaGrafico()
    //{
    //    LucratividadeBD grafico = new LucratividadeBD();
    //    DataSet ds = grafico.Select(Convert.ToInt32(GridView1.SelectedValue));
    //    GridView1.DataSource = ds.Tables[0].DefaultView;
    //    GridView1.DataBind();

    //}

    //private void CarregaPedidos()
    //{   
        //LucratividadeBD lucratividadeBD = new LucratividadeBD();
        //DataSet ds = lucratividadeBD.SelectAll();

        //ddlListaPedidos.DataSource = ds.Tables[0].DefaultView;

        //ddlListaPedidos.DataTextField = "ped_id";
        //ddlListaPedidos.DataValueField = "ped_id";
        //ddlListaPedidos.DataBind();
        //ddlListaPedidos.Items.Insert(0, "Selecione");

    //}

        protected void Page_Load(object sender, EventArgs e)
        {
        Carrega();


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

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //CarregaGrafico();
            ////recuperar da tela
            //int pedidoID = Convert.ToInt32("ped_id");
            //int selecionaID = Convert.ToInt32(ddlListaPedidos.SelectedItem.Value);

            ////montar o item
            //Lucratividade item = new Lucratividade();
            //item.pedidoID = pedidoID;
            //item.selecionaID = selecionaID;
        }
        
    }
}