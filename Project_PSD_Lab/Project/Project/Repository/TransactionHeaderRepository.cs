using Project.Models;
using Project_Lab.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Repository
{
    public class TransactionHeaderRepository
    {
        private static MakeUpDatabaseEntities1 db = DatabaseSingleton.GetInstance();

        public static List<TransactionHeader> getAllTransactions()
        {
            return db.TransactionHeaders.ToList();
        }

        public static List<TransactionHeader> getUserTransaction(int userId)
        {
            return (from x in db.TransactionHeaders where x.UserID == userId select x).ToList();
        }

        public static void insertTransaction(int transactionid, int userID, DateTime date, String status)
        {
            TransactionHeader transaction = TransactionHeaderFactory.Create(transactionid, userID, date, status);
            db.TransactionHeaders.Add(transaction);
            db.SaveChanges();
        }
        public static int getLastUserTransactionID()
        {
            return (from x in db.TransactionHeaders select x.TransactionID).ToList().LastOrDefault();
        }
        public static void UpdateStatusByID(int id, String status)
        {
            TransactionHeader transaction = db.TransactionHeaders.Find(id);
            transaction.Status = status;
            db.SaveChanges();
        }
    }
}