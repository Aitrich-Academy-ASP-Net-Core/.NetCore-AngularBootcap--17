using System.ComponentModel.DataAnnotations;

namespace Workshop.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Jobtitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Employmenttype { get; set; }
        
        public string Salary { get; set; }
        public string JobDescription { get; set; }
        public string Requirements { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ExpirationDate { get; set; }

    }
}
