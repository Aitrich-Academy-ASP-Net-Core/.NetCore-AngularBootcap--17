using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExamm.Models;

namespace RazorExamm.Pages.Bookdata
{
    public class DeleteModel : PageModel
    {
        private readonly BookDBContext _context;
        public DeleteModel(BookDBContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Book book { get; set; }
        public string role { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            role = HttpContext.Session.GetString("UserRole");
            if (role == "Admin")
            {
                return RedirectToPage();
            }
            return Page();
        }
    }
}
