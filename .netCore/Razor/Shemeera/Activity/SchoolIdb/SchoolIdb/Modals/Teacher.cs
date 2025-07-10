using System;
using System.Collections.Generic;

namespace SchoolIdb.Modals;

public partial class Teacher
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Subject { get; set; }

    public int? ExperienceYears { get; set; }
}
