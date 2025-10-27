using System.ComponentModel.DataAnnotations;




    namespace JobSeekerManagement.Dto
    {
    public class JobDto
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Company { get; set; } = string.Empty;

        [Required]
        public string Location { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        public string SalaryRange { get; set; } = string.Empty;

        [Required]
        public string EmploymentType { get; set; } = string.Empty;
    }
}
    
    



