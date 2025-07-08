using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mini_project.Models;
using Mini_project.Pages.Services;

namespace Mini_project.Pages.Menu
{
    public class DeleteModel : PageModel
    {
        private readonly MembService _services;
        [BindProperty]
        public CompanyMember Newmember { get; set; }
        public DeleteModel(MembService services)
        {
            _services = services;

        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Newmember = await _services.GetMemberbyidAsync(id);
            if (Newmember == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _services.DeletememberAsync(id);
            return RedirectToPage("Index2");
        }
    }

}

