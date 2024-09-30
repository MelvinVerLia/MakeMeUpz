using Project.Models;
using Project.Repository;
using Project_Lab.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Handlers
{
    public class TransactionDetailHandler
    {
        public static void insertTransaction(int transactionid, int makeupid, int quantity)
        {
            TransactionDetailRepository.insertTransaction(transactionid, makeupid, quantity);
        }

        public static List<TransactionDetail> getAllTransactions()
        {
            return TransactionDetailRepository.getAllTransactions();
        }

        public static List<TransactionDetail> getUserTransaction(int id)
        {
            return TransactionDetailRepository.getUserTransaction(id);
        }
    }
}