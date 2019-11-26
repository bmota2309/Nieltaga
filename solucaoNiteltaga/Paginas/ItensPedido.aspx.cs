using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Persistencia;

public partial class Paginas_ItensPedido : System.Web.UI.Page
{
    private void Carrega()
    {
        PedidoBD bd = new PedidoBD();
        Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));
        
        txtPedido.Text = pedido.Codigo.ToString();

        CardapioBD cardapioBD = new CardapioBD();
        DataSet ds = cardapioBD.SelectAll();
        ddlCardapio.DataSource = ds.Tables[0].DefaultView;

        ddlCardapio.DataTextField = "car_nome";
        ddlCardapio.DataValueField = "car_id";
        ddlCardapio.DataBind();
        ddlCardapio.Items.Insert(0, "Selecione");

              
    }
    private void CarregaItensPedido()
    {
        ItemPedidoBD bd = new ItemPedidoBD();
        DataSet ds = bd.SelectIt(Convert.ToInt32(Session["ID"]));
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Carrega();
                PedidoBD bd = new PedidoBD();
                Pedido ped = bd.Select(Convert.ToInt32(Session["ID"]));
                CarregaItensPedido();

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

    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }

    protected void btInserir_Click(object sender, EventArgs e)
    {
        //recuperar da tela
        int pedidoID = Convert.ToInt32(Session["ID"]);
        int cardapioID = Convert.ToInt32(ddlCardapio.SelectedItem.Value);
        int quantidade = Convert.ToInt32(txtQuantidade.Text);

        //montar o item
        ItemPedido item = new ItemPedido();
        item.Quantidade = quantidade;
        item.CardapioID = cardapioID;
        item.PedidoID = pedidoID;

        

        //colocar no BD
        ItemPedidoBD bd = new ItemPedidoBD();
        //bd.Insert(item);
        //limpar campos

        if (bd.Insert(item))
        {
            lblMensagem.Text = "<div class='alert alert-success text-center'>Item inserido com sucesso!</div>";

            Carrega();
            CarregaItensPedido();
            txtQuantidade.Text = "";
        }
        else
        {
            lblMensagem.Text = "Erro ao inserir o Item.";
        }
        



    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int cod = 0;
        switch (e.CommandName)
        {
            
            case "Deletar":
                cod = Convert.ToInt32(e.CommandArgument);
                ItemPedidoBD bd = new ItemPedidoBD();
                int pedidoID = Convert.ToInt32(Session["ID"]);
                bd.Delete(cod);
                Carrega();
                CarregaItensPedido();

                lblMensagem.Text = "<div class='alert alert-warning' role='alert'>  Item excluído com sucesso!</ div > ";
                break;
            case "Finalizar":
                cod = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("PedidosRealizados.aspx");

                break;
            default:
                break;

        }
    }

    protected void back_Load(object sender, EventArgs e)
    {

    }
}