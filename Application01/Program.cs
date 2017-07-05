using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                Console.WriteLine(context.Albams.Count());
                context.Albams.Add(new Albam { AlbamId = 1, Price = 10, Title ="ED+" });

                context.SaveChanges();
                Console.WriteLine(context.Albams.Count());

                var albamsGotEd = context.Albams
                                         .Where(o => o.Title.Contains("ED+"))
                                         .ToList();
                Console.WriteLine("albams Got Ed+"+albamsGotEd.Count());
                Console.ReadLine();
            }
        }
    }

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
 