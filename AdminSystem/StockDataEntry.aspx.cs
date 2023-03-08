using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
<<<<<<< HEAD
=======
using ClassLibrary;
>>>>>>> fb904ec18b5c101813e482ee4a6c3314fdce42e5

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
<<<<<<< HEAD
=======

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //
        clsStocks anStocks = new clsStocks();
        anStocks.item_name = txtItemName.Text;
        Session["anStocks"] = anStocks;
        Response.Redirect("StockViewer.aspx");


    }
>>>>>>> fb904ec18b5c101813e482ee4a6c3314fdce42e5
}