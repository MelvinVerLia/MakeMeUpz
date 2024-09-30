using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab.Factory
{
    public class TransactionDetailsFactory
    {
        public static TransactionDetail Create(int TransactionID, int MakeupID, int Quantity)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionID = TransactionID;
            td.MakeupID = MakeupID;
            td.Quantity = Quantity;
            return td;
        }
    }
}