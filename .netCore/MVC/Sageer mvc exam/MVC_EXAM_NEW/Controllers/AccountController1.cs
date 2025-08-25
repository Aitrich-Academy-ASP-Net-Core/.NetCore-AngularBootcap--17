using Microsoft.AspNetCore.Mvc;
using MVC_EXAM_NEW.DTO;
using MVC_EXAM_NEW.Interfaces;
using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.Controllers
{
    public class AccountController1 : Controller
    {
        private readonly IUserService _userService;
        public AccountController1(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]

        public async Task <IActionResult > Register(UserDto userdto,string password)
        {
            if(!ModelState.IsValid)
            {
                var user = await _userService.RegisterAsync(userdto, password);
                return RedirectToAction("Login");
            }
            return View(userdto);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Login(string username, string password)
        {
            if (!ModelState.IsValid)
            {
                var user = await _userService.LoginAsync(username, password);
                if(user != null)
                {
                    HttpContext.Session.SetInt32("UserId", user.Id);
                    HttpContext.Session.SetString("Role", user.Role);
                    if (user.Role == "Admin")
                    {
                        return RedirectToAction("Index", "Course");
                    }
                    return RedirectToAction("Index","Enrolment")
                }
            }
            return View();
            
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
