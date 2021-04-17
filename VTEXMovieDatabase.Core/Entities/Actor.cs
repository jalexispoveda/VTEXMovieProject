using System;
using System.Collections.Generic;

#nullable disable

namespace VTEXMovieDatabase.Core.Entities
{
    public partial class Actor
    {
        public Actor()
        {
            ActorMovies = new HashSet<ActorMovie>();
        }

        public int IdActor { get; set; }
        public string ActorName { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
