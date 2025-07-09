using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
    }
}
