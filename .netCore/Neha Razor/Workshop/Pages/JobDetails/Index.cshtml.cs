using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop.Services;
using Workshop.Models;

namespace Workshop.Pages.JobDetails
{
    public class IndexModel : PageModel
    {
        private readonly JobServices _service;
        public List<Job> JobPosts { get; set; }

        public IndexModel(JobServices service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            JobPosts = await _service.GetAllJobsAsync();
        }
    }
}
