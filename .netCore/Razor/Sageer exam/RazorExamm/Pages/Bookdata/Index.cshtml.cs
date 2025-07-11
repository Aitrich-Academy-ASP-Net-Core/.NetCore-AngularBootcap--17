using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorExamm.Models;

namespace RazorExamm.Pages.Bookdata
{
    public class IndexModel : PageModel
    {
        public readonly BookDBContext _context;


        public IndexModel(BookDBContext context)
        {
            _context = context;
        }
        public List<Book> Bookdetails { get; set; }
        public string UserRole { get; set; }
        public async Task OnGetAsync()
        {
            UserRole = HttpContext.Session.GetString("UserRole");
            Bookdetails = await _context.Books.ToListAsync();
        }
    }
}