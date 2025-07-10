using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Services;
using WebApplication1.StudentDto;
using WebApplication1.Interface;

namespace WebApplication1.Pages.Mypage
{
    public class CreateModel : PageModel
    {
        private readonly IStudentService _studentService;

        [BindProperty]
        public StudDto StudDto { get; set; } = new(); // form binding

        public CreateModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void OnGet()
        {
            // No logic required here for now
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page(); // Return form with validation messages
            }

            await _studentService.AddStudentAsync(StudDto);
            return RedirectToPage("Index");
        }
    }
}
