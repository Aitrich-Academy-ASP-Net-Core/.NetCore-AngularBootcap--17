using System.ComponentModel.DataAnnotations;

namespace Mini_project.Models
{
    public class CompanyMember
    {
        [Key]
        public int MemberId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public string Position { get; set; }
       
    }
}
