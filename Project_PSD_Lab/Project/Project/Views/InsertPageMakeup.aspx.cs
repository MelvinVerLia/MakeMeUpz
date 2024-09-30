using Project.Models;
using Project_Lab.Controller;
using Project_Lab.Handlers;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab.Views
{
    public partial class InsertPageMakeup : System.Web.UI.Page
    {
        private static User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<String> makeupTypeName = MakeupTypeHandler.getTypeName();
            List<String> makeupBrandName = MakeupBrandHandler.getBrandName();

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
                FetchBrandName();
                FetchTypeName();
            }
        }

        public void FetchTypeName()
        {
            List<String> makeupTypeName = MakeupTypeHandler.getTypeName();
            TypeDD.DataSource = makeupTypeName;
            TypeDD.DataBind();
        }

        public void FetchBrandName()
        {
            List<String> makeupBrandName = MakeupBrandHandler.getBrandName();
            BrandDD.DataSource = makeupBrandName;
            BrandDD.DataBind();
        }
        public int generateID()
        {
            int lastId = MakeupHandler.getLastMakeupID();
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
            int price;
            int weight;
            bool isPriceValid = int.TryParse(priceTB.Text, out price);
            bool isWeightValid = int.TryParse(weightTB.Text, out weight);

            String makeupTypeName = TypeDD.Text;
            String makeupBrandName = BrandDD.Text;

            ErrLbl.Text = MakeupController.makeupInsert(id, name, price, weight, makeupTypeName, makeupBrandName);

            if (ErrLbl.Text == "Success")
            {
                Response.Redirect("~/Views/ManageMakeupPage.aspx");
            }
        }

        protected void BackBtb_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/ManageMakeupPage.aspx");
        }
    }
}