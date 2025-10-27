namespace JobPortalApp.API.JobSeekerr.RequestObjects
{
    public class QualificationsRequestDto
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public Guid? JobseekerProfileId { get; set; }

      
    }
}
