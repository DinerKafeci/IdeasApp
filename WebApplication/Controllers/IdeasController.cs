using Application.Configurations;
using Application.DTO_Models;
using Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class IdeasController : Controller
    {
        private readonly IIdeaService _ideaService;
        private readonly AppSettings _options;
        private readonly IMapper _mapper;

        public IdeasController(IMapper mapper, IIdeaService ideaService, IOptions<AppSettings> options)
        {
            _ideaService = ideaService;
            _options = options.Value;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var ideas = _mapper.Map<IEnumerable<IdeaViewModel>>(_ideaService.GetIdeas());

            return View(new IdeaHomeViewModel() { Ideas = ideas });
        }

        
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(IdeaViewModel idea)
        {
            var newIdea = _mapper.Map<IdeaDTO>(idea);
            _ideaService.Add(newIdea);

            return RedirectToAction("Index", "Ideas");
        }

       // [HttpDelete]
        public IActionResult Delete(int id)
        {
            _ideaService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
