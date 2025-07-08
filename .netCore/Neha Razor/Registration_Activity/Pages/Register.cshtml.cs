using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Registration_Activity.Models;

namespace Registration_Activity.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly RegisterDbContext _context;

        [BindProperty]
        public User NewUser { get; set; }

        public RegisterModel(RegisterDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(NewUser.Username) || string.IsNullOrEmpty(NewUser.Password))
            {
                ModelState.AddModelError("","Username and Password are required");
                return Page();
            }
            if (_context.Users.Any(u => u.Username == NewUser.Username))
            {
                ModelState.AddModelError("", "Username already taken");
                return Page();
            }

            _context.Users.Add(NewUser);
            _context.SaveChanges();
            return RedirectToPage("Login");
        }
    }
}

