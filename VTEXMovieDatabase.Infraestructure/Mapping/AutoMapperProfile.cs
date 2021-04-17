using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VTEXMovieDatabase.Core.DTO;
using VTEXMovieDatabase.Core.Entities;

namespace VTEXMovieDatabase.Infraestructure.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Actor, ActorDTO>();
            CreateMap<ActorDTO, Actor>();
        }
    }
}
