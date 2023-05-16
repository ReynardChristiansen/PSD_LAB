using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Project.Repository
{
    public class CustomerRepository
    {
        static Kpop db = Singleton.getConnection();

        public static void save()
        {
            db.SaveChanges();
        }

        public static void add(Customer x)
        {
            db.Customers.Add(x);
            db.SaveChanges();
        }

        public static void remove(Customer x)
        {
            db.Customers.Remove(x);
            db.SaveChanges();
        }

  
        public static Customer find(string email)
        {
            return (from user in db.Customers where user.CustomerEmail == email select user).FirstOrDefault();
        }

        public static int NextID()
        {
            if (db.Customers.Count() == 0)
                return 0;
            return db.Customers.Max(x => x.CustomerID) + 1;
        }


    }
}