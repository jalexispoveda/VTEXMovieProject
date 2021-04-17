using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VTEXMovieDatabase.Core.Entities;
using VTEXMovieDatabase.Core.Interfaces;

namespace VTEXMovieDatabase.Core.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        public async Task createActor(Actor actor)
        {
            await _actorRepository.createActor(actor);
        }

        public IEnumerable<Actor> getActors()
        {
            return _actorRepository.getActors();
        }
    }
}
