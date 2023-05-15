using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class CustomerFactory
    {
        public static Customer create(int CustomerID, string CustomerEmail, String CustomerPassword, string CustomerAddress, string CustomerGender, string CustomerRole)
        {
            var x = new Customer();
            x.CustomerID = CustomerID;
            x.CustomerEmail = CustomerEmail;
            x.CustomerPassword = CustomerPassword;
            x.CustomerAddress = CustomerAddress;
            x.CustomerGender = CustomerGender;
            x.CustomerRole = CustomerRole;
            return x;
        }
    }
}