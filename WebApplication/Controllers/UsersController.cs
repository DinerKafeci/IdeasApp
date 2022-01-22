using Application.DTO_Models;
using Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            _userService.LogIn(_mapper.Map<UserDTO>(model));

            return RedirectToAction("Index", "Ideas");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Regiser(RegisterViewModel model)
        {
            _userService.Register(_mapper.Map<UserDTO>(model));

            return RedirectToAction("Index", "Ideas");
        }
    }
}
