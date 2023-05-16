using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Model;
using Project.Repository;

namespace Project.Repository
{
    public class AlbumRepository
    {
        Kpop db = Singleton.getConnection();

        public void save()
        {
            db.SaveChanges();
        }



    }


}