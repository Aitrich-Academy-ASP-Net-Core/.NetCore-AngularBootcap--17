using System.ComponentModel.DataAnnotations;

namespace Employe_Activity.Models
{
    public class Employe
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        [Range(1000,100000)]
        public string Salary { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
