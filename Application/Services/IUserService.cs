using Application.DTO_Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IUserService
    {
        User LogIn(UserDTO user);
        User Register(UserDTO user);
    }
}
