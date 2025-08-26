using Exam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exam.Controllers
{
    public class DoctorController : Controller
    {
        private readonly HospitalDbContext _context;

        public DoctorController(HospitalDbContext context)
        {
            _context = context;
        }

       
        private bool IsAdminLoggedIn()
        {
            var role = HttpContext.Session.GetString("UserRole");
            return role == "Admin";
        }

        
        public async Task<IActionResult> Index()
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login", "Account");

            var doctors = await _context.Doctors.ToListAsync();
            return View(doctors);
        }

      
        public IActionResult Add()
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login", "Account");

            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Add(Doctor doctor)
        {
            if (!IsAdminLoggedIn())
                return RedirectToAction("Login", "Account");

            if (!ModelState.IsValid)
                return View(doctor);

            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
