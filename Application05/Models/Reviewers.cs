using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application05.Models
{
    public class Reviewer
    {
        public int ReviewerID { get; set; }
        public string Name { get; set; }

        public virtual List<Albam> Albams { get; set; }

    }
}