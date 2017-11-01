using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShoppingCartV2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userId"] != null)
        {
            string user = Session["userId"].ToString();
            Page.Title = user;
            System.Diagnostics.Debug.WriteLine("Hello " + user);
        }


        
        
    }

    protected void continueShoppingButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }



}