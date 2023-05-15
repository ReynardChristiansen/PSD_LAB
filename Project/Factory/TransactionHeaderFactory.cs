using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader create(int TransactionID, int CustomerID, System.DateTime TransactionDate)
        {
            var x = new TransactionHeader();
            x.TransactionID = TransactionID;
            x.CustomerID = CustomerID;
            x.TransactionDate = TransactionDate;
            return x;
        }
    }
}