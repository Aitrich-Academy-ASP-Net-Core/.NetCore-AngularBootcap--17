using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
   public class Job
    {
        public Guid Id { get; set; } 
        public string Title { get; set; } 
        public string Description { get; set; } 
        public Guid CompanyId { get; set; } 
        public string Location { get; set; }
        
        [Precision(18, 2)]
        public decimal Salary { get; set; } 
        public DateTime PostedDate { get; set; } = DateTime.UtcNow;



        public JobProviderCompany Company { get; set; }



    }


}

