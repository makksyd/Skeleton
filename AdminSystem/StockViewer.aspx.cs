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
public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
<<<<<<< HEAD

=======
        clsStocks anStocks = new clsStocks();
        anStocks = (clsStocks)Session["anStocks"];
        Response.Write(anStocks.item_name);
>>>>>>> fb904ec18b5c101813e482ee4a6c3314fdce42e5
    }
}