using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Factory
{
    public class UserFactory
    {
        public static User Create(int userID, String username, String userEmail, DateTime UserDOB, String gender,
            String role, String passwordUser)
        {
            User user = new User();
            user.UserID = userID;
            user.Username = username;
            user.UserEmail = userEmail;
            user.UserDOB = UserDOB;
            user.UserGender = gender;
            user.UserRole = role;
            user.UserPassword = passwordUser;

            return user;
        }
    }
}