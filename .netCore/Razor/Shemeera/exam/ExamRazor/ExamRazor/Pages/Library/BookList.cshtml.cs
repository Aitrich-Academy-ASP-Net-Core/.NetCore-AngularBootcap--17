using ExamRazor.Interface;
using ExamRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ExamRazor.Pages.Library
{
    public class BookListModel : PageModel
    {
        private readonly ILibraryService _libraryService;

        public BookListModel(ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        public List<Book> Books { get; set; }

        public async Task OnGetAsync()
        {
            Books = await _libraryService.GetAllBooksAsync();
        }
    }
}

