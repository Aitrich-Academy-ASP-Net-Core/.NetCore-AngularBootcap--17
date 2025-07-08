using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using STUDENTINFOMATION.Interface;
using STUDENTINFOMATION.Model;
using STUDENTINFOMATION.Services;

namespace STUDENTINFOMATION.Pages.Studentinfo
{
    public class IndexModel : PageModel
    {

        public List<Student> Students { get; set; } = new();

        private  readonly StudentService _studentService;
        
        public IndexModel(StudentService studentService)
        {
            _studentService = studentService;
        }


        public async Task OnGetAsync()
        {

            Students = await _studentService.GetAllStudentAsync();



        }

    }
}
