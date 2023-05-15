using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class CartFactory
    {
        public static Cart create(int CustomerID, int AlbumID, int Qty)
        {
            var x = new Cart();
            x.CustomerID = CustomerID;
            x.AlbumID = AlbumID;
            x.Qty = Qty;
            return x;
        }
    }
}