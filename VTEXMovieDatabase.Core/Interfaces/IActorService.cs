using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VTEXMovieDatabase.Core.Entities;

namespace VTEXMovieDatabase.Core.Interfaces
{
    public interface IActorService
    {
        IEnumerable<Actor> getActors();

        Task createActor(Actor actor);
    }
}
