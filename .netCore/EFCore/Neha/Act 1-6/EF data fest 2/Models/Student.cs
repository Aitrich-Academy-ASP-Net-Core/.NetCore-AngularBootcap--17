using System;
using System.Collections.Generic;

namespace EF_data_fest_2.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();
}
