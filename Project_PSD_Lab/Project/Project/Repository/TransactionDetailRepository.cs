using Project.Models;
using Project_Lab.Factory;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class TransactionDetailRepository

    {
        private static MakeUpDatabaseEntities1 db = DatabaseSingleton.GetInstance();
        public static void insertTransaction(int transactionid, int makeupid, int quantity)
        {
            TransactionDetail transaction = TransactionDetailsFactory.Create(transactionid, makeupid, quantity);
            db.TransactionDetails.Add(transaction);
            db.SaveChanges();
        }

        public static List<TransactionDetail> getAllTransactions()
        {
            return db.TransactionDetails.ToList();
        }

        public static List<TransactionDetail> getUserTransaction(int id)
        {
            return (from x in db.TransactionDetails where x.TransactionID == id select x).ToList();
        }
    }
}