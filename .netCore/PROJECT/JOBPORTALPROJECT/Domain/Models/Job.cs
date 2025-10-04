using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
   public class Job
    {
        public Guid Id { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; } 
        public Guid CompanyId { get; set; } 
        public string Location { get; set; } 
        public decimal Salary { get; set; } 
        public DateTime PostedDate { get; set; } = DateTime.UtcNow; 
    }


}

