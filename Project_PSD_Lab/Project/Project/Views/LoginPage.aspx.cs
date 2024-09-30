using Project.Models;
using Project_Lab.Controller;
using Project_Lab.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        MakeUpDatabaseEntities1 db = new MakeUpDatabaseEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_session"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            String username = UsernameTB.Text;
            String password = PasswordTB.Text;
            Boolean rememberMe = RememberCheck.Checked;

            User user = UserHandler.getUser(username);

            ErrorLabel.Text = UserController.UserLogin(username, password);

            if (ErrorLabel.Text == "")
            {
                Session["user_session"] = user;
                if (rememberMe)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = user.UserID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(12);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}