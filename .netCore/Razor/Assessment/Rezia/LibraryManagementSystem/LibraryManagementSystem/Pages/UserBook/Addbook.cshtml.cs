using LibraryManagementSystem.Dto;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.UserBook
{
    public class AddbookModel : PageModel
    {
        private readonly BookService _service;

        public AddbookModel(BookService service)
        {
            _service = service;
        }
        [BindProperty]
        public BookDto AddBook { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _service.AddBookAsync(AddBook);
            return RedirectToPage("ViewBook");
        }

    }
}
