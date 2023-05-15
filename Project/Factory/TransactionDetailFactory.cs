using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail create(int TransactionID, int AlbumID, int Qty)
        {
            var x = new TransactionDetail();
            x.TransactionID = TransactionID;
            x.AlbumID = AlbumID;
            x.Qty = Qty;
            return x;
        }
    }
}