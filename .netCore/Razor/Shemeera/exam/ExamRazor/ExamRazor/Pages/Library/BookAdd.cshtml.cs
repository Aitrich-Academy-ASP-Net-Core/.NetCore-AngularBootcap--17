using ExamRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamRazor.Pages.Library
{
    public class BookAddModel : PageModel
    {
        private readonly LibraryDbContext _context;

        public BookAddModel(LibraryDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book NewBook { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Books.Add(NewBook);
            await _context.SaveChangesAsync();

            return RedirectToPage("BookList");
        }
    }
}
