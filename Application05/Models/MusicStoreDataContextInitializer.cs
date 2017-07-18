using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Application05.Models
{
    public class MusicStoreDataContextInitializer: DropCreateDatabaseAlways<MusicStoreDataContext>
    {
        protected override void Seed(MusicStoreDataContext context)
        {
            Artist artist01 = new Artist { Name = "First Artist" };
            context.Artists.Add(artist01);
            context.Albams.Add(new Albam { Artist = artist01, Title = "This Year's LOVE" });
            context.Albams.Add(new Albam { Artist = artist01, Title = "Next Year's LOVE" });
            context.Albams.Add(
            new Albam {
                Artist = new Artist { Name = "Second Artist" },
                Title = "Holaluya"
            });

            context.Artists.Add(new SoloArtist() { Name = "SOLO Artist", Instrument="Gutar" });

            context.SaveChanges();
        }

    }
}