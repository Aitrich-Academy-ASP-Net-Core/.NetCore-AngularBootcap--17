using static System.Net.Mime.MediaTypeNames;

namespace AppliedJobs.Model
{
    public class Job
    {
        public int Id { get; set; }                     // Primary key (EF Core will auto-detect it)

        public string Title { get; set; } // Job title (e.g., Software Developer)
        public string Location { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }         // Details about the job

  
    }
}
