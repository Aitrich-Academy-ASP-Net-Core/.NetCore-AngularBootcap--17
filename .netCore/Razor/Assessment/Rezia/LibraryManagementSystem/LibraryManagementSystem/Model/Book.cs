using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity {  get; set; }
    }
}
