using Microsoft.AspNetCore.Mvc;
using MVC_EXAM_NEW.Interfaces;

namespace MVC_EXAM_NEW.Controllers
{
    public class CourseController1 : Controller
    {

        private readonly ICourseService _courseService;
        public CourseController1(ICourseService userService)
        {
            _courseService= userService;
        }
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("Role") != "Admin")
            {
                return Unauthorized();
            }
            var course = await _courseService.GetAllAsync();
            return View(course);
        }
        [HttpGet]


        public IActionResult Create()
        {
            if(HttpContext.Session.GetString("Role") != "Admin")
            {
                return Unauthorized();
            }
            return View();
        }
        [HttpPost]


        public async Task<IActionResult> Edit(int id)
        {
            if (HttpContext.Session.GetString("Role") != "Admin")
            {
                return Unauthorized();
            }
            var course = await _courseService.GetByIdAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }
        [HttpGet]



        public IActionResult Index()
        {
            return View();
        }
    }
}
