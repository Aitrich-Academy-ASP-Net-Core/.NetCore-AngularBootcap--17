using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mini_project.Models;
using Mini_project.DTO;

namespace Mini_project.Pages.Menu
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public UserDto NewUser { get; set; }

        public RegisterModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(NewUser.Username) || string.IsNullOrEmpty(NewUser.Email)|| string.IsNullOrEmpty(NewUser.Password))
            {
                ModelState.AddModelError("","All Fields are required");
                return Page();
            }
            if (_context.Users.Any(u => u.Username == NewUser.Username))
            {
                ModelState.AddModelError("", "Username already taken");
                return Page();
            }

            var user = new User
            {
                Username = NewUser.Username,
                Email = NewUser.Email,
                Password = NewUser.Password
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToPage("Login");
        }
    }
}
    

