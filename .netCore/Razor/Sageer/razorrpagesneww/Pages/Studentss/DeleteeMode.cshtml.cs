using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorrpagesneww.models;

namespace razorrpagesneww.Pages.Studentss
{
    public class DeleteeModeModel : PageModel
    {
       
        
            private readonly StudentDBContext _context;

            public DeleteeModeModel(StudentDBContext context)
            {
                _context = context;
            }

            [BindProperty]
            public Student student { get; set; }

            public async Task<IActionResult> OnGetAsync(int id)
            {
                student = await _context.Students.FindAsync(id);

                if (student == null)
                {
                    return NotFound();
                }

                return Page();
            }

            public async Task<IActionResult> OnPostAsync()
            {
                var employee = await _context.Students.FindAsync(Student.id);

                if (employee == null)
                {
                    return NotFound();
                }

                _context.Students.Remove(employee);
                await _context.SaveChangesAsync();

                return RedirectToPage("Index");
            }
        }
    }

