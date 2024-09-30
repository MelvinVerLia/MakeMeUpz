using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Factory
{
    public class CartsFactory
    {
        public static Cart Create(int cartID, int userId, int makeupID, int quantity)
        {
            Cart cart = new Cart();
            cart.CartID = cartID;
            cart.UserID = userId;
            cart.MakeupID = makeupID;
            cart.Quantity = quantity;
            return cart;
        }
    }
}