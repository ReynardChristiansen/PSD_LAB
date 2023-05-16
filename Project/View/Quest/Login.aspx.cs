using Project.Controller;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View.Quest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void AssignCookies(Customer user)
        {
            HttpCookie cookie = new HttpCookie("User_Cookie");
            cookie["id"] = user.CustomerID.ToString();
            cookie["role"] = user.CustomerRole;
            cookie["name"] = user.CustomerName;
            cookie.Expires = DateTime.Now.AddHours(3);
            Response.Cookies.Add(cookie);
        }
        protected void AssignSession(Customer user)
        {
            Session["userAuth"] = user.CustomerID.ToString();
            Session["role"] = user.CustomerRole;
            Session["name"] = user.CustomerName;
        }

        protected void bnt_Login_Click(object sender, EventArgs e)
        {
            string temp = LoginController.authentication(txt_Email.Text, txt_Password.Text);
            var u = LoginController.getUser(txt_Email.Text, txt_Password.Text);
            bool m = cb_Remember.Checked;

            if (temp == "")
            {
                lbl_Error.Visible = false;
                if (m)
                {
                   AssignCookies(u);
                }
                
                AssignSession(u);
                Response.Redirect("Home.aspx");
                return;
                
            }
            else
            {
                lbl_Error.Text = temp;
                lbl_Error.Visible = true;
            }
            
        }
    }
}