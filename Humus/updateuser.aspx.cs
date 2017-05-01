using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class updateuser : System.Web.UI.Page
{
    public string usermsg = "";
    private string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=\"|DataDirectory|\\Database1.mdf\";Integrated Security=True;User Instance=True";
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["admin"] == null)
        {
            Response.Redirect("signup1.aspx");
        }
        string filename = "Database1.mdf";
        string tablename = "users";
        string selectquery = "";
        
        string username = Request.Form["username"];
        string password = Request["oldpassword"];
        string newpassword = Request["newpassword"];
        string sql = "";
        if (Request.HttpMethod == "POST")
        {
            selectquery = "SELECT * FROM " + tablename + " WHERE username='" + username + "'AND password='" + password + "';";
            sql = "UPDATE " + tablename + " SET password='" + newpassword + "'WHERE username='" + username + "'AND password='" + password + "'";
            if (MyAdoHelper.IsExist(filename, selectquery))
            {
                MyAdoHelper.DoQuery(filename, sql);
                usermsg = "update";
            }
            else
                usermsg = "origin pass or username incorect";
        }
        Response.Write("<a href=admin.aspx> admin page </a>");
    }
}