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
    public partial class UpdateMakeupBrandPage : System.Web.UI.Page
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


            if (IsPostBack == false)
            {
                int ID = Convert.ToInt32(Request.QueryString["id"]);

                MakeupBrand updateBrand = MakeupBrandHandler.searchBrandByID(ID);

                if (updateBrand != null)
                {
                    nameTB.Text = updateBrand.MakeupBrandName;
                    RatingTB.Text = updateBrand.MakeupBrandRating.ToString();
                }
                else
                {
                    Response.Redirect("~/Views/ManageMakeupPage.aspx");
                }
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int updateID = Convert.ToInt32(Request.QueryString["id"]);
            String brandName = nameTB.Text;
            int rating = Convert.ToInt32(RatingTB.Text);

            ErrLbl.Text = MakeupBrandController.makeupBrandUpdate(updateID, brandName, rating);

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