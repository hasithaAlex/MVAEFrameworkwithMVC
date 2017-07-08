using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Application04.Models
{
    public class MusicStoreDataContext : DbContext
    {
        public DbSet<Artist> Artist { get; set; }
    }
}