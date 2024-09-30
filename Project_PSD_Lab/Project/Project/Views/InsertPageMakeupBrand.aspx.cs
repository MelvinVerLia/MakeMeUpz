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
    public partial class InsertPageMakeupBrand : System.Web.UI.Page
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
            int lastId = MakeupBrandHandler.getLastBrandID();
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
            int rating;
            Boolean isPriceValid = int.TryParse(RatingTB.Text, out rating);

            ErrLbl.Text = MakeupBrandController.makeupBrandInsert(id, name, rating);

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