using Application.Configurations;
using Application.DTO_Models;
using AutoMapper;
using Domain.Models;
using Microsoft.Extensions.Options;
using Presistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _options;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UserService(IOptions<AppSettings> options, IMapper mapper, IUserRepository userRepository)
        {
            _options = options.Value;
            _mapper = mapper; // This is where we get the mapper from the DI container so we can use it in this class
            _userRepository = userRepository;
        }

		public User LogIn(UserDTO user)
		{
			return _userRepository.GetByLoginInfo(user.Username, user.Password);
		}

		public User Register(UserDTO user)
		{
			var existingUser = _userRepository.GetByUniqueIdentifier(user.Username, user.Email);
			if (existingUser == null)
			{
				var entity = _mapper.Map<User>(user);
				_userRepository.Insert(entity);
				return LogIn(user);
			}

			return null;
		}
	}
}
