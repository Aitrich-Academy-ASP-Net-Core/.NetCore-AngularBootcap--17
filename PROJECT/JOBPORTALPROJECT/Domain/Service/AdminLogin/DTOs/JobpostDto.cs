using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.AdminLogin.DTOs
{
    public class JobpostDto
    {
        public Guid Id { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string LocationName { get; set; }   
        public string IndustryName { get; set; }   
        public string JobCategoryName { get; set; } 
        public string PostedByName { get; set; }    
        public DateTime PostDate { get; set; }
    }

}
