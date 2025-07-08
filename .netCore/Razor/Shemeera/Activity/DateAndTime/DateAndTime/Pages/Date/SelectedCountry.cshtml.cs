using Azure;
using DateAndTime.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.Mime.MediaTypeNames;

namespace DateAndTime.Pages.Date
{
    public class SelectedCountryModel : PageModel

    {
        private readonly CountryContext _context;

        public SelectedCountryModel(CountryContext context)
        {
            _context = context;
        }

        public Country CountryData { get; set; } = new Country();

        public IList<SelectListItem> Countries { get; set; }

        public void OnGet()
        {
            LoadCountries();
        }

        public void OnPost()
        {
            LoadCountries();
        }

        private void LoadCountries()
        {
            Countries = new List<SelectListItem>
    {
        new SelectListItem("India", "India"),
        new SelectListItem("USA", "USA"),
        new SelectListItem("UK", "UK"),
        new SelectListItem("Germany", "Germany"),
        new SelectListItem("Japan", "Japan")
    };











        }





    }
}
