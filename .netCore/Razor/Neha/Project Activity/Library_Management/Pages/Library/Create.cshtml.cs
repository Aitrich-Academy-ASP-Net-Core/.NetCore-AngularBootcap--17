// --- Pages/Library/Create.cshtml.cs ---
using Library_Management.DTO;
using Library_Management.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Library_Management.Repository;

namespace Library_Management.Pages.Library
{
    public class CreateModel : PageModel
    {
        private readonly BookService _service;

        [BindProperty]
        public BookDto Books3 { get; set; }

        public CreateModel(BookService service)
        {
            _service = service;
        }

        public IActionResult OnGet()
        {
            var role = HttpContext.Session.GetString("Role");
            if (role != "Admin")
                return RedirectToPage("/Login");

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
               { return Page(); }

            await _service.AddBookAsync(Books3);
            return RedirectToPage("Index2");
        }
    }
}
