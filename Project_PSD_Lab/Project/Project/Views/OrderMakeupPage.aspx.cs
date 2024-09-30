
using Project.Handlers;
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
    public partial class OrderMakeupPage : System.Web.UI.Page
    {
        private static User user;
        public List<Makeup> makeups = null;
        public List<Cart> cart = null;

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
                FetchMakeups();
                FetchCarts();
            }
        }

        public void FetchMakeups()
        {
            makeups = MakeupHandler.getAllMakeups();
            MakeUpGV.DataSource = makeups;
            MakeUpGV.DataBind();
        }

        public void FetchCarts()
        {
            cart = CartHandler.getUserCart(user.UserID);
            CartGV.DataSource = cart;
            CartGV.DataBind();
        }
        public int generateCartID()
        {
            int lastId = CartHandler.getLastCartID();
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

        public int generateTransactionID()
        {
            int id = user.UserID;
            int lastId = TransactionHeaderHandler.getLastUserTransactionID();
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
        protected void OrderButton_Click(object sender, EventArgs e)
        {
            int id = user.UserID;
            Button orderButton = (Button)sender;
            GridViewRow row = (GridViewRow)orderButton.NamingContainer;
            TextBox quantityTB = (TextBox)row.FindControl("QuantityTB");

            int makeupID = Convert.ToInt32(row.Cells[0].Text);

            int cartID = generateCartID();

            int quantity;
            Boolean isQuantityValid = int.TryParse(quantityTB.Text, out quantity);

            if (isQuantityValid == true && quantity > 0)
            {
                if(CartHandler.isMakeupInCart(id, makeupID))
                {
                    SuccessLbl.Text = "Item is already in the cart";
                    SuccessLbl.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    Makeup selectedMakeup = MakeupHandler.searchMakeupByID(makeupID);
                    CartHandler.cartInsert(cartID, id, makeupID, quantity);
                    Response.Redirect("~/Views/OrderMakeupPage.aspx");
                }
            }
            else
            {
                SuccessLbl.Text = "Quantity must be above 0";
                SuccessLbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void ClearCartButton_Click(object sender, EventArgs e)
        {
            int id = user.UserID;

            CartHandler.deleteAllUserCart(id);
            Response.Redirect("~/Views/OrderMakeupPage.aspx");
        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            int TransactionID = generateTransactionID();
            int UserID = user.UserID;
            DateTime date = DateTime.Now;
            String status = "Unhandled";

            TransactionHeaderHandler.insertTransaction(TransactionID, UserID, date, status);

            cart = CartHandler.getUserCart(UserID);

            foreach (var item in cart)
            {
                TransactionDetailHandler.insertTransaction(TransactionID, item.MakeupID, item.Quantity);
            }
            CartHandler.deleteAllUserCart(UserID);
            Response.Redirect("~/Views/HomePage.aspx");

        }
    }
}


