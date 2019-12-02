using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Pesistencia;


    public partial class Paginas_Alterar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            IngredientesBD bd = new IngredientesBD();
            Ingredientes ingredientes = bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = ingredientes.Nome;
            txtMarca.Text = ingredientes.Marca;
            txtQuantidade.Text = ingredientes.Quantidade.ToString();
            txtvalorUnitario.Text = ingredientes.ValorUnitario.ToString();
            }
        }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        IngredientesBD bd = new IngredientesBD();
        Ingredientes ingredientes = bd.Select(Convert.ToInt32(Session["ID"]));

        ingredientes.Nome = txtNome.Text;
        ingredientes.Marca = txtMarca.Text;
        ingredientes.Quantidade = Convert.ToInt32(txtQuantidade.Text);
        ingredientes.ValorUnitario = Convert.ToDecimal(txtvalorUnitario.Text);

        if (bd.Update(ingredientes))
        {
            //lblMensagem.Text = "Ingrediente alterado com sucesso";
            txtNome.Text="";
            txtMarca.Text="";
            txtQuantidade.Text="";
            txtvalorUnitario.Text="";
            txtNome.Focus();
            Response.Redirect("ProgressoEstoque.aspx");
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }
}
