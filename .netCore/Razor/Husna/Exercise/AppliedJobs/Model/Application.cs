namespace AppliedJobs.Model
{
    public class Application
    {
        public int Id { get; set; }

        // Foreign keys with conventional names
        public int UserId { get; set; }
        public int JobId { get; set; }

        public DateTime AppliedOn { get; set; }

        // Navigation properties
        public User User { get; set; }
        public Job Job { get; set; }
    }
}
