using AspNetCoreUseAutoMapper.Models;
using AutoMapper;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Service;
using System.Diagnostics;

namespace AspNetCoreUseAutoMapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public HomeController(IMapper mapper,IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }
        public IActionResult Index()
        {
            //var user = new User
            //{
            //    Id = 1,
            //    Name = "bidianqing"
            //};
            //var userDTO = _mapper.Map<User, UserDTO>(user);
            _userService.Test();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
