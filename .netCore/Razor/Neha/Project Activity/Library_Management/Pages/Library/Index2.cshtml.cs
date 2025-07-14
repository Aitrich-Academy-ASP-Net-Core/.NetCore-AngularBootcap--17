using Library_Management.DTO;
using Library_Management.Interfaces;
using Library_Management.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Library_Management.Models;

namespace Library_Management.Pages.Library
{
    public class Index2Model : PageModel
    {
        private readonly IBookService _bookService;

       
        public List<Book> Books2 { get; set; }
        public string Role { get; set; } = "";

        public Index2Model(BookService service)
        {
            _bookService = service;
        }

        public async Task OnGetAsync()
        {
            Role = HttpContext.Session.GetString("Role") ?? "";
            Books2 = await _bookService.GetAllBookAsync();
        }
    }
}
