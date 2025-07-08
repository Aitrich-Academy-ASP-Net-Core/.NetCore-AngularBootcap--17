using System.ComponentModel.DataAnnotations;

namespace STUDENTINFOMATION.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string StudentName { get; set; }
        
        public int Mark { get; set; }
        [Required]
        public string StudentEmail { get; set; }
      
        public int Age { get; set; }
        [Required]
        public string Course { get; set; }






    }
}
