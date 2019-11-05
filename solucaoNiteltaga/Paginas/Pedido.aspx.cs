using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Pedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtDataPedido_TextChanged(object sender, EventArgs e)
    {
        DateTime data = DateTime.Now;
        Console.WriteLine(data.ToShortDateString());
    }
    
}