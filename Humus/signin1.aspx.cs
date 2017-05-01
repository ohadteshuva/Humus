using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class signin1 : System.Web.UI.Page
{
    public string mesasge = " ";

    private string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True;User Instance=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.HttpMethod == "POST")
        {
            string username = Request.Form["username"];
            string password = Request["password"];
           

            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            SqlCommand command = connect.CreateCommand();
            command.CommandText = "SELECT * FROM users WHERE username = '" + username + "'";
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader.GetString(3) == password && reader.GetString(1) == username)
                {
                    mesasge = "good";
                    Session["username"] = username;
                    if (reader.GetString(5) == "true")
                    {
                        Session["admin"] = "true";
                        Response.Redirect("admin.aspx");
                    }
                    else
                    {
                        Response.Redirect("homepage1.aspx");
                    }

                }
                else
                {
                    mesasge = " username or password do not match try again";
                }

            }
            else
            {
                mesasge = " username or password do not match try again";
            }

            connect.Close();
            reader.Close();
           
        }




    }
}