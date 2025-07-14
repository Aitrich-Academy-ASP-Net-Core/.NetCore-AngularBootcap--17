using System.ComponentModel.DataAnnotations;

namespace razorrpagesneww.models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }

        public int Phone { get; set; }
    }
}
