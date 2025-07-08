using JOBPORTALNEW.Interface;
using JOBPORTALNEW.JobDto;
using JOBPORTALNEW.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JOBPORTALNEW.Pages.Portal
{
        public class IndexModel : PageModel
       {
    //        private readonly IService _service;

    //        public IndexModel(IService service)
    //        {
    //            _service = service;
    //        }

    //        public List<JobsDto> Jobs { get; set; } = new();

    //        [BindProperty]
    //        public int UserId { get; set; }

    //        public string Message { get; set; } = "";

    //        public async Task OnGetAsync()
    //        {
    //            Jobs = await _service.GetAllJobsAsync();
    //            UserId = 1; // Simulate user login for testing
    //        }

    //        public async Task<IActionResult> OnPostApplyAsync(int jobId, int userId)
    //        {
    //            await _service.ApplyToJobAsync(jobId, userId);
    //            Message = "Applied successfully!";
    //            return RedirectToPage("Applied"); // Redirect to refresh the list
    //        }


    private readonly IService _service;

    public IndexModel(IService service)
    {
        _service = service;
    }

    public List<JobsDto> Jobs { get; set; } = new();

    [BindProperty]
    public int UserId { get; set; }

    public string Message { get; set; } = "";

    public async Task OnGetAsync()
    {
        Jobs = await _service.GetAllJobsAsync();
        UserId = 1; 
    }

    public async Task<IActionResult> OnPostApplyAsync(int jobId, int userId)
    {
        await _service.ApplyToJobAsync(jobId, userId);

       
        Jobs = await _service.GetAllJobsAsync();
        UserId = userId;

      
        Message = "Job applied successfully!";

        return Page(); 
    }
}




    }

