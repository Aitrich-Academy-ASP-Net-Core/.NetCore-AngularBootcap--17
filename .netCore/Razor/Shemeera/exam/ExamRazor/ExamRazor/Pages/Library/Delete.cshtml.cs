using ExamRazor.Interface;
using ExamRazor.Model;
using ExamRazor.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamRazor.Pages.Library
{
    public class DeleteModel : PageModel
    {
        private readonly ILibraryService _service;
        public DeleteModel(LibraryService service)
        {
            _service = service;
        }

        [BindProperty]
        public Book BookToDelete { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            BookToDelete = await _service.Books.FindAsync(id);

            if (BookToDelete == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var book = await _service.Books.FindAsync(id);

            if (book == null)
                return NotFound();

            _service.Books.Remove(book);
            await _service.SaveChangesAsync();

            return RedirectToPage("BookList");
        }
    }
}
