using LibraryManagementSystem.Model;
using LibraryManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LibraryManagementSystem.Pages.UserBook
{
    public class DeleteBookModel : PageModel
    {
      private readonly BookService _service;

        public DeleteBookModel(BookService service)
        {
            _service = service;
        }
        [BindProperty]
        public Book Bookpost { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Bookpost = await _service.GetBookByIdAsync(id);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
           
            if(Bookpost == null)
            {
                return NotFound();
            }
            await _service.DeleteBookAsync(Bookpost.Id);
            return RedirectToPage("ViewBook");
        }
        

       

    }
}
