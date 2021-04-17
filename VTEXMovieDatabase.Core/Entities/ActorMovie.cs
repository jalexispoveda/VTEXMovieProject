using System;
using System.Collections.Generic;

#nullable disable

namespace VTEXMovieDatabase.Core.Entities
{
    public partial class ActorMovie
    {
        public int IdActorMovie { get; set; }
        public int? IdActor { get; set; }
        public int? IdMovie { get; set; }

        public virtual Actor IdActorNavigation { get; set; }
        public virtual Movie IdMovieNavigation { get; set; }
    }
}
