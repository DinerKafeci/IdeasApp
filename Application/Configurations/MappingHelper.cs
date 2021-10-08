using Application.DTO_Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Configurations
{
    public static class MappingHelper
    {
        public static Idea Map(this IdeaDTO src)
        {
            return new Idea() 
            { 
                Id = src.Id,
                Title = src.Title,
                Description = src.Description,
                UniqueCode = src.UniqueCode,
                DateCreated = DateTime.Now,
            };
        }

        public static IEnumerable<Idea> Map(this IEnumerable<IdeaDTO> src)
        {
            return src.Select(x => x.Map());
        }

        public static IdeaDTO Map(this Idea src)
        {
            return new IdeaDTO()
            {
                Id = src.Id,
                Title = src.Title,
                Description = src.Description,
                UniqueCode = src.UniqueCode,
            };
        }

        public static IEnumerable<IdeaDTO> Map(this IEnumerable<Idea> src)
        {
            return src.Select(x => x.Map());
        }
    }
}
