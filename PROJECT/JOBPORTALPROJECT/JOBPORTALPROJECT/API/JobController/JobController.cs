using Microsoft.AspNetCore.Mvc;

namespace JOBPORTALPROJECT.API.JobController
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
