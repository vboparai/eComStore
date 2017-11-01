// Author: Varinder S. Boparai
// Date: Oct. 26, 2017


using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["userId"] != null)
        {
            string user = Session["userId"].ToString();
            Page.Title = user;
            System.Diagnostics.Debug.WriteLine("Hello " + user);
            loginPanel.Visible = false;
            logoutPanel.Visible = true;
        }
        else
        {
            loginPanel.Visible = true;
            logoutPanel.Visible = false;
        }

        


        
        cellphoneCountLabel.Text = "  Cellphones: {" + Count(1) + "}";
        laptopCountLabel.Text = "  Laptops: {" + Count(2) + "}";
        tabletCountLabel.Text = "  Tablets: {" + Count(3) + "}";

    }


    protected void logoutButton_Click(object sender, EventArgs e)
    {
        Session["userid"] = null;
        Response.Redirect("HomePage.aspx");
    }

    
    public int Count(int categoryNum)
    {
        int counter = 0;
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aspecomstore;";
        // Select all
        string query = "SELECT COUNT(CategoryId) from products where CategoryId =" + categoryNum + ";";

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
                    //Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                    // Example to save in the listView1 :
                    //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                    //var listViewItem = new ListViewItem(row);
                    //listView1.Items.Add(listViewItem);
                    System.Diagnostics.Debug.WriteLine("Counter is " + reader.GetString(0));
                    counter = Convert.ToInt32(reader.GetString(0));
                }
            }
            else
            {
                //Console.WriteLine("No rows found.");
            }

            databaseConnection.Close();
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);

        }




        return counter;
    }





    //protected void searchButton_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("searchresultspage.aspx?searchterm=" + searchtb.Text);
    //}











    protected void loginButton_Click(object sender, EventArgs e)
    {
        string username = usernameTb.Text;
        string password = passwordTb.Text;


        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=aspecomstore;";
        // Select all
        string query = "SELECT * FROM users where Username='" + username + "' AND Password='" + password + "';";


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
                    // Example to save in the listView1 :
                    //string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                    //var listViewItem = new ListViewItem(row);
                    //listView1.Items.Add(listViewItem);
                    Session["userid"] = reader.GetString(5);
                    Session["userNum"] = reader.GetString(0);

                }
                // Response.Redirect("WelcomePage.aspx?Email=" + email);
                //Session["userid"] = username;

                Response.Redirect("HomePage.aspx");
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



}