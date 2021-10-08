using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistence.Repository
{
    public class IdeaRepository : IIdeaRepository
    {
        private readonly IdeasDbContext _context;
        public IdeaRepository(IdeasDbContext context)
        {
            _context = context;
        }
        public int Delete(int id)
        {
            var entity = _context.Ideas.FirstOrDefault(x => x.Id == id);

            _context.Ideas.Remove(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<Idea> GetAll()
        {
            return _context.Ideas;
        }

        public Idea GetById(int id)
        {
            return _context.Ideas.FirstOrDefault(x => x.Id == id); ;
        }

        public Idea GetByTitle(string title)
        {
            return _context.Ideas.FirstOrDefault(x => x.Title == title); ;

        }

        public int Insert(Idea idea)
        {
            _context.Ideas.Add(idea);
            return _context.SaveChanges();
        }

        public int Update(Idea idea)
        {
            _context.Ideas.Update(idea);
            return _context.SaveChanges();
        }
    }
}
