using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DropdownList.Pages;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

    public class IndexModel : PageModel
    {
        [BindProperty]
        [Display(Name = "Country")]
        public string SelectedCountry { get; set; }

        public List<SelectListItem> CountryList { get; set; }

        public IndexModel()
        {
            // Initialize the country list
            CountryList = new List<SelectListItem>
            {
                new SelectListItem { Value = "USA", Text = "United States" },
                new SelectListItem { Value = "Canada", Text = "Canada" },
                new SelectListItem { Value = "UK", Text = "United Kingdom" },
                new SelectListItem { Value = "Australia", Text = "Australia" },
                new SelectListItem { Value = "Japan", Text = "Japan" }
            };
        }

        public void OnGet()
        {
            // Page load, no additional logic needed
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Return the same page to display the selected country
            return Page();
        }
    }


