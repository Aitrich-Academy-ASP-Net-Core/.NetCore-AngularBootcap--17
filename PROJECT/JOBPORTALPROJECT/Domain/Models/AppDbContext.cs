using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Domain.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        // DbSets
        public DbSet<AuthUser> AuthUsers { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }
      
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<SavedJob> SavedJobs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageGroup> MessageGroups { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // JobSeeker ↔ AuthUser (1-to-1)
            modelBuilder.Entity<JobSeeker>()
                .HasOne(js => js.AuthUser)
                .WithOne()
                .HasForeignKey<JobSeeker>(js => js.AuthUserId);

            // JobSeeker ↔ JobSeekerProfiles (1-to-many)
            modelBuilder.Entity<JobSeeker>()
                .HasMany(js => js.Profiles)
                .WithOne(p => p.JobSeeker)
                .HasForeignKey(p => p.JobSeekerId)
                .OnDelete(DeleteBehavior.Cascade);

            // JobSeekerProfile ↔ Resume (1-to-many)
            modelBuilder.Entity<JobSeekerProfile>()
                .HasMany(p => p.Resumes)
                .WithOne(r => r.Profile)
                .HasForeignKey(r => r.ProfileId);

            // JobSeekerProfile ↔ Skills (1-to-many)
            modelBuilder.Entity<JobSeekerProfile>()
                .HasMany(p => p.Skills)
                .WithOne(s => s.Profile)
                .HasForeignKey(s => s.ProfileId);

            // JobSeekerProfile ↔ WorkExperiences (1-to-many)
            modelBuilder.Entity<JobSeekerProfile>()
                .HasMany(p => p.WorkExperiences)
                .WithOne(w => w.Profile)
                .HasForeignKey(w => w.ProfileId);

            // JobSeekerProfile ↔ Qualifications (1-to-many)
            modelBuilder.Entity<JobSeekerProfile>()
                .HasMany(p => p.Qualifications)
                .WithOne(q => q.Profile)
                .HasForeignKey(q => q.ProfileId);

            // JobSeeker ↔ JobApplications (1-to-many)
            modelBuilder.Entity<JobSeeker>()
                .HasMany(js => js.Applications)
                .WithOne(app => app.JobSeeker)
                .HasForeignKey(app => app.JobSeekerId);

            // JobPost ↔ JobApplications (1-to-many)
            modelBuilder.Entity<JobPost>()
                .HasMany(jp => jp.Applications)
                .WithOne(app => app.JobPost)
                .HasForeignKey(app => app.JobPostId);

            // JobSeeker ↔ JobPost (many-to-many via SavedJob)
            modelBuilder.Entity<SavedJob>()
                .HasKey(sj => new { sj.JobSeekerId, sj.JobPostId });

            modelBuilder.Entity<SavedJob>()
                .HasOne(sj => sj.JobSeeker)
                .WithMany(js => js.SavedJobs)
                .HasForeignKey(sj => sj.JobSeekerId);

            modelBuilder.Entity<SavedJob>()
                .HasOne(sj => sj.JobPost)
                .WithMany(jp => jp.SavedBy)
                .HasForeignKey(sj => sj.JobPostId);

            // Message ↔ MessageGroup (many-to-one)
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Group)
                .WithMany(g => g.Messages)
                .HasForeignKey(m => m.GroupId);



      }  }
}
