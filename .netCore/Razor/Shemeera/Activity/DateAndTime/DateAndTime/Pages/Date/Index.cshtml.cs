using DateAndTime.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DateAndTime.Pages.Date
{
    public class IndexModel : PageModel
    {

        //private readonly CountryContext _context;

        //public IndexModel(CountryContext context)
        //{
        //    _context = context;
        //}
        //public IList<Country> CountryList { get; set; }

        //public string CurrentDateTime { get; set; }

        //public async Task OnGetAsync()
        //{
        //    CountryList = await _context.Countries.ToListAsync();
        //    CurrentDateTime = DateTime.Now.ToString("F");
        //}

        public string CurrentDateTime { get; set; }

        public void OnGet()
        {
            CurrentDateTime = DateTime.Now.ToString("F"); // Full date & time
        }




    }
}
