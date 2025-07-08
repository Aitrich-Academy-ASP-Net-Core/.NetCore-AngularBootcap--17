using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop.DTO;
using Workshop.Services;

namespace Workshop.Pages.JobDetails
{
    public class CreateModel : PageModel
    {
        private readonly JobServices _service;

        [BindProperty]
        public JobDto JobPost { get; set; }

        public CreateModel(JobServices service)
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

