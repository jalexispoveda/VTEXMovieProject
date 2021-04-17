using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VTEXMovieDatabase.Core.DTO;
using VTEXMovieDatabase.Core.Entities;
using VTEXMovieDatabase.Core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VTEXMovieDatabase.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;
        private readonly IMapper _mapper;

        public ActorController(IActorService actorService, IMapper mapper)
        {
            _actorService = actorService;
            _mapper = mapper;
        }

        // GET: api/<ActorController>
        [HttpGet]
        public IEnumerable<ActorDTO> Get()
        {
            var actor = _actorService.getActors();
            var actorDTO = _mapper.Map<IEnumerable<ActorDTO>>(actor);
            return actorDTO;
        }

        // GET api/<ActorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ActorController>
        [HttpPost]
        public async Task Post([FromBody] ActorDTO actorDTO)
        {
            var actor = _mapper.Map<Actor>(actorDTO);
            await _actorService.createActor(actor);
        }

        // PUT api/<ActorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ActorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
