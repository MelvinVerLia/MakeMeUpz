using Project.Models;
using Project_Lab.Factory;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Handlers
{
    public class UserHandler
    {
        public static String UserLogin(String username, String password)
        {
            User user = UserRepository.login(username, password);
            return user != null ? "" : "Username or Password incorrect";
        }
        public static int getLastUserID()
        {
            return UserRepository.getLastUserID();
        }

        public static String UserRegister(int userID, String username, String email, DateTime DoB, String gender, String role, String password)
        {
            UserRepository.Insert(userID, username, email, DoB, gender, role, password);
            return "Success";
        }

        public static List<User> getAllCustomers()
        {
            return UserRepository.getAllCustomers();
        }

        public static User getUser(String Username)
        {
            return UserRepository.getUser(Username);
        }
        public static String validateUnique(String name)
        {
            return UserRepository.validateUsernameUnique(name);
        }

        public static List<User> GetUsers()
        {
            return UserRepository.GetUsers();
        }

        public static User searchUserByID(int id)
        {
            return UserRepository.searchUserByID(id);
        }

        public static String updateProfileByID(int id, String name, String email, String gender, DateTime dob)
        {
            UserRepository.updateProfileByID(id, name, email, gender, dob);
            return "Success";
        }

        public static String updatePasswordByID(int id, String pass)
        {
            UserRepository.updatePasswordByID(id, pass);
            return "Success";
        }

    }
}