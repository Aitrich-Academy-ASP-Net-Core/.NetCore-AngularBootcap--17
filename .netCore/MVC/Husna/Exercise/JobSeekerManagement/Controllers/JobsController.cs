using JobSeekerManagement.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekerManagement.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        public async Task<IActionResult> JobList(int? id)
        {
           
            var jobs = await _jobService.GetAllAsync();

            // If a specific job id is passed, load details into ViewBag
            if (id.HasValue)
            {
                var selectedJob = await _jobService.GetByIdAsync(id.Value);
                ViewBag.SelectedJob = selectedJob;
            }

           
            return View(jobs);
        }


     

    }


}
