using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Controller
{
    public class LoginController
    {
        public static string authentication(string CustomerEmail, string CustomerPassword)
        {
            Customer x = CustomerRepository.find_Email_Password(CustomerEmail, CustomerPassword);

            if (CustomerEmail.Equals(""))
            {
                return "Email must be filled";
            }
            else if (CustomerPassword.Equals(""))
            {
                return "Password must be filled";
            }
            else if (x == null)
            {
                return "incorect username or password";
            }


            return "";
        }

        public static Customer getUser(string CustomerEmail,string CustomerPassword)
        {
            Customer user = CustomerRepository.find_Email_Password(CustomerEmail, CustomerPassword);
            return user;
        }

    }
}