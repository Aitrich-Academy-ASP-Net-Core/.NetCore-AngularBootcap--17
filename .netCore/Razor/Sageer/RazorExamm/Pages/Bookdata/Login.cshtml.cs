using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExamm.Models;

namespace RazorExamm.Pages.Bookdata
{
    public class LoginModel : PageModel
    {
        
        public string Uname { get; set; }
        public string role { get; set; }
       
        
       
        public  OnPost()
        {
            if (!string.IsNullOrEmpty(role))
            {
                HttpContext.Session.GetString("UserRole");
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
