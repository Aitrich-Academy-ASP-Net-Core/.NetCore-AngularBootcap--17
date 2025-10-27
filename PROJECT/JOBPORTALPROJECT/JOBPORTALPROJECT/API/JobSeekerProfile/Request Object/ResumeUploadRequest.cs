using System.ComponentModel.DataAnnotations;

namespace JOBPORTALPROJECT.API.JobSeekerProfile.Request_Object
{
    public class ResumeUploadRequest
    {
        public Guid ProfileId { get; set; }
        public string Title { get; set; }
       


    }
}
