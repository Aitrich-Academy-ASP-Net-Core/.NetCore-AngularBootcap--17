using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Qualification
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string Degree { get; set; }
        public string Institution { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FieldOfStudy { get; set; }
        public string Grade { get; set; }
    }
}
