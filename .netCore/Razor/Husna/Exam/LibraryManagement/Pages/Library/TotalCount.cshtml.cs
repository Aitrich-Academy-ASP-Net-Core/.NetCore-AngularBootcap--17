using LibraryManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagement.Pages.Library
{
    public class TotalCountModel : PageModel
    {
        private readonly IBookService _bookService;

        public TotalCountModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public int TotalCount { get; set; }
        public string Message { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {

            TotalCount = await _bookService.GetTotalBookCountAsync();
            return Page();
        }
    }
}
