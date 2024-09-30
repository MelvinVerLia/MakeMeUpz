using Project.Models;
using Project_Lab.Handlers;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Project_Lab.Controller
{
    public class UserController
    {
        public static String UserLogin(String username, String password)
        {
            String response = "";

            if (username == "" || password == "")
            {
                response = "Please fill all field";

            }
            else
            {
                response = UserHandler.UserLogin(username, password);
            }
            return response;
        }

        public static String UserRegister(int userID, String username, String email, DateTime DoB, String gender, String role, String password, String confirmPass)
        {
            String pattern = @"^(?=.*[a-zA-Z])(?=.*\d)[a-zA-Z0-9]+$";
            Regex regex = new Regex(pattern);
            Boolean isValidate = false;
            String response = "";
            String validateUnique = UserHandler.validateUnique(username);

            if (username == "")
            {
                response = "username cannot be empty";
                isValidate = true;
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                response = "username must be between 5 and 15 alphabet";
                isValidate = true;
            }
            else if (username.Equals(validateUnique))
            {
                response = "username is not unique";
                isValidate = true;
            }
            else if (!email.EndsWith(".com"))
            {
                response = "email must end with .com";
                isValidate = true;
            }
            else if (gender == "")
            {
                response = "gender must be filled";
                isValidate = true;
            }
            else if (!regex.IsMatch(password))
            {
                response = "password must be alphanumeric";
                isValidate = true;
            }
            else if (password != confirmPass)
            {
                response = "password is not the same as confirm password";
                isValidate = true;
            }
            else if (password == "")
            {
                response = "password cannot be empty";
                isValidate = true;
            }
            else if (DoB == DateTime.MinValue)
            {
                response = "Date of birth cannot be empty";
                isValidate = true;
            }

            if (isValidate == false)
            {
                response = UserHandler.UserRegister(userID, username, email, DoB, gender, role, password);
            }
            return response;
        }

        public static String updateProfile(int userID, String username, String email, String gender, DateTime dob)
        {
            String response = "";
            Boolean isValidate = false;

            String validateUnique = UserHandler.validateUnique(username);

            if (username == "")
            {
                response = "username cannot be empty";
                isValidate = true;
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                response = "username must be between 5 and 15 alphabet";
                isValidate = true;
            }
            else if (username.Equals(validateUnique))
            {
                response = "username is not unique";
                isValidate = true;
            }
            else if (!email.EndsWith(".com"))
            {
                response = "email must end with .com";
                isValidate = true;
            }
            else if (gender == "")
            {
                response = "gender must be filled";
                isValidate = true;
            }
            else if (dob == DateTime.MinValue)
            {
                response = "Date of birth cannot be empty";
                isValidate = true;
            }

            if (isValidate == false)
            {
                response = UserHandler.updateProfileByID(userID, username, email, gender, dob);
            }
            return response;
        }

        public static String updatePasswordByID(int id, String oldPass, String newPass, User user)
        {
            String response = "";
            String pattern = @"^[a-zA-Z0-9]+$";
            Regex regex = new Regex(pattern);
            Boolean isValidate = false;

            if (user.UserPassword != oldPass)
            {
                response = "Old password is wrong";
                isValidate = true;
            }
            else if (!regex.IsMatch(newPass))
            {
                response = "New password must be alphanumeric";
                isValidate = true;
            }
            else if (newPass == "")
            {
                response = "New password cannot be empty";
                isValidate = true;
            }

            if (isValidate == false)
            {
                response = UserHandler.updatePasswordByID(id, newPass);
            }
            return response;
        }
    }
}