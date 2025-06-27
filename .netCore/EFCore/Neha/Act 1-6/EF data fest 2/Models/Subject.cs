using System;
using System.Collections.Generic;

namespace EF_data_fest_2.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
