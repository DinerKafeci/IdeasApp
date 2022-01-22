using Application.DTO_Models;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Idea, IdeaDTO>()
                .ReverseMap()
                .IgnoreAllPropertiesWithAnInaccessibleSetter()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();

            CreateMap<User, UserDTO>()
                .ReverseMap()
                .IgnoreAllPropertiesWithAnInaccessibleSetter()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter();
        }
    }
}
