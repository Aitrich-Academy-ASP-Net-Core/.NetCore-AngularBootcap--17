using System;
using System.Collections.Generic;

namespace EF_data_fest_2.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int? Credits { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
