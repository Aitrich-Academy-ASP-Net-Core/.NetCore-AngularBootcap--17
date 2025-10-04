using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
   public class Company
    {
        public Guid Id { get; set; } 
        public string CompanyName { get; set; } 
        public string Email { get; set; } 
        public string Phone { get; set; } 
        public ICollection<Job> Jobs { get; set; }



    }
}
