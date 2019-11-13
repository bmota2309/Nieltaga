using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Pedido : System.Web.UI.Page
{
    private void Carrega()
    {
        PedidoBD bd = new PedidoBD();
        DataSet ds = bd.SelectAll();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    
    protected void btnOK_Click(object sender, EventArgs e)
    {
        Response.Write(ddlCardapio.SelectedItem.Text);
    }

    protected void ddlCardapio_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(ddlCardapio.SelectedItem.Text);
    }
    protected void txtDataPedido_TextChanged(object sender, EventArgs e)
    {
        DateTime data = DateTime.Now;
        Console.WriteLine(data.ToShortDateString());
    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Pedido itempedido = new Pedido();
        Pedido pedido = new Pedido();
        DateTime dataPedido = Convert.ToDateTime(txtDataPedido.Text);
        pedido.DataPedido = dataPedido;
        DateTime dataEntrega = Convert.ToDateTime(txtDataEntrega.Text);
        pedido.DataEntrega = dataEntrega;
        pedido.Observacao = txtObservacao.Text;
        pedido.ValorTotal = Convert.ToDecimal(txtValorTotal.Text);

        PedidoBD bd = new PedidoBD();
        if (bd.Insert(pedido))
        {
            lblMensagem.Text = "<p class='alert alert-success'>Pedido cadastrado com sucesso!</p>";
            txtDataPedido.Text = "";
            txtDataEntrega.Text = "";
            txtObservacao.Text = "";
            txtValorTotal.Text = "";
        }
        else
        {
            lblMensagem.Text = "Erro ao realizar o pedido.";
        }



    }

    protected void ddlPedido_SelectedIndexChanged(object sender, EventArgs e)
    {
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