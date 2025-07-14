using LibraryManagementSystem.Dto;
using LibraryManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.UserBook
{
    public class RegisterUserModel : PageModel
    {
        private readonly UserService _userService;

        public RegisterUserModel(UserService userService)
        {
            _userService = userService;
        }
        [BindProperty]
        public UserDto newUser { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _userService.AddUserAsync(newUser);
            return RedirectToPage("Login");
        }

        }
    }

