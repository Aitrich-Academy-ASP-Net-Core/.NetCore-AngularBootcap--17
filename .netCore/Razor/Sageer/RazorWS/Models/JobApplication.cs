namespace RazorWS.Models
{
    public class JobApplication
    {
        public int id { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Salary { get; set; }
        public string JobType { get; set; }
        public string Description { get; set; }
        public string Requirements { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
