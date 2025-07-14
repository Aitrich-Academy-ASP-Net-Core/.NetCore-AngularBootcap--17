using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razorrpagesneww.models;

namespace razorrpagesneww.Pages.Studentss
{
    public class IndexModel : PageModel
    {
        private readonly StudentDBContext _context;
        public IndexModel(StudentDBContext context)
        {
            _context = context;
        }

        public IList<Student> StudentList { get; set; }
        //public void OnGet() 
        //{
        //}
        public async Task OnGetAsync()
        {
            StudentList = await _context.Students.ToListAsync();
        }
    }
}
