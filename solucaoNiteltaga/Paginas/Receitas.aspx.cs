using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Receitas itemreceita = new Receitas();
        Receitas receita = new Receitas();
        receita.Ingrediente = Convert.ToInt16(txtIngrediente.Text);
        receita.Quantidade = Convert.ToInt16(txtQuantidade.Text); ;

        ReceitaBD bd = new ReceitaBD();
        if (bd.Insert(receita))
        {
            lblMensagem.Text = "<p class='alert alert-success'>Pedido cadastrado com sucesso!</p>";
            txtIngrediente.Text = "";
            txtQuantidade.Text = "";
        }
        else
        {
            lblMensagem.Text = "Erro ao realizar o pedido.";
        }



    }
}
