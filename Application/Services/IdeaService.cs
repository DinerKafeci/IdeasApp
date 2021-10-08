using Application.Configurations;
using Application.DTO_Models;
using Domain.Models;
using Presistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class IdeaService : IIdeaService
    {
        private readonly IIdeaRepository _ideaRepository;

        public IdeaService(IIdeaRepository ideaRepository)
        {
            _ideaRepository = ideaRepository;
        }

        public void Add(IdeaDTO idea)
        {
            _ideaRepository.Insert(idea.Map());
        }
        public IEnumerable<Idea> GetIdeas()
        {
            var ideas = _ideaRepository.GetAll();
            return ideas;
        }

        public Idea GetIdeaById(int id)
        {
            return _ideaRepository.GetById(id);
        }

        public Idea GetIdeaByTitle(string title)
        {
            return _ideaRepository.GetByTitle(title);
        }

        public void Update(IdeaDTO idea)
        {
            _ideaRepository.Update(idea.Map());
        }

        public bool Delete(int id)
        {
            _ideaRepository.Delete(id);
            return true;
        }
    }
}
