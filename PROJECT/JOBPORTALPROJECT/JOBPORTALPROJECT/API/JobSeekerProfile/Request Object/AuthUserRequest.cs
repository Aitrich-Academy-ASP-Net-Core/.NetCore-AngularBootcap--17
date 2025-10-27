namespace JOBPORTALPROJECT.API.JobSeekerProfile.Request_Object
{
    public class AuthUserRequest
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }

    }
}
