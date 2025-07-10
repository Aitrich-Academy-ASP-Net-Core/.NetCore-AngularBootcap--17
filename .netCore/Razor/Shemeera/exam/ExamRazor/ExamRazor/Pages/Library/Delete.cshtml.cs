using ExamRazor.Interface;
using ExamRazor.Model;
using ExamRazor.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamRazor.Pages.Library
{
    public class DeleteModel : PageModel
    {
        private readonly ILibraryService _libraryService;

        public DeleteModel(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Book = await _libraryService.GetBookByIdAsync(id);

            if (Book == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _libraryService.DeleteBookAsync(id);
            return RedirectToPage("BookList"); 
        }
    }
}
