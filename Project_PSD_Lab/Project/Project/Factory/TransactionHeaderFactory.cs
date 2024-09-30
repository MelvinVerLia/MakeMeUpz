using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int transactionid, int userID, DateTime date, String status)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionID = transactionid;
            th.UserID = userID;
            th.TransactionDate = date;
            th.Status = status;
            return th;
        }
    }
}