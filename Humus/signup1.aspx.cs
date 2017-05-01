using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class signup1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.HttpMethod == "POST")
        {
            string username = Request.Form["username"];
            string name = Request["name"];
            string password = Request["password"];
            // string phone = Request["phone"];
            string email = Request.Form["mail"];
            string admin = Request.Form["admin"];
           
            
            Session["username"] = username;
           
            //string date = Request["date"];
            //string sql = "INSERT INTO users VALUES('" + username + "', '" + name + "', '" + password + "', '" + phone + "', '" + email + "', '" + date + "')";
            string filename = "Database1.mdf";
            string selectquery = "SELECT * FROM users WHERE username = '" + username + "'";
            if (MyAdoHelper.IsExist(filename, selectquery))
            {
                Response.Write("already exits");
                Response.Redirect("signin1.aspx");
            }
            else
            {
                string sql = String.Format("INSERT INTO users VALUES('{0}', '{1}',  '{2}', '{3}' , '{4}');", username, name, password, email, admin);
                string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True;User Instance=True";
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                SqlCommand command = connect.CreateCommand();
                command.CommandText = sql;
                command.ExecuteNonQuery();
                connect.Close();
                Session["admin"] = "false";
                if (admin == "true")
                {
                    Session["admin"] = "true";
                    Response.Redirect("admin.aspx");
                }
                else
                {
                    Response.Redirect("homepage1.aspx");
                }
            }
            Response.End();
          

        }


    }
}