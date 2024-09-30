using Project_Lab.Controller;
using Project_Lab.Handlers;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Lab.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int generateUserID()
        {
            int lastId = UserHandler.getLastUserID();
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

        protected void Register_Click(object sender, EventArgs e)
        {
            int userID = generateUserID();
            String username = usernameTB.Text;
            String email = emailTB.Text;
            String gender = "";

            String password = passwordTB.Text;
            String confirmPass = confPassTB.Text;
            DateTime DoB = DOBTB.SelectedDate;

            String role = "Customer";

            if (MaleRadio.Checked)
            {
                gender = "Male";
            }
            else if (FemaleRadio.Checked)
            {
                gender = "Female";
            }

            ErrorLabel.Text = UserController.UserRegister(userID, username, email, DoB, gender, role, password, confirmPass);
            if (ErrorLabel.Text == "Success")
            {
                Response.Redirect("~/Views/LoginPage.aspx");
            }

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}