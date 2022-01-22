using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistence.Repository
{
    public class UserRepository : IUserRepository
    {
        protected readonly IdeasDbContext _context;
        public UserRepository(IdeasDbContext context)
        {
            _context = context;
        }

        public int Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);

            _context.Users.Remove(user);
            return _context.SaveChanges();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;        
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }

        public User GetByLoginInfo(string username, string password)
        {
            return _context.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
        }

        public User GetByUniqueIdentifier(string username, string email)
        {
            return _context.Users.FirstOrDefault(x => x.Username == username || x.Email == email);
        }

        public int Insert(User user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges();
        }

        public int Update(User user)
        {
            var entity = _context.Users.FirstOrDefault(x => x.Id == user.Id);

            entity.Password = user.Password;
            entity.FirstName = user.FirstName;
            entity.LastName = user.LastName;

            _context.Users.Update(entity);
            return _context.SaveChanges();
        }
    }
}
