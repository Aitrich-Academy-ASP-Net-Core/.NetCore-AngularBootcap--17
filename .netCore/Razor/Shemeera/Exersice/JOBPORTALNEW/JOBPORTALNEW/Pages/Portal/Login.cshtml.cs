using JOBPORTALNEW.Interface;
using JOBPORTALNEW.JobDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBPORTALNEW.Pages.Portal
{
    public class LoginModel : PageModel
    {
        private readonly IService _service;

        public LoginModel(IService service)
        {
            _service = service;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; } = string.Empty;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _service.LoginAsync(Username, Password);

            if (user != null)
            {
                
                TempData["UserId"] = user.Id;
                return RedirectToPage("/Portal/Index");
            }

            ErrorMessage = "Invalid username or password.";
            return Page();
        }
    }
}
