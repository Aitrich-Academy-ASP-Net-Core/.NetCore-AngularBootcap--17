using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleAuthorization.Pages.Mypage
{
    public class Index1Model : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Index1Model(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
