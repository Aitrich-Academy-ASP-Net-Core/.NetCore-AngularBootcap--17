using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExamm.Models;

namespace RazorExamm.Pages.Bookdata
{
    public class CreateModel : PageModel
    {
        private readonly BookDBContext _context;
        public CreateModel(BookDBContext context)
        {
            _context = context;
        }
        public Book book { get; set; }
        //public string role { get; set; }
        public  OnGet()
        {
            var role = HttpContext.Session.GetString("UserRole");
            
            if (role == "Admin")
            {
                return Page();
            }
            return RedirectToPage("Index");


        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
