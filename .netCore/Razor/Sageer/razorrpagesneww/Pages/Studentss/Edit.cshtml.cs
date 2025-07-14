using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorrpagesneww.models;

namespace razorrpagesneww.Pages.Studentss
{
    public class EditModel : PageModel
    {
        private readonly StudentDBContext _context;



        public EditModel(StudentDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Student { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Student = await _context.Students.FindAsync(id);

            if (Student == null)
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
            _context.Attach(Student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");

        }
    }
}

