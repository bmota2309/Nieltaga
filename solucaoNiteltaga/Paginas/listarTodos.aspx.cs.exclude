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