namespace MVC_EXAM_NEW.Models
{
    public class Enrolment
    {
        public int id { get; set; }
        public int Userid { get; set; }
        public User User { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
