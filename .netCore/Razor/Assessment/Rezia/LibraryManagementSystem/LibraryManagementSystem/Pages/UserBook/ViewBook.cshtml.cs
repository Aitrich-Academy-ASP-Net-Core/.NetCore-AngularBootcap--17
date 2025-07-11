using LibraryManagementSystem.Model;
using LibraryManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.UserBook
{
    public class ViewBookModel : PageModel
    {
        private readonly BookService _service;
        [BindProperty]
        public List<Book> booklist {  get; set; }
        public ViewBookModel(BookService service)
        {
            _service = service;
        }   
        public async Task OnGetAsync()
        {
            booklist = await _service.GetAllBooksAsync();


        }
    }
}
