using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Factory
{
    public class MakeupBrandFactory
    {
        public static MakeupBrand Create(int id, String name, int rating)
        {
            MakeupBrand mb = new MakeupBrand();
            mb.MakeupBrandID = id;
            mb.MakeupBrandName = name;
            mb.MakeupBrandRating = rating;
            return mb;
        }
    }
}