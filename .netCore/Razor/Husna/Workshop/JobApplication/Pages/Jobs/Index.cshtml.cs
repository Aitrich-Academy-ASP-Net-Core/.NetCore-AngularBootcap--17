using Microsoft.AspNetCore.Mvc;
using JobApplication.Model;
using JobApplication.Service;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobApplication.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        private readonly JobService _service;
        public List<Job> JobPosts { get; set; }

        public IndexModel(JobService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            JobPosts = await _service.GetAllJobsAsync();
        }
    }
}
