using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models;

public partial class JobSeekerProfile
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid JobSeekerId { get; set; }

    public string? ProfileName { get; set; }
    public string? ProfileSummary { get; set; }

    [JsonIgnore]
    public virtual ICollection<JobSeekerProfileSkill> JobSeekerProfileSkills { get; set; } = new List<JobSeekerProfileSkill>();

    // Other navigation properties
    [JsonIgnore]
    public virtual ICollection<Qualification> Qualifications { get; set; } = new List<Qualification>();
    [JsonIgnore]
    public virtual ICollection<WorkExperience> WorkExperiences { get; set; } = new List<WorkExperience>();
    public Guid? ResumeId { get; set; }
    [JsonIgnore]
    [ForeignKey("ResumeId")]
    public virtual Resume? Resume { get; set; }
    [ForeignKey("JobSeekerId")]
    public virtual JobSeeker JobSeeker { get; set; } = null!;


}
