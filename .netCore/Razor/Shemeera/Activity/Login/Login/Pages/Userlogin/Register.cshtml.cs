using Login.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Login.Pages.Userlogin
{
    public class RegisterModel : PageModel
    {
        private readonly UserDbContext _context;

        [BindProperty]
        public User NewUser { get; set; }

        public RegisterModel(UserDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(NewUser.Username) || string.IsNullOrEmpty(NewUser.Password))
            {
                ModelState.AddModelError("", "Username and Password are required");
                return Page();
            }

            // Check if user already exists
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
