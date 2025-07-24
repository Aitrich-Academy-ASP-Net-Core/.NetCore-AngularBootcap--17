using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mini_project.Models;
using Mini_project.Pages.Services;

namespace Mini_project.Pages.Menu
{
    public class IndexModel : PageModel
    {
        private readonly MembService _service;


        public List<CompanyMember> Members { get; set; }

        public IndexModel(MembService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync()
        {

            var currentUser = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(currentUser))
            {
                return RedirectToPage("/Menu/Login");
            }
            {
                Members = await _service.GetAllMemberAsync();
                return Page();
            }
        }
    }
}

