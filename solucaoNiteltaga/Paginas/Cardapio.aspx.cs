using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Persistencia;



public partial class Paginas_Cardapio : System.Web.UI.Page
{
    private void GridCardapio()
    {
        CardapioBD cardapioBD = new CardapioBD();
        DataSet ds = cardapioBD.SelectCardapio();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            Carrega();

        }
        GridCardapio();
    }
    private void Carrega()
    {
        CadastrarBD cardapioBD = new CadastrarBD();
        DataSet ds = cardapioBD.SelectAll();
        ddlEmbalagem.DataSource = ds.Tables[0].DefaultView;

        ddlEmbalagem.DataTextField = "emb_nome";
        ddlEmbalagem.DataValueField = "emb_id";
        ddlEmbalagem.DataBind();
        ddlEmbalagem.Items.Insert(0, "Selecione a Embalagem");

        DataSet dsr = cardapioBD.ListarReceita();
        ddlReceita.DataSource = dsr.Tables[0].DefaultView;

        ddlReceita.DataTextField = "rec_nome";
        ddlReceita.DataValueField = "ing_id";
        ddlReceita.DataBind();
        ddlReceita.Items.Insert(0, "Selecione a Receita");
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Carrega();
        }
            Cadastrar cadastrar = new Cadastrar();

        //recuperar da tela
        int pedidoID = Convert.ToInt32(Session["ID"]);
        int embalagem = Convert.ToInt32(ddlEmbalagem.SelectedItem.Value);
        
        DataTable dt = new DataTable();
        ddlEmbalagem.DataSource = dt;
        ddlEmbalagem.DataTextField = "emb_nome";
        ddlEmbalagem.DataValueField = "emb_id";
        ddlEmbalagem.DataBind();
        decimal valUnit = cadastrar.valorUnitario = Convert.ToDecimal(txtvalorUnitario.Text);
        int receita = Convert.ToInt32(ddlReceita.SelectedItem.Value);
        ddlEmbalagem.DataSource = dt;
        ddlReceita.DataTextField = "rec_nome";
        ddlReceita.DataValueField = "rec_id";
        ddlReceita.DataBind();


        string nome = cadastrar.Nome = txtNome.Text;

        //montar o item
        cadastrar.Nome = nome;
        cadastrar.valorUnitario = valUnit;
        cadastrar.Embalagem = embalagem;
        cadastrar.Receita = receita;

        CadastrarBD bd = new CadastrarBD();

        if (bd.Insert(cadastrar))
        {
            lblMensagem.Text = "Cardápio cadastrado com sucesso";

            txtNome.Text = "";
            txtvalorUnitario.Text = "";
            txtNome.Focus();
            Carrega();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar";
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