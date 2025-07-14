using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisplayCurrentDateAndTime.Pages
{
    
     
        public class CurrentTimeModel : PageModel
        {
            public string CurrentDateTime { get; set; }

            public void OnGet()
            {
                CurrentDateTime = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt");
            }
        }
    }

  
