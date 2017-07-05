using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Application02.Models
{
    public class Albam
    {
        public int AlbamId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    public class MusicContext : DbContext
    {
        public DbSet<Albam> Albams { get; set; }
    }

}