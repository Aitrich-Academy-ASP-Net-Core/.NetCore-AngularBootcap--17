namespace JOBPORTALPROJECT.API.JobSeekerProfile.Request_Object
{
    public class ResumeUpdateRequest
    {

        public Guid ProfileId { get; set; }
        public IFormFile File { get; set; }
    }
}
