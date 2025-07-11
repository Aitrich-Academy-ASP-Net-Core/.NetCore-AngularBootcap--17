using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWS.DTO;
using RazorWS.Models;
using RazorWS.Services;

namespace RazorWS.Pages.Shared.JobDetails
{
    
       
            public class CreateModel : PageModel
        {
            private readonly JobServices _service;

            [BindProperty]
            public JobDto JobPost { get; set; }

            public CreateModel(JobServices jobservice)
            {
            _service = jobservice ;
            }

            public async Task<IActionResult> OnPostAsync()
            {
                if (!ModelState.IsValid)
                    return Page();

                await _service.AddJobAsync(JobPost);
                return RedirectToPage("Index");
            }
        }
    }
