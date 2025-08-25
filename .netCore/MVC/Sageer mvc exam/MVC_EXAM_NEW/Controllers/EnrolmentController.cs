using Microsoft.AspNetCore.Mvc;
using MVC_EXAM_NEW.Interfaces;
using MVC_EXAM_NEW.Services;

namespace MVC_EXAM_NEW.Controllers
{
    public class EnrolmentController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IEnrollmentService _enrollmentService;
        public EnrolmentController(ICourseService courseservice, IEnrollmentService enrollmentservice)
        {
            _courseService = courseservice;
            _enrollmentService = enrollmentservice;
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

        public async Task<IActionResult> Enrolled()
        {
            if (HttpContext.Session.GetString("Role") != "Admin")
            {
                return Unauthorized();
            }
            var userid = HttpContext.Session.GetInt32("UserId").Value;
            var course = await _enrollmentService.GetEnrollmentCoursesAsync(userid);
            return View(course);
        }
        [HttpPost]

        public async Task<IActionResult> Enroll(int courseid)
        {
            if (HttpContext.Session.GetString("Role") != "Admin")
            {
                return Unauthorized();
            }
            var userid = HttpContext.Session.GetInt32("UserId").Value;
            await _enrollmentService.EnrollAsync(userid, courseid);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Drop(int courseid)
        {
            if (HttpContext.Session.GetString("Role") != "Admin")
            {
                return Unauthorized();
            }
            var userid = HttpContext.Session.GetInt32("UserId").Value;
            await _enrollmentService.DropAsync(userid,courseid);
            return RedirectToAction("Enrolled");
        }
        [HttpPost]

    }
}
