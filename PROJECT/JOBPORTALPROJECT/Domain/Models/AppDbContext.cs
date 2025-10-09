using Domain.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    // ✅ Needed for EF CLI
    public AppDbContext() { }

    // ✅ Used by runtime DI
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // ✅ Correct database name
            optionsBuilder.UseSqlServer("Data Source=shemeera_1990\\sqlexpress;Initial Catalog=Projectdotnetcore;Integrated Security=True;Trust Server Certificate=True");
        }
    }

    // DbSets...

    public DbSet<Admin> Admins { get; set; }

    public DbSet<AuthUser> AuthUsers { get; set; }
    public DbSet<JobSeeker> JobSeekers { get; set; }
    public DbSet<CompanyUser> CompanyUsers { get; set; }
    public DbSet<JobProviderCompany> Companies { get; set; }
    public DbSet<JobPost> JobPosts { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Industry> Industries { get; set; }
    public DbSet<JobCategory> JobCategories { get; set; }
    public DbSet<JobApplication> JobApplications { get; set; }
    public DbSet<SavedJob> SavedJobs { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<JobSeekerProfile> JobSeekerProfiles { get; set; }
    public DbSet<Qualification> Qualifications { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<MessageGroup> MessageGroups { get; set; }
    public DbSet<SignUpRequest> SignUpRequests { get; set; }
    public DbSet<Job> Jobs { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}