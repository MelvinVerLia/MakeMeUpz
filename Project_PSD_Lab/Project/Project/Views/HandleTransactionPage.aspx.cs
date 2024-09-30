using Project.Models;
using Project_Lab.Handlers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace Project_Lab.Views
{
    public partial class HandleTransactionPage : System.Web.UI.Page
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
                transactions = TransactionHeaderHandler.getAllTransactions();
                TransactionGV.DataSource = transactions;
                TransactionGV.DataBind();
            }
        }

        protected void Handlebtn_Click(object sender, EventArgs e)
        {
            Button handlebutton = (Button)sender;
            GridViewRow row = (GridViewRow)handlebutton.NamingContainer;
            int id = Convert.ToInt32(row.Cells[0].Text);

            TransactionHeaderHandler.UpdateStatusByID(id, "Handled");
            Response.Redirect("~/Views/HandleTransactionPage.aspx");
        }
    }
}