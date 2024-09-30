using Project.Handlers;
using Project.Models;
using Project_Lab.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace Project.Views
{
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        private static User user;
        public List<TransactionDetail> transactions = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_session"] == null)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }
            else
            {
                user = (User)Session["user_session"];
            }

            if (IsPostBack == false)
            {
                int ID = Convert.ToInt32(Request.QueryString["id"]);
                String role = user.UserRole;

                if (role == "Admin")
                {
                    transactions = TransactionDetailHandler.getAllTransactions();
                    TransactionGV.DataSource = transactions;
                    TransactionGV.DataBind();
                }
                else if (role == "Customer")
                {
                    transactions = TransactionDetailHandler.getUserTransaction(ID);
                    TransactionGV.DataSource = transactions;
                    TransactionGV.DataBind();
                }
            }
        }
    }
}