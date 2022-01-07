using Application.Configurations;
using Application.DTO_Models;
using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly IIdeaRepository _ideaRepository;

        public IdeaService(IIdeaRepository ideaRepository, IMapper mapper)
        {
            _ideaRepository = ideaRepository;
            _mapper = mapper;
        }

        public void Add(IdeaDTO idea)
        {
            _ideaRepository.Insert(_mapper.Map<Idea>(idea));
        }
        public IEnumerable<IdeaDTO> GetIdeas()
        {
            var ideas = _mapper.Map<IEnumerable<IdeaDTO>>(_ideaRepository.GetAll());
            return ideas;
        }

        public IdeaDTO GetIdeaById(int id)
        {
            return _mapper.Map<IdeaDTO>(_ideaRepository.GetById(id));
        }

        public Idea GetIdeaByTitle(string title)
        {
            return _ideaRepository.GetByTitle(title);
        }

        public void Update(IdeaDTO idea)
        {
            _ideaRepository.Update(_mapper.Map<Idea>(idea));
        }

        public bool Delete(int id)
        {
            _ideaRepository.Delete(id);
            return true;
        }
    }
}
