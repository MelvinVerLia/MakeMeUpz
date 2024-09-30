using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Repository
{
    public class DatabaseSingleton
    {
        private static MakeUpDatabaseEntities1 db = null;

        public static MakeUpDatabaseEntities1 GetInstance()
        {
            if (db == null)
            {
                db = new MakeUpDatabaseEntities1();
            }
            return db;
        }
    }
}