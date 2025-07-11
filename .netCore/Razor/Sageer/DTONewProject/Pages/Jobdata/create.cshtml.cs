using DTONewProject.DTO;
using DTONewProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DTONewProject.Pages.Jobdata
{


    public class AddJobModel : PageModel
    {

        [BindProperty]
        public JobDTO Jobs { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            return RedirectToPage("./Index");
        }
    }
}