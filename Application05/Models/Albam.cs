using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application05.Models
{
    public class Albam
    {
        public int AlbamID { set; get; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public String Title { get; set; }

        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual List<Reviewer> Reviewers { get; set; }


    }
}