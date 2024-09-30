using Project.Models;
using Project_Lab.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Repository
{
    public class UserRepository
    {
        private static MakeUpDatabaseEntities1 db = DatabaseSingleton.GetInstance();

        public static List<User> GetUsers()
        {
            return db.Users.ToList();
        }

        public static void Insert(int userID, String username, String userEmail, DateTime UserDOB, String gender, String role, String passwordUser)
        {
            User user = UserFactory.Create(userID, username, userEmail, UserDOB, gender, role, passwordUser);
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static int getLastUserID()
        {
            return (from x in db.Users select x.UserID).ToList().LastOrDefault();
        }

        public static List<User> getAllCustomers()
        {
            var users = GetUsers();
            return users.Where(x => x.UserRole == "Customer").ToList();
        }
        public static User login(String username, String password)
        {
            return (from x in db.Users where x.Username == username && x.UserPassword == password select x).FirstOrDefault();
        }

        public static String getRoleByID(int id)
        {
            return (from x in db.Users where x.UserID.Equals(id) select x.UserRole).FirstOrDefault();
        }

        public static User getUser(String Username)
        {
            User user = db.Users.Where(u => u.Username == Username).FirstOrDefault();
            return user;
        }
        public static String validateUsernameUnique(String username)
        {
            return (from x in db.Users where x.Username == username select x.Username).FirstOrDefault();
        }

        public static User searchUserByID(int id)
        {
            User user = db.Users.Find(id);
            return user;
        }

        public static void updateProfileByID(int id, String name, String email, String gender, DateTime dob)
        {
            User updateProfile = db.Users.Find(id);
            updateProfile.UserID = id;
            updateProfile.Username = name;
            updateProfile.UserGender = gender;
            updateProfile.UserDOB = dob;

            db.SaveChanges();
        }

        public static void updatePasswordByID(int id, String pass)
        {
            User updateProfile = db.Users.Find(id);
            updateProfile.UserID = id;
            updateProfile.UserPassword = pass;

            db.SaveChanges();
        }
    }
}