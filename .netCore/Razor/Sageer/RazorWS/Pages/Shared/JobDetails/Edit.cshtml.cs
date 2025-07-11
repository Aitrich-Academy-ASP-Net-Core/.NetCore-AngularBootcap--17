using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWS.Models;
using RazorWS.Services;

namespace RazorWS.Pages.Shared.JobDetails
{
    public class EditModel : PageModel
    {
        private readonly JobServices _service;
        [BindProperty]
        public JobApplication JobPost { get; set; }
        public EditModel(JobServices service)
        {
            _service = service;
        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var jobDto = await _service.GetJobByIdAsync(id);
                if (jobDto == null)
            {
                return NotFound();
            }
            JobPost = jobDto;
            return Page();
        }
    }
}
