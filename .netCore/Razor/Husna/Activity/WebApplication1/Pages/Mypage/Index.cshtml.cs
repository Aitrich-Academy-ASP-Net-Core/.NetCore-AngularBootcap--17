using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Model;
using WebApplication1.Services;
using WebApplication1.Interface;

namespace WebApplication1.Pages.Mypage
{
    public class IndexModel : PageModel
    {

        private readonly IStudentService _service;
        public List<Student> students { get; set; } = new();

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; } // Captures query string

        public IndexModel(IStudentService service)
        {
            _service = service;
        }
        public async Task OnGetAsync()
        {
            var allStudents = await _service.GetAllStudentAsync();

            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                students = allStudents
                    .Where(s => s.Name.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
            else
            {
                students = allStudents;
            }

        }
    }
}

