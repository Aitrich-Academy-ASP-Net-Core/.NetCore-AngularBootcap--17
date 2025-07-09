using JOBMANAGEMENT.Model;
using JOBMANAGEMENT.Servive;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBMANAGEMENT.Pages.Jobmanage
{
    public class EditModel : PageModel
    {


        private readonly JobService _service;

        [BindProperty]
        public Jobs JobPost { get; set; }

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
    }  }

