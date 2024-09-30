using Project.Models;
using Project_Lab.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Repository
{

    public class MakeupBrandRepository
    {
        private static MakeUpDatabaseEntities1 db = DatabaseSingleton.GetInstance();

        public static List<MakeupBrand> getAllBrandsDescending()
        {
            return db.MakeupBrands.OrderByDescending(brand => brand.MakeupBrandRating).ToList();
        }

        public static List<String> getMakeupBrandName()
        {
            return (from x in db.MakeupBrands select x.MakeupBrandName).ToList();
        }

        public static MakeupBrand GetMakeupBrand(int id)
        {
            return (from x in db.MakeupBrands where x.MakeupBrandID == id select x).FirstOrDefault();
        }

        public static int getLastBrandID()
        {
            return (from x in db.MakeupBrands select x.MakeupBrandID).ToList().LastOrDefault();
        }

        public static int GetMakeupBrandIDByName(String name)
        {
            return (from x in db.MakeupBrands where x.MakeupBrandName.Equals(name) select x.MakeupBrandID).FirstOrDefault();
        }

        public static String GetMakeupBrandNameByID(int id)
        {
            return (from x in db.MakeupBrands where x.MakeupBrandID.Equals(id) select x.MakeupBrandName).FirstOrDefault();
        }

        public static void deleteMakeupBrand(int id)
        {
            MakeupBrand mb = db.MakeupBrands.Find(id);
            db.MakeupBrands.Remove(mb);
            db.SaveChanges();
        }

        public static void insertBrand(int id, String name, int rating)
        {
            MakeupBrand makeup = MakeupBrandFactory.Create(id, name, rating);
            db.MakeupBrands.Add(makeup);
            db.SaveChanges();
        }

        public static MakeupBrand searchBrandByID(int id)
        {
            MakeupBrand mk = db.MakeupBrands.Find(id);
            return mk;
        }

        public static void UpdateBrandByID(int id, String name, int rating)
        {
            MakeupBrand updateBrand = db.MakeupBrands.Find(id);
            updateBrand.MakeupBrandID = id;
            updateBrand.MakeupBrandName = name;
            updateBrand.MakeupBrandRating = rating;
            db.SaveChanges();
        }

    }
}