using JOBMANAGEMENT.Model;
using JOBMANAGEMENT.Servive;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBMANAGEMENT.Pages.Jobmanage
{
    public class IndexModel : PageModel
    {
        
        
            private readonly JobService _service;
            public List<Jobs> JobPosts { get; set; }

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




