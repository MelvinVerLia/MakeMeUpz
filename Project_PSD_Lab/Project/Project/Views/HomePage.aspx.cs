using Project.Models;
using Project_Lab.Handlers;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        private static User user;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Request.Cookies["user_cookie"] != null)
            {
                int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                user = UserHandler.searchUserByID(id);
                Session["user_session"] = user;
            }
            else
            {
                user = (User)Session["user_session"];
            }

            if (Session["user_session"] == null)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }

            String username = user.Username;
            String userRole = user.UserRole;

            UsernameLbl.Text = username;
            RoleLbl.Text = userRole;

            if (userRole == "Admin")
            {
                FetchCustomers();
                UserGV.Visible = true;
            }
        }

        public void FetchCustomers()
        {
            List<User> users = UserHandler.getAllCustomers();
            UserGV.DataSource = users;
            UserGV.DataBind();
        }
    }
}