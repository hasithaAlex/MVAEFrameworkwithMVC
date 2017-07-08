using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Application04.Models
{
    public class MusicStoreDataContextInitializer : DropCreateDatabaseAlways<MusicStoreDataContext>
    {
        protected override void Seed(MusicStoreDataContext context)
        {
            Artist artist01 = new Artist { Name = "First Artist" };
            Artist artist02 = new Artist { Name = "Second Artist" };


            context.Artist.Add(artist01);
            context.Artist.Add(artist02);
            context.SaveChanges();
        }
    }
}