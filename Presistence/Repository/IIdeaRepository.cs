using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistence.Repository
{
    public interface IIdeaRepository
    {
        IEnumerable<Idea> GetAll();
        Idea GetById(int id);
        Idea GetByTitle(string title);
        int Insert(Idea idea);
        int Update(Idea idea);
        int Delete(int id);
    }
}
