using DTONewProject.Interfaces;
using DTONewProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using System.Threading.Tasks;
using DTONewProject.Services;

namespace DTONewProject.Pages.Jobdata
{
    public class JobIndexModel : PageModel
        
    {
        private readonly Jservice _jservice;

        public JobIndexModel(Jservice jservice)
        {
            _jservice = jservice;
        }

        public IList<Job> Jobs { get; set; }

        public async Task OnGetAsync()
        {
            Jobs = await _jservice.GetAllJobsAsync();
        }

        //public List <Job> Jobs { get; set; }

        //private readonly Jservice _Jobservice;

        //public JobIndexModel(Jservice jobservice )
        //{
        //    _Jobservice = jobservice;
        //}

        //public async Task OnGet()
        //{
        //    Jobs = await _Jobservice.GetAllJobsAsync();
        //}
    }
}
