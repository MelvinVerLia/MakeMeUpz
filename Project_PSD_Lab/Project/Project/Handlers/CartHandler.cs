using Project.Models;
using Project_Lab.Factory;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Handlers
{
    public class CartHandler
    {
        public static List<Cart> getAllCarts()
        {
            return CartRepository.getAllCarts();
        }

        public static List<Cart> getUserCart(int userId)
        {
            return CartRepository.getUserCart(userId);
        }

        public static void cartInsert(int cartID, int userID, int makeupID, int quantity)
        {
            CartRepository.insert(cartID, userID, makeupID, quantity);
        }

        public static int getLastCartID()
        {
            return CartRepository.getLastCartID();
        }

        public static void deleteAllUserCart(int userID)
        {
            CartRepository.deleteAllUserCart(userID);
        }

        public static bool isMakeupInCart(int userID, int makeupID)
        {
            return CartRepository.isMakeupInCart(userID, makeupID);
        }

    }
}