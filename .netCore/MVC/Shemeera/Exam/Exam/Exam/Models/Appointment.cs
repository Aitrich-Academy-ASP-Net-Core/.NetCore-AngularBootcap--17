namespace Exam.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int PatientId { get; set; }
        public User Patient { get; set; }

        public DateTime AppointmentDateTime { get; set; }


    }
}
