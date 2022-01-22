using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistence.Repository
{
    public interface IUserRepository
    {
		IEnumerable<User> GetAll();
		User GetById(int id);
		User GetByLoginInfo(string username, string password);
		User GetByUniqueIdentifier(string username, string email);
		int Insert(User user);
		int Update(User user);
		int Delete(int id);
	}
}
