using Application04.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application04.Models
{
    public class Albam
    {
        public int AlbamID { set; get; }

        [Required()]
        [StringLength(100,MinimumLength =2)]
        public String Title { get; set; }
        public Artist MyProperty { get; set; }
    }
}