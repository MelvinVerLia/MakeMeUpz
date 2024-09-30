using Project.Dataset;
using Project.Models;
using Project.Report;
using Project_Lab.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Views
{
    public partial class ReportPage : System.Web.UI.Page
    {
        private static User user;
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

            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            MakeupDataset data = getData(TransactionHeaderHandler.getAllTransactions());
            report.SetDataSource(data);
        }

        private MakeupDataset getData(List<TransactionHeader> transaction)
        {
            MakeupDataset data = new MakeupDataset();
            var headerTable = data.TransactionHeaders;
            var detailTable = data.TransactionDetails;

            foreach (TransactionHeader t in transaction)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                hrow["Status"] = t.Status;
                int Grand = 0;           

                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["MakeupID"] = d.MakeupID;
                    drow["Quantity"] = d.Quantity;

                    int Sub = d.Quantity * d.Makeup.MakeupPrice;
                    drow["SubTotal"] = Sub;

                    detailTable.Rows.Add(drow);
                    Grand += Sub;
                }
                hrow["GrandTotal"] = Grand;
                headerTable.Rows.Add(hrow);
            }
            return data;
        }
    }
}