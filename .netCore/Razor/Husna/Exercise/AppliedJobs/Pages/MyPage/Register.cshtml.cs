using AppliedJobs.Interface;
using AppliedJobs.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppliedJobs.Pages.MyPage
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;

        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public User RegisterUser { get; set; }

        public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            bool result = await _userService.RegisterUserAsync(RegisterUser);

            if (result)
            {
                // ? Redirect to Login after successful registration
                return RedirectToPage("/MyPage/Login");
            }

            Message = "User already exists.";
            return Page();
        }
    }
}
