using System.ComponentModel.DataAnnotations;

namespace Workshop.DTO
{
    public class JobDto
    {
        public string Jobtitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Employmenttype { get; set; }
        [Range(1000, 100000)]
        public string Salary { get; set; }
        public string JobDescription { get; set; }
        public string Requirements { get; set; }
    }
}
