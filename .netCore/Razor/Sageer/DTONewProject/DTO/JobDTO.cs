using DTONewProject.Models;

namespace DTONewProject.DTO
{
    public class JobDTO
    {
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string JobType { get; set; }
        public object?[]? JobId { get; internal set; }

        public static implicit operator JobDTO?(Job? v)
        {
            throw new NotImplementedException();
        }
    }
}
