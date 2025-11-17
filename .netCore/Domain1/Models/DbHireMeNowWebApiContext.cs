using System;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public class DbHireMeNowWebApiContext : DbContext
    {
        public DbHireMeNowWebApiContext() { }

        public DbHireMeNowWebApiContext(DbContextOptions<DbHireMeNowWebApiContext> options)
            : base(options) { }

        public virtual DbSet<AuthUser> AuthUsers { get; set; }
        public virtual DbSet<JobSeeker> JobSeekers { get; set; }

        public virtual DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }
        public virtual DbSet<JobSeekerProfileSkill> JobSeekerProfileSkills { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<JobProviderCompany> JobProviderCompanies { get; set; }
        public virtual DbSet<CompanyUser> CompanyUsers { get; set; }
        public virtual DbSet<JobPost> JobPosts { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Industry> Industries { get; set; }
        public virtual DbSet<SavedJob> SavedJobs { get; set; }
        public virtual DbSet<JobApplication> JobApplications { get; set; }
        public virtual DbSet<JobCategory> JobCategories { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<WorkExperience> WorkExperiences { get; set; }
        public virtual DbSet<SignUpRequest> SignUpRequests { get; set; }
        
        public virtual DbSet<Resume> Resumes { get; set; }
        public virtual DbSet<JobResponsibility> JobResponsibilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SystemUser>()
           .Property(e => e.Role)
           .HasConversion<string>();

            base.OnModelCreating(modelBuilder);



            // AuthUser defaults
            modelBuilder.Entity<AuthUser>()
                .Property(u => u.ConnectionId)
                .IsRequired(false);

            modelBuilder.Entity<AuthUser>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            // JobSeekerProfileSkill many-to-many
            modelBuilder.Entity<JobSeekerProfileSkill>()
                .HasKey(jps => new { jps.JobSeekerProfileId, jps.SkillId });

            modelBuilder.Entity<JobSeekerProfileSkill>()
                .HasOne(jps => jps.JobSeekerProfile)
                .WithMany(js => js.JobSeekerProfileSkills)
                .HasForeignKey(jps => jps.JobSeekerProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<JobSeekerProfileSkill>()
                .HasOne(jps => jps.Skill)
                .WithMany(s => s.JobSeekerProfileSkills)
                .HasForeignKey(jps => jps.SkillId)
                .OnDelete(DeleteBehavior.Cascade);

            // Prevent multiple cascade paths
            modelBuilder.Entity<JobPost>()
                .HasOne(j => j.Company)
                .WithMany(c => c.JobPosts)
                .HasForeignKey(j => j.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<JobPost>()
                .HasOne(j => j.PostedByNavigation)
                .WithMany(cu => cu.JobPosts)
                .HasForeignKey(j => j.PostedBy)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CompanyUser>()
                .HasOne(cu => cu.CompanyNavigation)
                .WithMany(c => c.CompanyUsers)
                .HasForeignKey(cu => cu.Company)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
