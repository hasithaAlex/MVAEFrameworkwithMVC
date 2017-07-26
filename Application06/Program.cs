using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application06
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {
                var albam = new Albam() { Price = 10, Title = "Ed Shi - X" };
                context.Albams.Add(albam);
                context.SaveChanges();
            }
        }
    }
}
