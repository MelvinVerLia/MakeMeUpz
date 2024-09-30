using Project_Lab.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Controller
{
    public class MakeupBrandController
    {
        public static String makeupBrandInsert(int id, String name, int rating)
        {
            String response = "";
            bool isValidate = false;

            if (name.Length < 1 || name.Length > 99)
            {
                response = "makeup type name must be between 1 and 99 alphabet";
                isValidate = true;
            }
            else if (rating < 0 || rating > 100)
            {
                response = "brand rating must be between 0 and 100";
                isValidate = true;
            }

            if (isValidate == false)
            {
                response = MakeupBrandHandler.makeupBrandInsert(id, name, rating);
            }
            return response;
        }

        public static String makeupBrandUpdate(int id, String name, int rating)
        {
            String response = "";
            bool isValidate = false;

            if (name.Length < 1 || name.Length > 99)
            {
                response = "makeup type name must be between 1 and 99 alphabet";
                isValidate = true;
            }
            else if (rating < 0 || rating > 100)
            {
                response = "brand rating must be between 0 and 100";
                isValidate = true;
            }

            if (isValidate == false)
            {
                response = MakeupBrandHandler.UpdateBrandByID(id, name, rating);
            }
            return response;
        }
    }
}