using ExamRazor.Interface;
using ExamRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamRazor.Pages.Library
{
    public class RegisterModel : PageModel
    {
        private readonly ILibraryService _service;

        [BindProperty]
        public User NewUser { get; set; }

        public RegisterModel(ILibraryService service)
        {
            _service = service;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var success = await _service.RegisterUserAsync(NewUser);

            if (!success)
            {
                ModelState.AddModelError("", "Username already exists");
                return Page();
            }

            return RedirectToPage("Login");
        }
    }
}
