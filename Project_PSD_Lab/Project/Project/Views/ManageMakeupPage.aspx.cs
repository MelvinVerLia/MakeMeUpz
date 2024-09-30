using Project.Models;
using Project_Lab.Handlers;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab.Views
{
    public partial class ManageMakeupPage : System.Web.UI.Page
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
            int currentID = user.UserID;
            user = UserHandler.searchUserByID(currentID);

            if (IsPostBack == false)
            {
                FetchMakeups();
                FetchBrand();
                FetchType();
            }
        }

        public void FetchMakeups()
        {
            List<Makeup> makeup = MakeupHandler.getAllMakeups();
            MakeUpGV.DataSource = makeup;
            MakeUpGV.DataBind();
        }

        public void FetchType()
        {
            List<MakeupType> mt = MakeupTypeHandler.getAllTypes();
            MakeUpTypeGV.DataSource = mt;
            MakeUpTypeGV.DataBind();
        }

        public void FetchBrand()
        {
            List<MakeupBrand> mb = MakeupBrandHandler.getAllBrandsDescend();
            MakeUpBrandGV.DataSource = mb;
            MakeUpBrandGV.DataBind();
        }

        protected void MakeUpGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow GV = MakeUpGV.Rows[e.NewEditIndex];
            String id = GV.Cells[0].Text;
            Response.Redirect("~/Views/UpdateMakeupPage.aspx?id=" + id);
        }

        protected void MakeUpGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow GV = MakeUpGV.Rows[e.RowIndex];
            int id = Convert.ToInt32(GV.Cells[0].Text);

            MakeupHandler.deleteMakeup(id);
            FetchMakeups();
        }

        protected void MakeupInsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertPageMakeup.aspx");
        }

        protected void TypeInsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertPageMakeupType.aspx");
        }

        protected void BrandInsertBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/InsertPageMakeupBrand.aspx");

        }

        protected void MakeUpTypeGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow GV = MakeUpTypeGV.Rows[e.RowIndex];
            String id = GV.Cells[0].Text;
            MakeupTypeHandler.deleteType(Convert.ToInt32(id));
            FetchMakeups();
            FetchType();
        }

        protected void MakeUpTypeGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow GV = MakeUpTypeGV.Rows[e.NewEditIndex];
            String id = GV.Cells[0].Text;
            Response.Redirect("~/Views/UpdateMakeupTypePage.aspx?id=" + id);
        }

        protected void MakeUpBrandGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow GV = MakeUpBrandGV.Rows[e.NewEditIndex];
            String id = GV.Cells[0].Text;
            Response.Redirect("~/Views/UpdateMakeupBrandPage.aspx?id=" + id);
        }

        protected void MakeUpBrandGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow GV = MakeUpBrandGV.Rows[e.RowIndex];
            String id = GV.Cells[0].Text;
            MakeupBrandHandler.deleteBrand(Convert.ToInt32(id));
            FetchMakeups();
            FetchBrand();
        }
    }
}