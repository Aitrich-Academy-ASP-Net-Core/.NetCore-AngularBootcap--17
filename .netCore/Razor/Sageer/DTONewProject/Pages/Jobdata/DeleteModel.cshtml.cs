using DTONewProject.DTO;
using DTONewProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DTONewProject.Pages.Jobdata
{
    
        public class DeleteeModeModel : PageModel
        {


            private readonly JobDBContext _context;

            public DeleteeModeModel(JobDBContext context)
            {
                _context = context;
            }

            [BindProperty]
            public JobDTO Jobs { get; set; }

            public async Task<IActionResult> OnGetAsync(int id)
            {
                Jobs = await _context.Jobs.FindAsync(id);

                if (Jobs == null)
                {
                    return NotFound();
                }

                return Page();
            }

            public async Task<IActionResult> OnPostAsync()
            {
                var employee = await _context.Jobs.FindAsync(Jobs.JobId);

                if (employee == null)
                {
                    return NotFound();
                }

                _context.Jobs.Remove(employee);
                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }
        }
    }
    
