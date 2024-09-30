using Project.Models;
using Project_Lab.Controller;
using Project_Lab.Handlers;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab.Views
{
    public partial class UpdateMakeupTypePage : System.Web.UI.Page
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

                MakeupType updateType = MakeupTypeHandler.searchTypeByID(ID);

                if (updateType != null)
                {
                    nameTB.Text = updateType.MakeupTypeName;
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
            String makeupName = nameTB.Text;

            ErrLbl.Text = MakeupTypeController.makeupTypeUpdate(updateID, makeupName);

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