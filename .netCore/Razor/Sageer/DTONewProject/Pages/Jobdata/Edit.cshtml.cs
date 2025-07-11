using DTONewProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DTONewProject.Pages.Jobdata
{
    
        public class EditModel : PageModel
        {
            private readonly JobDBContext _context;



            public EditModel(JobDBContext context)
            {
                _context = context;
            }

            [BindProperty]
            public Job Jobs { get; set; }
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
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                _context.Attach(Jobs).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");

            }
        }
    }
