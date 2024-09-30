using Project_Lab.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Controller
{
    public class MakeupTypeController
    {
        public static String makeupTypeInsert(int id, String name)
        {
            String response = "";
            bool isValidate = false;

            if (name.Length < 1 || name.Length > 99)
            {
                response = "makeup type name must be between 1 and 99 alphabet";
                isValidate = true;
            }

            if (isValidate == false)
            {
                response = MakeupTypeHandler.makeupTypeInsert(id, name);
            }
            return response;
        }

        public static String makeupTypeUpdate(int id, String name)
        {
            String response = "";
            bool isValidate = false;

            if (name.Length < 1 || name.Length > 99)
            {
                response = "makeup type name must be between 1 and 99 alphabet";
                isValidate = true;
            }

            if (isValidate == false)
            {
                response = MakeupTypeHandler.UpdateTypeByID(id, name);
            }
            return response;
        }
    }
}