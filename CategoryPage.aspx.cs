using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CategoryPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

       

        if (!this.IsPostBack)
        {

            string catId = Request.QueryString["id"].ToString();

            string mainconn = ConfigurationManager.ConnectionStrings["abcconnection"].ConnectionString;
            MySqlConnection sqlconn = new MySqlConnection(mainconn);
            MySqlCommand comm = new MySqlCommand("select productId, productName, productPrice, productImg" +
                " from Products where CategoryId= '" + catId + "';");
            {
                MySqlDataAdapter da = new MySqlDataAdapter();
                comm.Connection = sqlconn;
                da.SelectCommand = comm;
                DataTable dt = new DataTable();
                {
                    da.Fill(dt);
                    Gdview.DataSource = dt;
                    Gdview.DataBind();

                }

            }
        }


    }
}