using Project.Models;
using Project_Lab.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Web;

namespace Project_Lab.Repository
{

    public class CartRepository
    {
        private static MakeUpDatabaseEntities1 db = DatabaseSingleton.GetInstance();

        public static List<Cart> getAllCarts()
        {
            return db.Carts.ToList();
        }

        public static List<Cart> getUserCart(int userId)
        {
            return (from x in db.Carts where x.UserID == userId select x).ToList();
        }

        public static void insert(int cartID, int userID, int makeupID, int quantity)
        {
            Cart cart = CartsFactory.Create(cartID, userID, makeupID, quantity);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public static int getLastCartID()
        {
            return (from x in db.Carts select x.CartID).ToList().LastOrDefault();
        }

        public static void deleteAllUserCart(int userID)
        {
            List<Cart> deleteCarts = (from x in db.Carts where x.UserID == userID select x).ToList();

            if (deleteCarts.Any())
            {
                foreach (Cart cart in deleteCarts)
                {
                    db.Carts.Remove(cart);
                }
                db.SaveChanges();
            }
        }
        public static void deleteCartsByMakeupID(int makeupId)
        {
            List<Cart> cartsToDelete = (from x in db.Carts where x.MakeupID == makeupId select x).ToList();

            if (cartsToDelete.Any())
            {
                db.Carts.RemoveRange(cartsToDelete);
                db.SaveChanges();
            }
        }

        public static bool isMakeupInCart(int userID, int makeupID)
        {
            foreach (var cartItem in getUserCart(userID))
            {
                if (cartItem.UserID == userID && cartItem.MakeupID == makeupID)
                {
                    return true;
                }
            }
            return false;   
        }
    }
}