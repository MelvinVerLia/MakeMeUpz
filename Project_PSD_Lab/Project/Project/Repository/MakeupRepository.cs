using Project.Models;
using Project_Lab.Factory;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Project_Lab.Repository
{
    public class MakeupRepository
    {
        private static MakeUpDatabaseEntities1 db = DatabaseSingleton.GetInstance();

        public static List<Makeup> getAllMakeups()
        {
            return db.Makeups.ToList();
        }

        public static List<Makeup> getMakeupByTypeID(int typeID)
        {
            return (from x in db.Makeups where x.MakeupTypeID == typeID select x).ToList();
        }

        public static List<Makeup> getMakeupByBrandID(int brandID)
        {
            return (from x in db.Makeups where x.MakeupBrandID == brandID select x).ToList();
        }
        public static void deleteMakeups(List<Makeup> makeup)
        {
            db.Makeups.RemoveRange(makeup);
            db.SaveChanges();
        }

        public static void deleteMakeup(Makeup makeup)
        {
            db.Makeups.Remove(makeup);
            db.SaveChanges();
        }

        public static int getLastMakeupID()
        {
            return (from x in db.Makeups select x.MakeupID).ToList().LastOrDefault();
        }
        public static void insert(int id, String name, int price, int weight, int makeUpTypeID, int makeupBrandID)
        {
            Makeup makeup = MakeupFactory.Create(id, name, price, weight, makeUpTypeID, makeupBrandID);
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }

        public static Makeup searchMakeupByID(int id)
        {
            Makeup mk = db.Makeups.Find(id);
            return mk;
        }

        public static void UpdateMakeupByID(int id, String name, int price, int weight, int makeUpTypeID, int makeupBrandID)
        {
            Makeup updateMakeup = db.Makeups.Find(id);
            updateMakeup.MakeupID = id;
            updateMakeup.MakeupName = name;
            updateMakeup.MakeupPrice = price;
            updateMakeup.MakeupWeight = weight;
            updateMakeup.MakeupTypeID = makeUpTypeID;
            updateMakeup.MakeupBrandID = makeupBrandID;
            db.SaveChanges();
        }
    }
}