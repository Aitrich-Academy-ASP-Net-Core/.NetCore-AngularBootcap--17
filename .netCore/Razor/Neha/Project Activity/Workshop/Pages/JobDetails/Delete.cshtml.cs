using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop.Models;
using Workshop.Services;

namespace Workshop.Pages.JobDetails
{
    public class DeleteModel : PageModel
    {
        private readonly JobServices _services;
        [BindProperty]
        public Job JobPost { get; set; }
        public DeleteModel(JobServices services)
        {
            _services = services;

        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            JobPost = await _services.GetJobByIdAsync(id);
            if (JobPost == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _services.DeleteJobAsync(id);
            return RedirectToPage("Index");
        }
    }
}
