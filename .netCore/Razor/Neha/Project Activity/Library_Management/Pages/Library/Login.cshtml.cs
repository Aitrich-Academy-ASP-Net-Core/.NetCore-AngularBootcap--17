using Library_Management.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Library_Management.DTO;

namespace Library_Management.Pages.Library
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserDto LoginDto { get; set; } 

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userService.ValidateUserAsync(LoginDto);

            if (user == null)
            {
               
                return Page();
            }

            HttpContext.Session.SetString("User", user.Username);
            HttpContext.Session.SetString("Role", user.Role);
            return RedirectToPage("Index2");
        }
    }
}
   

