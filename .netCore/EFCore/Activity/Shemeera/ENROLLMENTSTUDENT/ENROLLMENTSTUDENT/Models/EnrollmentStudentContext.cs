using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ENROLLMENTSTUDENT.Models;

public partial class EnrollmentStudentContext : DbContext
{
    public EnrollmentStudentContext()
    {
    }

    public EnrollmentStudentContext(DbContextOptions<EnrollmentStudentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Student> Students { get; set; }


    public virtual DbSet<Subject> Subjects { get; set; }

  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=SHEMEERA_1990\\SQLEXPRESS;Initial Catalog=EnrollmentSTUDENT;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Courseid).HasName("PK__Course__C9D27D8F33ED51BF");

            entity.ToTable("Course");

            entity.Property(e => e.Coursename)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("coursename");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B99D346B585");

            entity.ToTable("Student");

            entity.Property(e => e.StudentName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Course).WithMany(p => p.Students)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Student__CourseI__4BAC3F29");
        });

        modelBuilder.Entity<Student>()
       .HasMany(s => s.Subjects)
       .WithMany(sub => sub.Students)
       .UsingEntity(j => j.ToTable("StudentSubject"));


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
