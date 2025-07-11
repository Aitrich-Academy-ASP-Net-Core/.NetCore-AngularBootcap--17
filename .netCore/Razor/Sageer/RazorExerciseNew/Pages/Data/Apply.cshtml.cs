using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExerciseNew.Models.RazorWS.Models;
using RazorExerciseNew.Models;

namespace RazorExerciseNew.Pages.Data
{
    public class ApplyModel : PageModel
    {
        public class ApplyModel : PageModel
        {
            private readonly ApplicationDbContext _context;
            private readonly UserManager<IdentityUser> _userManager;

            public ApplyModel(ApplicationDbContext context, UserManager<IdentityUser> userManager)
            {
                _context = context;
                _userManager = userManager;
            }

            public Job Job { get; set; }

            public async Task<IActionResult> OnGetAsync(int id)
            {
                Job = await _context.Jobs.FindAsync(id);
                if (Job == null)
                {
                    return NotFound();
                }
                return Page();
            }

            public async Task<IActionResult> OnPostAsync(int id)
            {
                var user = await _userManager.GetUserAsync(User);
                var application = new Application
                {
                    id = id,
                    Id = user.Id,
                    PostedDate = DateTime.Now
                };

                _context.Applications.Add(application);
                await _context.SaveChangesAsync();
                return RedirectToPage("/AppliedJobs/Index");
            }
        }
    }
}
