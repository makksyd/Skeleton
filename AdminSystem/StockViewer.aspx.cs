using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
    
public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStocks anStocks = new clsStocks();
        anStocks = (clsStocks)Session["anStocks"];
        Response.Write(anStocks.item_name);
    }
}