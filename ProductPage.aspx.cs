using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductPage : System.Web.UI.Page
{
    public static double cartPrice;
    public static string prodId;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["userId"] != null)
        {
            string user = Session["userId"].ToString();
            Page.Title = user;
            System.Diagnostics.Debug.WriteLine("Hello " + user);
        }



        string productId = Request.QueryString["productId"].ToString();

         string category, name, description, imgPath;
        double price;
        


        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aspecomstore;";
        // Select all
        string query = "SELECT * FROM products where productId='" + productId + "';";


        MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        commandDatabase.CommandTimeout = 60;
        MySqlDataReader reader;

        try
        {
            databaseConnection.Open();
            reader = commandDatabase.ExecuteReader();
            // Success, now list 

            // If there are available rows
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //ID                              First name                  Last Name                    Address
                    Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));

                    prodId = reader.GetString(0);
                    category = reader.GetString(1);
                    name = reader.GetString(2);
                    description = reader.GetString(4);
                    imgPath = reader.GetString(3);
                    price = Convert.ToDouble(reader.GetString(5));
                    // Example to save in the listView1 :
                    //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                    //var listViewItem = new ListViewItem(row);
                    //listView1.Items.Add(listViewItem);
                    Session["userid"] = reader.GetString(5);

                    
                    prodName.Text = name;
                    cartPrice = price;
                    prodPrice.Text = "$" + cartPrice;
                    prodDesc.Text = description;
                    System.Diagnostics.Debug.WriteLine("image path " + imgPath);
                    if (!IsPostBack)
                    {
                        Image1.ImageUrl = imgPath;
                        Image1.DataBind();
                    }


                }
                // Response.Redirect("WelcomePage.aspx?Email=" + email);
                //Session["userid"] = username;
               


            }
            else
            {

                Console.WriteLine("No rows found.");
            }

            databaseConnection.Close();
        }
        catch (Exception ex)
        {
            // MessageBox.Show(ex.Message);
            // must use a jquery method/function
        }
                
    }

    public static string cartProduct = "";
    public static double cartTotal = 0;
    protected void addToCartButton_Click(object sender, EventArgs e)
    {
        cartProduct += prodName.Text + "<br/>";
        cartTotal += cartPrice;
        Session["cart"] = cartTotal;
        Session["cartProd"] = cartProduct;
        





        //// ADD TO TEMP ORDERS TABLE
        //string username = Session["userId"].ToString();
        //string userNum = Session["userNum"].ToString();
        //string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aspecomstore;";
        //string query = "INSERT INTO ORDERS(`id`, `userid`, `productId`) VALUES (NULL, '" + userNum + "', '" + prodId  + "')";
        //// Which could be translated manually to :
        //// INSERT INTO user(`id`, `first_name`, `last_name`, `address`) VALUES (NULL, 'John', 'Doe', 'John Doe Villa')

        //MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        //MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        //commandDatabase.CommandTimeout = 60;

        //try
        //{
        //    databaseConnection.Open();
        //    MySqlDataReader myReader = commandDatabase.ExecuteReader();
            

        //    databaseConnection.Close();
        //}
        //catch (Exception ex)
        //{
        //    // Show any error message.
        //}


        Response.Redirect("ShoppingCart.aspx");

    }







}