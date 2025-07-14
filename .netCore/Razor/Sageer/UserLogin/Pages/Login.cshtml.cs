using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace UserLogin.Pages
{
    public class LoginModel : PageModel
    {
            [BindProperty]
            public InputModel Input { get; set; }

            public class InputModel
            {
                
                public string Username { get; set; }

                [Required(ErrorMessage = "Password is required.")]
                [DataType(DataType.Password)]
                [StringLength(100, ErrorMessage = "Password must be at least 6 characters.", MinimumLength = 6)]
                public string Password { get; set; }
            }

            public void OnGet()
            {
                
            }

            public IActionResult OnPost()
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                return RedirectToPage("/Index");
                
        }
    }
}
