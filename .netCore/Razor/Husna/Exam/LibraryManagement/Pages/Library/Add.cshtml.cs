using LibraryManagement.Dto;
using LibraryManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagement.Pages.Library
{
    public class AddModel : PageModel
    {
        private readonly IBookService _bookService;

        public AddModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        [BindProperty]
        public Bookdto BookDto { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {


            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _bookService.AddBookAsync(BookDto);
            return RedirectToPage("Index1");
        }
    }
}

