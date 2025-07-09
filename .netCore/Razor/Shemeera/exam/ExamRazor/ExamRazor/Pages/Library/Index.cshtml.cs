using ExamRazor.Interface;
using ExamRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExamRazor.Pages.Library
{
    public class IndexModel : PageModel
    {
        private readonly ILibraryService _service;

        public List<Book> Books { get; set; }
        public string Role { get; set; }

        public IndexModel(ILibraryService service)
        {
            _service = service;
        }

        public async Task OnGetAsync()
        {
            Role = HttpContext.Session.GetString("Role") ?? "Guest";
            Books = await _service.GetAllBooksAsync();
        }
    }
}
