using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTEXMovieDatabase.Core.Entities;
using VTEXMovieDatabase.Core.Interfaces;
using VTEXMovieDatabase.Infraestructure.Data;

namespace VTEXMovieDatabase.Infraestructure.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly VTEXmovieDatabaseContext _context;        
        
        public ActorRepository(VTEXmovieDatabaseContext context)
        {
            _context = context;
        }

        public async Task createActor(Actor actor)
        {
            _context.Actors.Add(actor);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Actor> getActors()
        {
            return _context.Actors.AsEnumerable();
        }
    }
}
