using Application.DTO_Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    interface IIdeaService
    {
        public void Add(IdeaDTO idea);
        public IEnumerable<Idea> GetIdeas();

        public Idea GetIdeaById(int id);

        public Idea GetIdeaByTitle(string title);
        public void Update(IdeaDTO idea);

        public bool Delete(int id);
    }
}
