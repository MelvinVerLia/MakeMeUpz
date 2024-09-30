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
    public partial class ProfilePage : System.Web.UI.Page
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
                nameTB.Text = user.Username;
                emailTB.Text = user.UserEmail;
                String gender = user.UserGender;
                if (gender == "Male")
                {
                    MaleRadio.Checked = true;
                }
                else if (gender == "Female")
                {
                    FemaleRadio.Checked = true;
                }
                DOBLbl.Text = user.UserDOB.ToString();
            }
        }


        protected void ProfileBtn_Click(object sender, EventArgs e)
        {
            int updateID = user.UserID;
            String username = nameTB.Text;
            String email = emailTB.Text;
            String gender = "";
            DateTime dob = DOBTB.SelectedDate;

            if (MaleRadio.Checked)
            {
                gender = "Male";
            }
            else if (FemaleRadio.Checked)
            {
                gender = "Female";
            }

            ErrorLabelProfile.Text = UserController.updateProfile(updateID, username, email, gender, dob);

            if (ErrorLabelProfile.Text == "Success")
            {
                Response.Redirect("~/Views/ProfilePage.aspx");
            }
        }

        protected void PassBtn_Click(object sender, EventArgs e)
        {
            int updateID = user.UserID;
            String newPass = newPassTB.Text;
            String oldPass = oldPassTB.Text;

            user = UserHandler.searchUserByID(updateID);

            if (user.UserPassword != oldPass)
            {
                ErrorLabelPassword.Text = "Old password is wrong";
            }

            ErrorLabelPassword.Text = UserController.updatePasswordByID(updateID, oldPass, newPass, user);

            if (ErrorLabelPassword.Text == "Success")
            {
                Response.Redirect("~/Views/ProfilePage.aspx");
            }
        }
    }
}
