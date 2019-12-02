using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Persistencia;



public partial class Paginas_Cadastrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
    }
    private void Carrega()
    {
        CadastrarBD cardapioBD = new CadastrarBD();
        DataSet ds = cardapioBD.SelectAll();
        DropDownList1.DataSource = ds.Tables[0].DefaultView;

        DropDownList1.DataTextField = "emb_nome";
        DropDownList1.DataValueField = "emb_id";
        DropDownList1.DataBind();
        DropDownList1.Items.Insert(0, "Selecione a Embalagem");

        DataSet dsr = cardapioBD.ListarReceita();
        DropDownList2.DataSource = dsr.Tables[0].DefaultView;

        DropDownList2.DataTextField = "rec_nome";
        DropDownList2.DataValueField = "ing_id";
        DropDownList2.DataBind();
        DropDownList2.Items.Insert(0, "Selecione a Receita");
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Cadastrar cadastrar = new Cadastrar();

        //recuperar da tela
        int pedidoID = Convert.ToInt32(Session["ID"]);
        int cardapioID = Convert.ToInt32(DropDownList1.SelectedItem.Value);
        decimal valUnit = cadastrar.valorUnitario = Convert.ToDecimal(txtvalorUnitario.Text);
        int quantidade = Convert.ToInt32(DropDownList2.SelectedItem.Value);
        string nome = cadastrar.Nome = txtNome.Text;

        //montar o item
        Cadastrar item = new Cadastrar();
        cadastrar.Nome = nome;
        cadastrar.valorUnitario = valUnit;
        cadastrar.Id = pedidoID;



        CadastrarBD bd = new CadastrarBD();
        if (bd.Insert(cadastrar))
        {
            lblMensagem.Text = "Cardápio cadastrado com sucesso";

            txtNome.Text = "";
            txtvalorUnitario.Text = "";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar";
        }
    }
}