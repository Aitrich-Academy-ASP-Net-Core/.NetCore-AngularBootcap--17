using System.ComponentModel.DataAnnotations;

namespace WebApplication1.StudentDto
{
    public class StudDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Range(1, 120)]
        public int? Age { get; set; }

        [Required]
        public string Course { get; set; }
    }
}
