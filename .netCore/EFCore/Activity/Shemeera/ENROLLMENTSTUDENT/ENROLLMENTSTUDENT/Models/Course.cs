using System;
using System.Collections.Generic;

namespace ENROLLMENTSTUDENT.Models;

public partial class Course
{
    public int Courseid { get; set; }

    public string? Coursename { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
