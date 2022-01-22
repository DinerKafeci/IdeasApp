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
			CreateMap<RegisterViewModel, UserDTO>()
				.ForMember(dest => dest.Username, x => x.MapFrom(src => src.Username))
				.ForMember(dest => dest.Password, x => x.MapFrom(src => src.Password))
				.ForMember(dest => dest.Email, x => x.MapFrom(src => src.Email))
				.ForMember(dest => dest.FirstName, x => x.MapFrom(src => src.FirstName))
				.ForMember(dest => dest.LastName, x => x.MapFrom(src => src.LastName))
				.ReverseMap()
				.ForMember(dest => dest.Username, x => x.MapFrom(src => src.Username))
				.ForMember(dest => dest.Password, x => x.MapFrom(src => src.Password))
				.ForMember(dest => dest.Email, x => x.MapFrom(src => src.Email))
				.ForMember(dest => dest.FirstName, x => x.MapFrom(src => src.FirstName))
				.ForMember(dest => dest.LastName, x => x.MapFrom(src => src.LastName))
				.ForMember(dest => dest.ConfirmPassword, x => x.Ignore());

			CreateMap<LoginViewModel, UserDTO>()
				.ForMember(dest => dest.Username, x => x.MapFrom(src => src.Username))
				.ForMember(dest => dest.Password, x => x.MapFrom(src => src.Password))
				.ForMember(dest => dest.Email, x => x.Ignore())
				.ForMember(dest => dest.FirstName, x => x.Ignore())
				.ForMember(dest => dest.LastName, x => x.Ignore())
				.ReverseMap()
				.ForMember(dest => dest.Username, x => x.MapFrom(src => src.Username))
				.ForMember(dest => dest.Password, x => x.MapFrom(src => src.Password));
			
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
