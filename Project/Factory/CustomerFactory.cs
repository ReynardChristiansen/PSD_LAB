using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class CustomerFactory
    {
        public static Customer create(int CustomerID, string CustomerName, string CustomerEmail, string CustomerPassword, string CustomerAddress, string CustomerGender, string CustomerRole)
        {
            var x = new Customer();
            x.CustomerID = CustomerID;
            x.CustomerName = CustomerName;
            x.CustomerEmail = CustomerEmail;
            x.CustomerPassword = CustomerPassword;
            x.CustomerAddress = CustomerAddress;
            x.CustomerGender = CustomerGender;
            x.CustomerRole = CustomerRole;
            return x;
        }
    }
}