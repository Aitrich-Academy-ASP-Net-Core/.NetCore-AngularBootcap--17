using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // System users
        public DbSet<AuthUser> AuthUsers { get; set; }
        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }

        // Job posting & company
        public DbSet<JobProviderCompany> Companies { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }

        // Job applications
        public DbSet<JobApplication> JobApplications { get; set; }
        public DbSet<SavedJob> SavedJobs { get; set; }

        // Resume & profile
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }
        public DbSet<Qualification> Qualifications { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        // Messaging
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageGroup> MessageGroups { get; set; }

        // Signup requests
        public DbSet<SignUpRequest> SignUpRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // You can configure relationships, keys, indexes, etc. here if needed
        }
    }
}
