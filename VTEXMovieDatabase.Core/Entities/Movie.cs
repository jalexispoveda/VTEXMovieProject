using System;
using System.Collections.Generic;

#nullable disable

namespace VTEXMovieDatabase.Core.Entities
{
    public partial class Movie
    {
        public Movie()
        {
            ActorMovies = new HashSet<ActorMovie>();
        }

        public int IdMovie { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? IdGenre { get; set; }
        public int? ReleaseDate { get; set; }
        public int? IdCompany { get; set; }

        public virtual Company IdCompanyNavigation { get; set; }
        public virtual Genre IdGenreNavigation { get; set; }
        public virtual ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
