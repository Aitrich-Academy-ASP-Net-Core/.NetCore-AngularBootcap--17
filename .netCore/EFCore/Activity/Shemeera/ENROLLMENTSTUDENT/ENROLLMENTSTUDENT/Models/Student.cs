using System;
using System.Collections.Generic;

namespace ENROLLMENTSTUDENT.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string StudentName { get; set; } = null!;
    

    public int CourseId { get; set; }

    public virtual Course Course { get; set; } = null!;

    public List<Subject> Subjects { get; set; }= new List<Subject>();

   
}
