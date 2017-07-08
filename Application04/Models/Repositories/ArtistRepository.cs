﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application04.Models.Repositories
{
    public class ArtistRepository : Repository<Artist>
    {
        public List<Artist> GetByName(String name)
        {
            return DbSet.Where(a => a.Name.Contains(name)).ToList();
        }
    }
}