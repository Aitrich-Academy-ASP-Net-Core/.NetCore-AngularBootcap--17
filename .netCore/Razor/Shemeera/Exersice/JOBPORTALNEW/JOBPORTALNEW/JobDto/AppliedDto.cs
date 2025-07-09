namespace JOBPORTALNEW.JobDto
{
    public class AppliedDto
    {

        public int Id { get; set; }
        public int JobId { get; set; }
        public int UserId { get; set; }
        public DateTime AppliedDate { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }



    }
}
