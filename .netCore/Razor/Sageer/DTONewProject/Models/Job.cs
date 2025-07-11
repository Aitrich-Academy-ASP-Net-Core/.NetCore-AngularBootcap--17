using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
namespace DTONewProject.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
    }
    }
