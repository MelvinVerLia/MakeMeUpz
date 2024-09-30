using Project.Models;
using Project_Lab.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Repository
{

    public class MakeupTypeRepository
    {
        private static MakeUpDatabaseEntities1 db = DatabaseSingleton.GetInstance();

        public static List<MakeupType> getAllTypes()
        {
            return db.MakeupTypes.ToList();
        }

        public static int getLastTypeID()
        {
            return (from x in db.MakeupTypes select x.MakeupTypeID).ToList().LastOrDefault();
        }

        public static MakeupType GetMakeupType(int id)
        {
            return db.MakeupTypes.Find(id);
        }

        public static void deleteMakeupType(int id)
        {
            MakeupType mt = db.MakeupTypes.Find(id);
            db.MakeupTypes.Remove(mt);
            db.SaveChanges();
        }
        public static List<String> getMakeupTypeName()
        {
            return (from x in db.MakeupTypes select x.MakeupTypeName).ToList();
        }

        public static int GetMakeupTypeIDByName(String name)
        {
            return (from x in db.MakeupTypes where x.MakeupTypeName.Equals(name) select x.MakeupTypeID).FirstOrDefault();
        }

        public static String GetMakeupTypeNameByID(int id)
        {
            return (from x in db.MakeupTypes where x.MakeupTypeID.Equals(id) select x.MakeupTypeName).FirstOrDefault();
        }

        public static void insertType(int id, String name)
        {
            MakeupType makeup = MakeupTypeFactory.Create(id, name);
            db.MakeupTypes.Add(makeup);
            db.SaveChanges();
        }

        public static MakeupType searchTypeByID(int id)
        {
            MakeupType mk = db.MakeupTypes.Find(id);
            return mk;
        }

        public static void UpdateTypeByID(int id, String name)
        {
            MakeupType updateType = db.MakeupTypes.Find(id);
            updateType.MakeupTypeID = id;
            updateType.MakeupTypeName = name;
            db.SaveChanges();
        }

    }
}