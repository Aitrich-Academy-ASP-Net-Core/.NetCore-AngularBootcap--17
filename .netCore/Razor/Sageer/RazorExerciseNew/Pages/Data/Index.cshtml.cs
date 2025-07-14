using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExerciseNew.Models.RazorWS.Models;
using RazorExerciseNew.Models;

namespace RazorExerciseNew.Pages.Data
{
    
        public class IndexModel : PageModel
        {
            private readonly ApplicationDbContext _context;

            public IndexModel(ApplicationDbContext context)
            {
                _context = context;
            }

            public IList<Job> Jobs { get; set; }

            public async Task OnGetAsync()
            {
                Jobs = await _context.Jobs.ToListAsync();
            }
        }
    }

