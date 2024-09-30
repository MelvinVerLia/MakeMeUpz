using Project.Models;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Handlers
{
    public class MakeupBrandHandler
    {
        public static List<MakeupBrand> getAllBrandsDescend()
        {
            return MakeupBrandRepository.getAllBrandsDescending();
        }

        public static List<String> getBrandName()
        {
            return MakeupBrandRepository.getMakeupBrandName();
        }

        public static int getLastBrandID()
        {
            return MakeupBrandRepository.getLastBrandID();
        }

        public static int getBrandIDByName(string name)
        {
            return MakeupBrandRepository.GetMakeupBrandIDByName(name);
        }

        public static String makeupBrandInsert(int id, String name, int rating)
        {
            MakeupBrandRepository.insertBrand(id, name, rating);
            return "Success";
        }

        public static void deleteBrand(int id)
        {
            MakeupBrand mt = MakeupBrandRepository.GetMakeupBrand(id);
            if (mt.Makeups.Count > 0)
            {
                List<Makeup> makeup = mt.Makeups.ToList();
                MakeupRepository.deleteMakeups(makeup);
            }
            MakeupBrandRepository.deleteMakeupBrand(id);
        }

        public static MakeupBrand searchBrandByID(int id)
        {
            return MakeupBrandRepository.searchBrandByID(id);
        }


        public static String GetMakeupBrandNameByID(int id)
        {
            return MakeupBrandRepository.GetMakeupBrandNameByID(id);
        }

        public static String UpdateBrandByID(int id, String name, int rating)
        {
            MakeupBrandRepository.UpdateBrandByID(id, name, rating);
            return "Success";
        }
    }
}