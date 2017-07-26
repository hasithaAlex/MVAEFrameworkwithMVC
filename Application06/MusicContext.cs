using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application06
{
    class MusicContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MusicStore");

            //PK
            //modelBuilder.Entity<Albam>().HasKey(t => t.AlbamId);

            //Composite Key
            modelBuilder.Entity<Albam>().HasKey(t => new { t.AlbamId , t.Title });

            modelBuilder.Entity<Albam>()
                .Property(o => o.AlbamId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Albam> Albams { get; set; }
    }
}
 