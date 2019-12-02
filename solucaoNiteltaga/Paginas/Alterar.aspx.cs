using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using solucaoNiteltaga.Persistencia;
using solucaoNiteltaga.Classes;


public partial class Paginas_Alterar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            CadastrarBD bd = new CadastrarBD();
            Cadastrar cadastrar = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = cadastrar.Nome;
            txtvalorUnitario.Text = cadastrar.valorUnitario.ToString();
        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        CadastrarBD bd = new CadastrarBD();
        Cadastrar cadastrar = bd.Select(Convert.ToInt32(Session["ID"]));
        cadastrar.Nome = txtNome.Text;
        cadastrar.valorUnitario = Convert.ToInt32(txtvalorUnitario.Text);

        if (bd.Update(cadastrar))
        {
            lblMensagem.Text = "Funcionário alterado com sucesso";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }
}