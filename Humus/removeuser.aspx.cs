using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class removeuser : System.Web.UI.Page
{
    public string usermsg = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        usermsg = "cant delete";
        string filename = "Database1.mdf";
       // string tablename = "users";
       // string connectionstring = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Users\\user1\\Desktop\\web\\App_Data\\Database.mdf;Integrated Security=True;User Instance=True";
        if (Session["admin"] != "true")
        {
            Response.Redirect("signup1.aspx");
        }
       
        if (Request.HttpMethod == "POST")

        {
            
            string username = Request.Form["username"];
            string selectquery = "SELECT * FROM users WHERE username = '" + username + "'";
            if (MyAdoHelper.IsExist(filename, selectquery))
            {
                string sql = "DELETE FROM users WHERE username = '" + username + "'";
                MyAdoHelper.DoQuery(filename, sql);
                usermsg = "deleted";

            }
            else
            {
                
                usermsg = "not exict";
            }
       
        }
        Response.Write("<a href=admin.aspx> admin page </a>");
    }
}