using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;
using WebApplication1.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Interface;

namespace WebApplication1.Pages.Mypage
{
    
    public class DeleteModel : PageModel
    {
        private readonly IStudentService _studentService;

        public DeleteModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public Student student { get; set; } // Display-only

        public async Task<IActionResult> OnGetAsync(int id)
        {
            // Optional: Show confirmation with student details
            var allStudents = await _studentService.GetAllStudentAsync();
            student = allStudents.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _studentService.DeleteStudentAsync(id);
            return RedirectToPage("Index");
        }

    }
}
