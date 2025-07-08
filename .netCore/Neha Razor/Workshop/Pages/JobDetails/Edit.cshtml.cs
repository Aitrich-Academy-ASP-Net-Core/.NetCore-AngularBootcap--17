using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop.Interfaces;
using Workshop.Models;
using Workshop.Services;


namespace Workshop.Pages.JobDetails
{
    public class EditModel : PageModel
    {
        private readonly JobServices _service;

        [BindProperty]
        public Job JobPost { get; set; }

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

        public async Task<IActionResult> OnPostAsync()
        {

            await _service.UpdateJobAsync(JobPost.Id, JobPost);
            return RedirectToPage("Index");
        }
    }
}

