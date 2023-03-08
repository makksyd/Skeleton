using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //
        clsStocks anStocks = new clsStocks();
        anStocks.item_name = txtItemName.Text;
        Session["anStocks"] = anStocks;
        Response.Redirect("StockViewer.aspx");


    }
}