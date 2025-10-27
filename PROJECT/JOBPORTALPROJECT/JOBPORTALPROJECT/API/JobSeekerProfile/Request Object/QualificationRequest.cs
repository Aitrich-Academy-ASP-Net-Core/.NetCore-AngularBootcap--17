namespace JOBPORTALPROJECT.API.JobSeekerProfile.Request_Object
{
    public class QualificationRequest
    {
        public string InstitutionName { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double? Grade { get; set; }
        public string Description
        {
            get; set;
        }

    }
}
