using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_AlterarPedido : System.Web.UI.Page
{
    private void Carrega()
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds = bd.SelectAll();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();


        if (!Page.IsPostBack)
        {
            PedidoBD bd = new PedidoBD();
            Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));
            pedido.Observacao = txtObservacao.Text;
            txtValorTotal.Text = pedido.ValorTotal.ToString();
            

        }
        
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        PedidoBD bd = new PedidoBD();
        Pedido pedido = bd.Select(Convert.ToInt32(Session["ID"]));
        DateTime dataPedido = Convert.ToDateTime(txtDataPedido.Text);
        DateTime dataEntrega = Convert.ToDateTime(txtDataEntrega.Text);
        
        if (bd.Update(pedido))
        {
            lblMensagem.Text = " <p class='alert alert-success'>Funcionário alterado com sucesso</p>";
        }
        else
        {
            lblMensagem.Text = "Erro ao salvar.";
        }
    }

}