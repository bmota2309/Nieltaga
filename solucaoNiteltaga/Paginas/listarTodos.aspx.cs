using solucaoNiteltaga.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_listarTodos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            CarregarCardapio();

        if (gdvCardapio.Rows.Count > 1)
            gdvCardapio.HeaderRow.TableSection = TableRowSection.TableHeader;

    }

    public void CarregarCardapio()
    {
        DataSet dsCardapio = PedidoBD.SelectAll();
        int qtd = Funcoes.DSQuantidadesRegistros(dsCardapio);

        if (qtd > 0)
        {
            gdvCardapio.DataSource = dsCardapio.Tables[0].DefaultView; //passa o dataset para o datasource do gridview
            gdvCardapio.DataBind(); //carregar a tabela
            gdvCardapio.HeaderRow.TableSection = TableRowSection.TableHeader;

            ddlCardapio.DataSource = dsCardapio.Tables[0].DefaultView;
            ddlCardapio.DataTextField = "car_nome";
            ddlCardapio.DataBind();
        }
        else
        {

        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Response.Write(ddlCardapio.SelectedItem.Text + " - " + ddlCardapio.SelectedValue);
    }

    protected void ddlCardapio_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(ddlCardapio.SelectedItem.Text + " - " + ddlCardapio.SelectedValue);
    }
}