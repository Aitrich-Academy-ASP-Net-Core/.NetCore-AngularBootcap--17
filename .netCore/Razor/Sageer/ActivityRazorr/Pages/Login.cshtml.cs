using ActivityRazorr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActivityRazorr.Pages.Studentdata
{
    public class LoginModel : PageModel
    {
        private readonly StudentDBContext _context;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public LoginModel(StudentDBContext context)
        {
            context =_context;
        }
        public IActionResult OnPost()
        {
            var user = _context.Students.SingleOrDefault(u => u.Username == Username && u.Password == Password);
            if (user == null)
            {
                ModelState.AddModelError("","Invalid username or password");
                return Page();
            }
            HttpContext.Session.SetString("User", Username);
            return RedirectToPage("Index");
        }
    }
}
