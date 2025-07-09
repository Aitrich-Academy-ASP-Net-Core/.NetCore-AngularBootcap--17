using ExamRazor.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamRazor.Pages.Library
{
    public class LoginModel : PageModel
    {
        private readonly ILibraryService _service;

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public LoginModel(ILibraryService service)
        {
            _service = service;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _service.LoginAsync(Username, Password);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid credentials");
                return Page();
            }

            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetString("Role", user.Role);

            return RedirectToPage("Index");
        }
    }
}
