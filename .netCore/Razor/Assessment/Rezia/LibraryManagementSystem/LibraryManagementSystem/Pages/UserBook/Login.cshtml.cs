using LibraryManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.UserBook
{
    public class LoginModel : PageModel
    {
        private readonly UserService _userService;

        public LoginModel(UserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userService.GetUserByEmailAsync(Email);
            if (user == null || user.Password != Password)
            {
                ModelState.AddModelError("","Invalid user and password");
            }
            if (user.Role == "Admin")
            {
                return RedirectToPage("/UserBook/Addbook");
            }
            else
            {
                return RedirectToPage("/UserBook/ViewBook");
            }
        }
       
    }
}
