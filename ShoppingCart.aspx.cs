using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShoppingCart : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userId"] != null)
        {
            string user = Session["userId"].ToString();
            Page.Title = user;
            System.Diagnostics.Debug.WriteLine("Hello " + user);
        }



        double taxRate = 0.13;
        double totalBefore = Convert.ToDouble(Session["cart"].ToString());
        totalBeforeTaxLabel.Text = "Cart total before tax: $" + Session["cart"].ToString();
        double tax = taxRate * Convert.ToDouble(Session["cart"].ToString());
        taxLabel.Text = "Tax at " + taxRate + "%: $" + tax;
        double total = totalBefore +tax;
        cartPriceLabel.Text = "Total after taxes: $" + total ;

        
        itemsLabel.Text = Session["cartProd"].ToString();

    }

    protected void continueShoppingButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}