using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Factory
{
    public class AlbumFactory
    {
        public static Album create(int AlbumID, int ArtistID, string AlbumName, string AlbumImage, int AlbumPrice, int AlbumStock, string AlbumDescription)
        {
            var x = new Album();
            x.AlbumID = AlbumID;
            x.ArtistID = ArtistID;
            x.AlbumName = AlbumName;
            x.AlbumImage = AlbumImage;
            x.AlbumPrice = AlbumPrice;
            x.AlbumStock = AlbumStock;
            x.AlbumDescription = AlbumDescription;
            return x;
        }
    }
}