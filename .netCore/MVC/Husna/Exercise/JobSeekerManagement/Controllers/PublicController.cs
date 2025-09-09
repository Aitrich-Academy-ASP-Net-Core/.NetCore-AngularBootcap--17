using JobSeekerManagement.Dto;
using JobSeekerManagement.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekerManagement.Controllers
{
    public class PublicController : Controller
    {
        private readonly IPublicService _service;

        public PublicController(IPublicService service)
        {
            _service = service;
        }

        // GET: Register
        public IActionResult Register() => View();

        // POST: Register
        [HttpPost]
        public async Task<IActionResult> Register(UserDto dto)
        {
            if (!ModelState.IsValid) return View(dto);

            await _service.RegisterAsync(dto);
            TempData["Message"] = "Registration successful. Please login.";
            return RedirectToAction("Login");
        }

        // GET: Login
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            var user = await _service.LoginAsync(dto.Email, dto.Password);
            if (user == null)
            {
                ViewBag.Error = "Invalid credentials!";
                return View(dto);
            }

            // Store user info in session
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("Username", user.FirstName);

            // Redirect to JobList
            return RedirectToAction("JobList", "Jobs");
        }


    }


}
