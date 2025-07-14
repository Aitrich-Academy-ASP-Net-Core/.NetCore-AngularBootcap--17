using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Registration_Activity.Models;

namespace Registration_Activity.Pages
{
    public class LoginModel : PageModel
    {
        private readonly RegisterDbContext _context;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public LoginModel(RegisterDbContext context)
        {
            _context = context;
           
        }
        public  IActionResult OnPost()
        {
            var user = _context.Users.SingleOrDefault(u => u.Username == Username && u.Password == Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return Page();
            }
            HttpContext.Session.SetString("User", Username);
            return RedirectToPage("Index");

        }
    }
}
