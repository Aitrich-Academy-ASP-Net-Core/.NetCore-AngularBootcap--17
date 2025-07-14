using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorrpagesneww.models;

namespace razorrpagesneww.Pages.Studentss
{
    public class CreateModelModel : PageModel
    {


        private readonly StudentDBContext _context;

        public CreateModelModel(StudentDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student student { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
