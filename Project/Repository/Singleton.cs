using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Repository
{
    public class Singleton
    {
        private static Kpop db = null;
        private Singleton()
        {

        }

        public static Kpop getConnection()
        {
            if(db == null)
            {
                db = new Kpop();
            }
            return db;
        }

    }
}