using System.Collections.Generic;
using System.Threading.Tasks;
using VTEXMovieDatabase.Core.Entities;

namespace VTEXMovieDatabase.Core.Interfaces
{
    public interface IActorRepository
    {
        IEnumerable<Actor> getActors();

        Task createActor(Actor actor);
    }
}
