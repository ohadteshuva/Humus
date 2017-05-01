using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class homepage1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] != null)
        {
            Response.Write("hello" + Session["username"]);

        }
        else
            Response.Write("<a href=signin1.aspx> sign in </a>");
        if(Session["admin"] == "true")
        {
            Response.Write("<a href=admin.aspx> admin page </a>");
        }
        Application.Lock();
        if (Application["count"] == null)
        {
            Response.Write("0 enters");
            Application["count"] = 0;
        }
        Application["count"] = (int)Application["count"] + 1;
        Response.Write(Application["count"]);
        Application.UnLock();
    }
}