using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using STUDENTINFOMATION.Model;
using STUDENTINFOMATION.Services;
using STUDENTINFOMATION.Userdto;

namespace STUDENTINFOMATION.Pages.Studentinfo
{
    public class EDITModel : PageModel
    {
        private readonly StudentService _studentService;

        public EDITModel(StudentService studentService)
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
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _studentService.UpdateStudentAsync(Student);

            return RedirectToPage("Index");




        }
    }
}
