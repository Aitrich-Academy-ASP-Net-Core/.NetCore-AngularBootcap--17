using Microsoft.AspNetCore.Mvc;
using MVC_Register.Dto;
using System.Threading.Tasks;
using MVC_Register.Interface;

namespace MVC_Register.Controllers
{
    public class UserController:Controller
    {
        private readonly IUserService _userService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserController(IUserService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
                return View(registerDto);

            var result = await _userService.RegisterUserAsync(registerDto);
            if (!result)
            {
                ModelState.AddModelError("", "Email already in use");
                return View(registerDto);
            }

            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
                return View(loginDto);

            var user = await _userService.LoginAsync(loginDto);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid credentials");
                return View(loginDto);
            }

            HttpContext.Session.SetString("UserEmail", user.Email);
            return RedirectToAction("Dashboard");
        }

        public IActionResult Dashboard()
        {
            var email = HttpContext.Session.GetString("UserEmail");
            if (email == null)
                return RedirectToAction("Login");
            ViewBag.Email = email;
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}
