using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class ArtistFactory
    {
        public static Artist create(int ArtistID, string ArtistName, string ArtistImage)
        {
            var x = new Artist();
            x.ArtistID = ArtistID;
            x.ArtistName = ArtistName;
            x.ArtistImage = ArtistImage;
            return x;
        }
    }
}