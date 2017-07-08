﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application04.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        [Required()]
        [StringLength(100,MinimumLength =2)]
        public string Name { get; set; }
    }
}