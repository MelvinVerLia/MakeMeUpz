using Project.Models;
using Project_Lab.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Project_Lab.Views
{
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        private static User user;
        public List<TransactionHeader> transactions = null;
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
                int id = user.UserID;
                String role = user.UserRole;

                if (role == "Admin")
                {
                    transactions = TransactionHeaderHandler.getAllTransactions();
                    TransactionGV.DataSource = transactions;
                    TransactionGV.DataBind();
                }
                else if (role == "Customer")
                {
                    transactions = TransactionHeaderHandler.getUserTransaction(id);
                    TransactionGV.DataSource = transactions;
                    TransactionGV.DataBind();
                }
            }

        }
        protected void Detailbtn_Click1(object sender, EventArgs e)
        {
            Button btnDetail = (Button)sender;
            int transactionId = Convert.ToInt32(btnDetail.CommandArgument);
            Response.Redirect($"TransactionDetailPage.aspx?id={transactionId}");
        }
    }
}