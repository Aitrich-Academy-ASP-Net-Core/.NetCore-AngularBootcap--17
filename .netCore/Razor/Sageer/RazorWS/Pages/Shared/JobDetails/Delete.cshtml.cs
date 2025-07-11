using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWS.Models;
using RazorWS.Services;

namespace RazorWS.Pages.Shared.JobDetails
{
    public class DeleteModel : PageModel
    {
        private readonly JobServices _service;
        public DeleteModel(JobServices service)
        {
            _service = service;
        }
        [BindProperty]
        public JobApplication JobPost { get; set; }
        public async Task <ActionResult> OnGetAsync(int id)
        {
            JobPost = await _service.GetJobByIdAsync(id);
            if (JobPost == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task <ActionResult> OnPostAsync(int id)
        {
            await _service.DeleteJobAsync(id);
            return RedirectToPage("index");
        }
    }
}
