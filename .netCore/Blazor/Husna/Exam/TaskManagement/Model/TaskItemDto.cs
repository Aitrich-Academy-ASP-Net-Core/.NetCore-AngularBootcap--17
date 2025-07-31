using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Model
{
    public class TaskItemDto
    {
        public int Id { get; set; }
        [Required]
        public string TaskTitle { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsFinished { get; set; } 
    }
}
