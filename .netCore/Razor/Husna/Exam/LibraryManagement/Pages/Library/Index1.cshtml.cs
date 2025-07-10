using LibraryManagement.Interface;
using LibraryManagement.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagement.Pages.Library
{
    public class Index1Model : PageModel
    {
        private readonly IBookService _bookService;

        public Index1Model(IBookService bookService)
        {
            _bookService = bookService;
        }

        public List<Book> Books { get; set; }
        public string Role { get; set; }

        public async Task OnGetAsync()
        {
            Role = HttpContext.Session.GetString("Role") ?? "User";
            Books = await _bookService.GetAllBooksAsync();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
           
            
                await _bookService.DeleteBookAsync(id);
            
            return RedirectToPage();
        }
    }
}
