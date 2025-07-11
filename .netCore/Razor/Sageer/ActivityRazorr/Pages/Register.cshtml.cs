using ActivityRazorr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActivityRazorr.Pages.Studentdata
{
    public class RegisterModel : PageModel
    {
        private readonly StudentDBContext _context;
        [BindProperty]
        public Student NewUser { get; set; }
        public RegisterModel(StudentDBContext context)
        {
            context = _context;
        }
        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(NewUser.Username) || string.IsNullOrEmpty(NewUser.Password))
            {
                ModelState.AddModelError("", "Username and Password are required");
                return Page();
            }

            // Check if user already exists
            if (_context.Students.Any(u => u.Username == NewUser.Username))

            {
                ModelState.AddModelError("", "Username already taken");
                return Page();
            }

            _context.Students.Add(NewUser);
            _context.SaveChanges();
            return RedirectToPage("Login");
        }
    }
}
