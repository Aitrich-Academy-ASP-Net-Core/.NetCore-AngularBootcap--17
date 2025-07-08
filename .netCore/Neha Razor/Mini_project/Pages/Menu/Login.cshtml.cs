using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mini_project.DTO;
using Mini_project.Models;
using Microsoft.AspNetCore.Http; 
using System.Linq;

namespace Mini_project.Pages.Menu
{
    public class LoginModel : PageModel
    {
         private readonly ApplicationDbContext _context;

            [BindProperty]
            public string Username { get; set; }
            [BindProperty]
            public string Password { get; set; }

            public LoginModel(ApplicationDbContext context)
            {
                _context = context;
            }

            public IActionResult OnPost()
            {
                var user = _context.Users.SingleOrDefault(u => u.Username == Username && u.Password == Password);
                if (user == null)
                {
                    ModelState.AddModelError("", "Invalid username or password");
                    return Page();
                }

               
                HttpContext.Session.SetString("User", Username);
                return RedirectToPage("Index2");
            }
        }
    }
