using Exam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Exam.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly HospitalDbContext _context;
        public AppointmentController(HospitalDbContext context)
        {
            _context = context;
        }

        private int? GetUserId() => HttpContext.Session.GetInt32("UserId");
        private string GetUserRole() => HttpContext.Session.GetString("UserRole");


        public async Task<IActionResult> ListDoctors()
        {
            if (GetUserRole() != "Patient")
                return RedirectToAction("Login", "Account");

            var doctors = await _context.Doctors.ToListAsync();
            return View(doctors);
        }





        public async Task<IActionResult> Book(int id)
        {
            if (GetUserRole() != "Patient")
                return RedirectToAction("Login", "Account");

            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null) return NotFound();

            ViewBag.DoctorId = doctor.Id;
            ViewBag.DoctorName = doctor.Name;
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Book(int id, DateTime appointmentDateTime)
        {
            if (GetUserRole() != "Patient")
                return RedirectToAction("Login", "Account");

            var userId = GetUserId();
            if (userId == null)
                return RedirectToAction("Login", "Account");

            var appointment = new Appointment
            {
                DoctorId = id,
                PatientId = userId.Value,
                AppointmentDateTime = appointmentDateTime
            };

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            return RedirectToAction("MyAppointments");
        }


        public async Task<IActionResult> MyAppointments()
        {
            if (GetUserRole() != "Patient")
                return RedirectToAction("Login", "Account");

            var userId = GetUserId();

            var appointments = await _context.Appointments
                .Include(a => a.Doctor)
                .Where(a => a.PatientId == userId)
                .ToListAsync();

            return View(appointments);
        }


        public async Task<IActionResult> AllAppointments()
        {
            if (GetUserRole() != "Admin")
                return RedirectToAction("Login", "Account");

            var appointments = await _context.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .ToListAsync();

            return View(appointments);
        }
    }
}
