using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using STUDENTINFOMATION.Model;
using STUDENTINFOMATION.Services;
using STUDENTINFOMATION.Userdto;

namespace STUDENTINFOMATION.Pages.Studentinfo
{
    public class CreateModel : PageModel
    {

        private readonly StudentService _studentService;

        public CreateModel(StudentService studentService)
        {
            _studentService = studentService;
        }
        [BindProperty]
        public Studentdto Student { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_studentService.Students.Add(Student);
            //await _studentService.SaveChangesAsync();
            //return RedirectToPage("index");


            await _studentService.AddStudentAsync(Student); 
                
            return RedirectToPage("Index"); 

        }


}
}
