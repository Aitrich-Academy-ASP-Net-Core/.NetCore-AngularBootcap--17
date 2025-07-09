using JobApplication.Service;
using Microsoft.AspNetCore.Mvc;
using JobApplication.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobApplication.Pages.Jobs
{
    public class EditModel : PageModel
    {
        private readonly JobService _service;

        [BindProperty]
        public Job JobPost { get; set; }

        public EditModel(JobService service)
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
