using JOBPORTALNEW.Interface;
using JOBPORTALNEW.JobDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBPORTALNEW.Pages.Portal
{
    public class RegisterModel : PageModel
    {
        private readonly IService _service;

        public RegisterModel(IService service)
        {
            _service = service;
        }

        [BindProperty]
        public UserDto Input { get; set; }

        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            var existingUser = await _service.GetByUsernameAsync(Input.Username);
            if (existingUser != null)
            {
                ErrorMessage = "Username already taken";
                return Page();
            }

            await _service.AddUserAsync(Input);

            return RedirectToPage("Login");
        }
    }
}
