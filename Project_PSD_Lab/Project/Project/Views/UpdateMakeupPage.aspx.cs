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
    public partial class UpdateMakeupPage : System.Web.UI.Page
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

                Makeup updateMakeup = MakeupHandler.searchMakeupByID(ID);


                if (updateMakeup != null)
                {
                    nameTB.Text = updateMakeup.MakeupName;
                    priceTB.Text = updateMakeup.MakeupPrice.ToString();
                    weightTB.Text = updateMakeup.MakeupWeight.ToString();
                    TypeDD.SelectedValue = MakeupTypeHandler.GetTypeNameByID(ID);
                    BrandDD.SelectedValue = MakeupBrandHandler.GetMakeupBrandNameByID(ID);
                    FetchBrand();
                    FetchType();
                }
                else
                {
                    Response.Redirect("~/Views/ManageMakeupPage.aspx");
                }
            }
        }

        public void FetchType()
        {
            List<String> makeupTypeName = MakeupTypeHandler.getTypeName();
            TypeDD.DataSource = makeupTypeName;
            TypeDD.DataBind();
        }

        public void FetchBrand()
        {
            List<String> makeupBrandName = MakeupBrandHandler.getBrandName();
            BrandDD.DataSource = makeupBrandName;
            BrandDD.DataBind();
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int updateID = Convert.ToInt32(Request.QueryString["id"]);
            String makeupName = nameTB.Text;
            int price;
            int weight;
            bool isPriceValid = int.TryParse(priceTB.Text, out price);
            bool isWeightValid = int.TryParse(weightTB.Text, out weight);

            String makeupTypeName = TypeDD.Text;
            int makeupTypeID = MakeupTypeRepository.GetMakeupTypeIDByName(makeupTypeName);
            String makeupBrandName = BrandDD.Text;
            int makeupBrandID = MakeupBrandRepository.GetMakeupBrandIDByName(makeupBrandName);

            ErrLbl.Text = MakeupController.makeupUpdate(updateID, makeupName, price, weight, makeupTypeName, makeupBrandName);

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