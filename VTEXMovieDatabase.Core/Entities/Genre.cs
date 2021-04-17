﻿using System;
using System.Collections.Generic;

#nullable disable

namespace VTEXMovieDatabase.Core.Entities
{
    public partial class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        public int IdGenre { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
