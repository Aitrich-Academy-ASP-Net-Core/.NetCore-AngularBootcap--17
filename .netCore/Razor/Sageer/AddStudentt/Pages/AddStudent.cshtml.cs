using AddStudentt.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddStudentt.Pages
{
    public class AddStudentModel : PageModel
    {
        
            [BindProperty]
            public Student Student { get; set; }

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

                // Here you would typically save the student to a database
                // For this example, we'll just redirect
                return RedirectToPage("./Index");
            }
        }
}
