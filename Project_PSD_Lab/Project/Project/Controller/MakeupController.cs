using Project_Lab.Handlers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Project_Lab.Controller
{
    public class MakeupController
    {
        public static String makeupInsert(int id, String name, int price, int weight, String typeName, String brandName)
        {
            String response = "";
            bool isValidate = false;
            int makeUpTypeID = MakeupTypeHandler.getTypeIDByName(typeName);
            int makeupBrandID = MakeupBrandHandler.getBrandIDByName(brandName);

            if (name.Length < 1 || name.Length > 99)
            {
                response = "makeup name must be between 1 and 99 alphabet";
                isValidate = true;
            }
            else if (price <= 1)
            {
                response = "makeup price must be more than 1";
                isValidate = true;
            }
            else if (weight >= 1500)
            {
                response = "makeup weight must be less than 1500 grams";
                isValidate = true;
            }
            else if (makeUpTypeID == null)
            {
                response = "makeup type must be filled";
                isValidate = true;
            }
            else if (makeupBrandID == null)
            {
                response = "makeup brand must be filled";
                isValidate = true;
            }

            if (isValidate == false)
            {
                response = MakeupHandler.makeupInsert(id, name, price, weight, makeUpTypeID, makeupBrandID);
            }
            return response;
        }

        public static String makeupUpdate(int id, String name, int price, int weight, String typeName, String brandName)
        {
            String response = "";
            bool isValidate = false;
            int makeUpTypeID = MakeupTypeHandler.getTypeIDByName(typeName);
            int makeupBrandID = MakeupBrandHandler.getBrandIDByName(brandName);

            if (name.Length < 1 || name.Length > 99)
            {
                response = "makeup name must be between 1 and 99 alphabet";
                isValidate = true;
            }
            else if (price <= 1)
            {
                response = "makeup price must be more than 1";
                isValidate = true;
            }
            else if (weight >= 1500)
            {
                response = "makeup weight must be less than 1500 grams";
                isValidate = true;
            }
            else if (makeUpTypeID == null)
            {
                response = "makeup type must be filled";
                isValidate = true;
            }
            else if (makeupBrandID == null)
            {
                response = "makeup brand must be filled";
                isValidate = true;
            }

            if (isValidate == false)
            {
                response = MakeupHandler.UpdateMakeupByID(id, name, price, weight, makeUpTypeID, makeupBrandID);
            }
            return response;
        }
    }
}