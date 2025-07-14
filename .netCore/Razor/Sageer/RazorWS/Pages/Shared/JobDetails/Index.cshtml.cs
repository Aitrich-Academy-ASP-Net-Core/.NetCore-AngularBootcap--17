using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWS.Models;
using RazorWS.Services;

namespace RazorWS.Pages.Shared.JobDetails
{
    public class IndexModel : PageModel
    {
        private readonly JobServices _service;
        public List<JobApplication> JobPost { get; set; }

        public IndexModel(JobServices service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            JobPost = await _service.GetAllJobAsync();
        }
    }
}
