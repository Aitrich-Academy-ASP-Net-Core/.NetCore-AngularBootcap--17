using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using STUDENTINFOMATION.Services;
using STUDENTINFOMATION.Userdto;

namespace STUDENTINFOMATION.Pages.Studentinfo
{
    public class DELETEModel : PageModel
    {
        private readonly StudentService _studentService;

        public DELETEModel(StudentService studentService)
        {
            _studentService = studentService;
        }

        [BindProperty]
        public Studentdto Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Student = await _studentService.GetStudentByIdAsync(id);
            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _studentService.DeleteStudentAsync(Student.StudentId);
            return RedirectToPage("Index");
        }
    }
}