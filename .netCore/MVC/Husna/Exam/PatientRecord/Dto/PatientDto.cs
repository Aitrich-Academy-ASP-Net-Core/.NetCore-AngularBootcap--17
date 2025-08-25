using System.ComponentModel.DataAnnotations;

namespace PatientRecord.Dto
{
    public class PatientDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; } = "";
        [Phone]
        public string ContactNumber { get; set; } = "";
        public string MedicalHistory { get; set; } = "";
        [DataType(DataType.Date)]
        public DateTime DateOfVisit { get; set; }
    }
}
