using AppliedJobs.Interface;
using AppliedJobs.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppliedJobs.Pages.MyPage
{
    public class IndexModel : PageModel
    {
        private readonly IJobService _jobService;
        private readonly IApplicationService _applicationService;

        public IndexModel(IJobService jobService, IApplicationService applicationService)
        {
            _jobService = jobService;
            _applicationService = applicationService;
        }

        public List<Job> Jobs { get; set; }

        [BindProperty]
        public int JobId { get; set; }

        public string Message { get; set; }

        public async Task OnGetAsync()
        {
            Jobs = await _jobService.GetAllJobsAsync();
        }

        public async Task<IActionResult> OnPostApplyAsync(int jobId)
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                Message = "Please login first.";
                Jobs = await _jobService.GetAllJobsAsync();
                return Page();
            }

            await _applicationService.ApplyToJobAsync(jobId, userId.Value);
            Message = "Successfully applied!";
            Jobs = await _jobService.GetAllJobsAsync();
            return Page();
        }
    }
}
