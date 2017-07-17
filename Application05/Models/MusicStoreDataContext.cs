using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Application05.Models
{
    public class MusicStoreDataContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Albam> Albams { get; set; }
    }
}