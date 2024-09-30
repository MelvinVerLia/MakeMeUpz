using Project.Models;
using Project_Lab.Controller;
using Project_Lab.Handlers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab.Views
{
    public partial class InsertPageMakeupType : System.Web.UI.Page
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
        }

        public int generateID()
        {
            int lastId = MakeupTypeHandler.getLastTypeID();
            if (lastId == null)
            {
                lastId = 1;
            }
            else
            {
                lastId = lastId + 1;
            }
            return lastId;
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
        {
            int id = generateID();
            String name = nameTB.Text;

            ErrLbl.Text = MakeupTypeController.makeupTypeInsert(id, name);

            if (ErrLbl.Text == "Success")
            {
                Response.Redirect("~/Views/ManageMakeupPage.aspx");
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }
    }
}