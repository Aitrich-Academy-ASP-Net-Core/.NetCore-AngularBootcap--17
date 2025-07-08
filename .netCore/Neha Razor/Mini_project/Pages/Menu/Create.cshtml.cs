using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mini_project.DTO;
using Mini_project.Models;
using Mini_project.Pages.Services;

namespace Mini_project.Pages.Menu
{
    public class CreateModel : PageModel
    {
        private readonly MembService _service;

        [BindProperty]
        public MemberDto MemberPost { get; set; }

        public CreateModel(MembService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddMemberAsync(MemberPost);
            return RedirectToPage("Index2");
        }

    }
}

