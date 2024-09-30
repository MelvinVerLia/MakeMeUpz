using Project.Models;
using Project_Lab.Factory;
using Project_Lab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Handlers
{
    public class TransactionHeaderHandler
    {
        public static List<TransactionHeader> getAllTransactions()
        {
            return TransactionHeaderRepository.getAllTransactions();
        }

        public static List<TransactionHeader> getUserTransaction(int userId)
        {
            return TransactionHeaderRepository.getUserTransaction(userId);
        }

        public static void insertTransaction(int transactionid, int userID, DateTime date, String status)
        {
            TransactionHeaderRepository.insertTransaction(transactionid, userID, date, status);
        }
        public static int getLastUserTransactionID()
        {
            return TransactionHeaderRepository.getLastUserTransactionID();
        }

        public static void UpdateStatusByID(int id, String status)
        {
            TransactionHeaderRepository.UpdateStatusByID(id, status);
        }
    }
}