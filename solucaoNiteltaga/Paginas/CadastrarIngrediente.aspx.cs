using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Pesistencia;

public partial class Paginas_Cadastrar : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Ingredientes ingredientes = new Ingredientes();
        ingredientes.Nome = txtNome.Text;
        ingredientes.Marca = txtMarca.Text;
        ingredientes.Quantidade = Convert.ToInt32(txtQuantidade.Text);
        ingredientes.ValorUnitario = Convert.ToDecimal(txtvalorUnitario.Text);
        ingredientes.QuantidadeMax = Convert.ToDouble(txtquantidadeMax.Text);

        IngredientesBD bd = new IngredientesBD();
        if (bd.Insert(ingredientes))
        {
            lblMensagem.Text = "Ingrediente cadastrado com sucesso";

            txtNome.Text = "";
            txtMarca.Text = "";
            txtQuantidade.Text = "";
            txtvalorUnitario.Text = "";
            txtNome.Focus();
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
        }
    }
