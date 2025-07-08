using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mini_project.Models;
using Mini_project.Pages.Services;

namespace Mini_project.Pages.Menu
{
    public class EditModel : PageModel
    {
        private readonly MembService _service;

        [BindProperty]
        public CompanyMember NewMember { get; set; }

        public EditModel(MembService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var memberdto = await _service.GetMemberbyidAsync(id);
            if (memberdto == null)
            {
                return NotFound();
            }

            NewMember = memberdto;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _service.UpdateMemberAsync(NewMember.MemberId, NewMember);
            return RedirectToPage("Index2"); 
        }
    }
}
