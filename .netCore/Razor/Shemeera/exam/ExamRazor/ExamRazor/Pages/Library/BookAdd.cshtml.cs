using ExamRazor.Interface;
using ExamRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamRazor.Pages.Library
{
    public class BookAddModel : PageModel
    {
        private readonly ILibraryService _libraryService;

        public BookAddModel(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [BindProperty]
        public Book NewBook { get; set; }

        

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _libraryService.AddBookAsync(NewBook);

            return RedirectToPage("BookList");
        }
    }
}
