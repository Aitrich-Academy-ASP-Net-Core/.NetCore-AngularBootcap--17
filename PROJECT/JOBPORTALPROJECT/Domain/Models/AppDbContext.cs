using Domain.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
  
    public AppDbContext() { }

   
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
          
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
    public DbSet<ProfileSkill> ProfileSkills { get; set; }

    public DbSet<Job> Jobs { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        

        modelBuilder.Entity<Resume>()
            .HasOne(r => r.JobSeeker)
            .WithMany(j => j.Resumes)
            .HasForeignKey(r => r.JobSeekerId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Resume>()
            .HasOne(r => r.Profile)
            .WithMany(p => p.Resumes)
            .HasForeignKey(r => r.ProfileId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProfileSkill>()
            .HasKey(ps => new { ps.ProfileId, ps.SkillId });

        modelBuilder.Entity<ProfileSkill>()
            .HasOne(ps => ps.Profile);
            //.WithMany(p => p.Skills)
            //.HasForeignKey(ps => ps.ProfileId);

        modelBuilder.Entity<ProfileSkill>()
            .HasOne(ps => ps.Skill)
            .WithMany(s => s.ProfileSkills)
            .HasForeignKey(ps => ps.SkillId);
    }

}