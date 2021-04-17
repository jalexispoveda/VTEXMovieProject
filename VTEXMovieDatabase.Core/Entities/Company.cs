using System;
using System.Collections.Generic;

#nullable disable

namespace VTEXMovieDatabase.Core.Entities
{
    public partial class Company
    {
        public Company()
        {
            Movies = new HashSet<Movie>();
        }

        public int IdCompany { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
