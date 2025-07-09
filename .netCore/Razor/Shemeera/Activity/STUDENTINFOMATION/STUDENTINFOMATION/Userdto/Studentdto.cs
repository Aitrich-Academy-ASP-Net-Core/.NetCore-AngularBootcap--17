using System.ComponentModel.DataAnnotations;

namespace STUDENTINFOMATION.Userdto
{
    public class Studentdto
    {
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        [EmailAddress]
        public string StudentEmail { get; set; }

        [Required]
        public string Course { get; set; }




    }
}
