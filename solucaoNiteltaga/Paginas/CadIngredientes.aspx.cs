using CrudIngrediente.Persistencia;
using solucaoNiteltaga.Classes;
using CrudIngrediente.Classes;
using solucaoNiteltaga.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Cadastrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            IngredienteBD bd = new IngredienteBD();
            Ingrediente ingrediente = bd.Select(Convert.ToInt16(Session["ID"]));
            ingrediente.Nome = txtNome.Text;
            ingrediente.Marca = txtMarca.Text;
            ingrediente.Quantidade = Convert.ToInt16(txtQuantidade.Text);
            ingrediente.ValorUnitario = Convert.ToDouble(txtValorUnitario.Text);
        }
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Ingrediente ingrediente = new Ingrediente();
        ingrediente.Nome = txtNome.Text;
        ingrediente.Marca = txtMarca.Text;
        ingrediente.Quantidade = Convert.ToInt16(txtQuantidade.Text);
        ingrediente.ValorUnitario = Convert.ToDouble(txtValorUnitario.Text);
        IngredienteBD bd = new IngredienteBD();
        if (bd.Insert(ingrediente))
        {
            lblMensagem.Text = "Ingrediente cadastrado com sucesso";
            txtNome.Text = "";
            txtMarca.Text = "";
            txtQuantidade.Text = "";
            txtValorUnitario.Text = "";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }

    }

}