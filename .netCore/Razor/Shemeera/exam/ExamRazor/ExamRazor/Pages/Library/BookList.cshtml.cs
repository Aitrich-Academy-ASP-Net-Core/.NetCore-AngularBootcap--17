using ExamRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ExamRazor.Pages.Library
{
    public class BookListModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public BookListModel(LibraryDbContext context)
        {
            _context = context;
        }

        public List<Book> Books { get; set; }

        public async Task OnGetAsync()
        {
            Books = await _context.Books.ToListAsync();
        }
    }
}

