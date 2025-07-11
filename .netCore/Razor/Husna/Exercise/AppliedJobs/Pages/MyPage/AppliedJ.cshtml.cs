using AppliedJobs.Dto;
using AppliedJobs.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AppliedJobs.Pages.MyPage
{
    public class AppliedJModel : PageModel
    {
        private readonly IApplicationService _applicationService;

        public AppliedJModel(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }
        public string Message { get; set; } // ✅ Add this line

        public List<ApplicationDto> AppliedJobs { get; set; }

        public async Task OnGetAsync()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                Message = "Please login first.";
                AppliedJobs = new List<ApplicationDto>();
                return;
            }

            AppliedJobs = await _applicationService.GetAppliedJobsAsync(userId.Value);

            if (!AppliedJobs.Any())
            {
                Message = "No applied jobs found.";
            }
        }
    }
}
