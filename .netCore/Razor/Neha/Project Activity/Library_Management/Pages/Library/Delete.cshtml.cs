using Library_Management.Models;
using Library_Management.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Library_Management.Pages.Library
{
    public class DeleteModel : PageModel
    {
        private readonly BookService _services;
        [BindProperty]
        public Book Bookdelete { get; set; }
        public DeleteModel(BookService services)
        {
            _services = services;

        }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            var role = HttpContext.Session.GetString("Role");
            if (role != "Admin")
               { 
                return RedirectToPage("/Login");

                return Page();
            }
            Bookdelete = await _services.GetAllBookByIdAsync(id);
            if (Bookdelete == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int id)
        {
            await _services.DeleteBookAsync(id);
            return RedirectToPage("Index2");
        }
    }
}

