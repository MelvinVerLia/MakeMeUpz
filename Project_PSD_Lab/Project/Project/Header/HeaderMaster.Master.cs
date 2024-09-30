using Project.Models;
using Project_Lab.Handlers;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab.Header
{
    public partial class HeaderMaster : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["user_session"];
            string role = user.UserRole;

            if (role == "Admin")
            {
                OrderBtn.Visible = false;
            }
            else if (role == "Customer")
            {
                ManageBtn.Visible = false;
                QueueBtn.Visible = false;
                TransactionBtn.Visible = false;
            }
        }



        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void ManageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session["user_session"] = null;
            Session.Abandon();

            Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ProfilePage.aspx");
        }

        protected void OrderBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/OrderMakeupPage.aspx");
        }

        protected void HistoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/TransactionHistoryPage.aspx");
        }

        protected void QueueBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HandleTransactionPage.aspx");
        }

        protected void TransactionBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ReportPage.aspx");

        }
    }
}