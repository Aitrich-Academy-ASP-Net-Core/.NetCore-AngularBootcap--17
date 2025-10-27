namespace JOBPORTALPROJECT.API.JobSeekerProfile.Request_Object
{
    public class WorkExperienceRequest
    {
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public bool IsCurrentJob { get; set; }


    }
}
