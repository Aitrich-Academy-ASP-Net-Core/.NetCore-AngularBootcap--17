using JOBMANAGEMENT.Dto;
using JOBMANAGEMENT.Servive;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBMANAGEMENT.Pages.Jobmanage
{
    public class CreateModel : PageModel
    {
        private readonly JobService _service;

        [BindProperty]
        public JobsDto JobPost { get; set; }

        public CreateModel(JobService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.AddJobAsync(JobPost);
            return RedirectToPage("Index");
        }



    }
}
