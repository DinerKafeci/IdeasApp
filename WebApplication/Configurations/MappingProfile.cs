using Application.Configurations;
using Application.DTO_Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<IdeaViewModel, IdeaDTO>()
                .ForMember(dest => dest.Id, x => x.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, x => x.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, x => x.MapFrom(src => src.Description))
                .ForMember(dest => dest.DateCreated, x => x.MapFrom(src => src.DateCreated))
                .ForMember(dest => dest.UniqueCode, x => x.MapFrom(src => src.UniqueCode))
                .ReverseMap()
                .ForMember(dest => dest.Id, x => x.MapFrom(src => src.Id))
                .ForMember(dest => dest.Title, x => x.MapFrom(src => src.Title))
                .ForMember(dest => dest.Description, x => x.MapFrom(src => src.Description))
                .ForMember(dest => dest.DateCreated, x => x.MapFrom(src => src.DateCreated))
                .ForMember(dest => dest.UniqueCode, x => x.MapFrom(src => src.UniqueCode));
               //.ForMember(dest => dest.Id, x => x.Ignore());
        }

    }
}
