using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Factory
{
    public class MakeupTypeFactory
    {
        public static MakeupType Create(int id, String name)
        {
            MakeupType type = new MakeupType();
            type.MakeupTypeID = id;
            type.MakeupTypeName = name;
            return type;
        }
    }
}