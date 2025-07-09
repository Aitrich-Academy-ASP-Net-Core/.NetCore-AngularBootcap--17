using AppliedJobs.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppliedJobs.Pages.MyPage
{
    public class LoginModel : PageModel
    {

        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userService.LoginAsync(Username, Password);

            if (user != null)
            {
                // ✅ Store user ID in session
                HttpContext.Session.SetInt32("UserId", user.Id);

                return RedirectToPage("/MyPage/Index");
            }

            Message = "Invalid credentials.";
            return Page();
        }
    }
}