using Project.Models;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Handlers
{
    public class MakeupHandler
    {
        public static List<Makeup> getAllMakeups()
        {
            return MakeupRepository.getAllMakeups();
        }

        public static int getLastMakeupID()
        {
            return MakeupRepository.getLastMakeupID();
        }

        public static String makeupInsert(int id, String name, int price, int weight, int typeID, int BrandID)
        {
            MakeupRepository.insert(id, name, price, weight, typeID, BrandID);
            return "Success";
        }

        public static void deleteMakeup(int id)
        {
            CartRepository.deleteCartsByMakeupID(id);

            Makeup mk = MakeupRepository.searchMakeupByID(id);
            MakeupRepository.deleteMakeup(mk);
        }

        public static Makeup searchMakeupByID(int id)
        {
            return MakeupRepository.searchMakeupByID(id);
        }

        public static String GetMakeupTypeNameByID(int id)
        {
            return MakeupTypeRepository.GetMakeupTypeNameByID(id);
        }

        public static String UpdateMakeupByID(int id, String name, int price, int weight, int makeUpTypeID, int makeupBrandID)
        {
            MakeupRepository.UpdateMakeupByID(id, name, price, weight, makeUpTypeID, makeupBrandID);
            return "Success";
        }

    }
}