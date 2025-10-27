using JobSeekerManagement.Dto;
using JobSeekerManagement.Interface;
using JobSeekerManagement.Service;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekerManagement.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly IApplicationService _appService;
        private readonly IJobService _jobService;   // ✅ add this

        public ApplicationController(IApplicationService appService, IJobService jobService)
        {
            _appService = appService;
            _jobService = jobService;   // ✅ assign here
        }

      
        public async Task<IActionResult> ApplyJob(int jobId)
        {
            var userId = HttpContext.Session.GetString("UserId");

            await _appService.ApplyAsync(jobId, userId);

            TempData["Message"] = "✅ Successfully applied for this job!"; // use TempData so it survives redirect

            // redirect to JobsController -> JobList action
            return RedirectToAction("JobList", "Jobs");
        }




        public async Task<IActionResult> MyApplications()
        {
            var userId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
            var applications = await _appService.GetByUserIdAsync(userId);
            return View(applications); // @model IEnumerable<ApplicationDto>
        }


    }
}
