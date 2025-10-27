namespace JobPortalApp.API.JobSeekerr.RequestObjects;

public class JobseekerProfileRequest
{
   
    public Guid JobSeekerId { get; set; }

    public string? ProfileName { get; set; }

    public string? ProfileSummary { get; set; }
}
