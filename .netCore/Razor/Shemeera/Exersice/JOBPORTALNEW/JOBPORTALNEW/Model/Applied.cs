namespace JOBPORTALNEW.Model
{
    public class Applied
    {

        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }
        public DateTime AppliedDate { get; set; }



    }
}
