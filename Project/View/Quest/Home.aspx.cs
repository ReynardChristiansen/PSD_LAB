using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View.Quest
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if(Session["name"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Label.Text = "Selamat Datang " + Session["name"];

            }
        }
    }
}
