using Project.Models;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

namespace Project_Lab.Handlers
{
    public class MakeupTypeHandler
    {
        public static List<MakeupType> getAllTypes()
        {
            return MakeupTypeRepository.getAllTypes();
        }

        public static List<String> getTypeName()
        {
            return MakeupTypeRepository.getMakeupTypeName();
        }

        public static int getLastTypeID()
        {
            return MakeupTypeRepository.getLastTypeID();
        }

        public static int getTypeIDByName(string name)
        {
            return MakeupTypeRepository.GetMakeupTypeIDByName(name);
        }

        public static String GetTypeNameByID(int id)
        {
            return MakeupTypeRepository.GetMakeupTypeNameByID(id);
        }

        public static String makeupTypeInsert(int id, String name)
        {
            MakeupTypeRepository.insertType(id, name);
            return "Success";
        }


        public static void deleteType(int id)
        {
            MakeupType mt = MakeupTypeRepository.GetMakeupType(id);
            if (mt.Makeups.Count > 0)
            {
                List<Makeup> makeup = mt.Makeups.ToList();
                MakeupRepository.deleteMakeups(makeup);
            }
            MakeupTypeRepository.deleteMakeupType(id);
        }

        public static MakeupType searchTypeByID(int id)
        {
            return MakeupTypeRepository.searchTypeByID(id);
        }

        public static String UpdateTypeByID(int id, String name)
        {
            MakeupTypeRepository.UpdateTypeByID(id, name);
            return "Success";
        }
    }
}