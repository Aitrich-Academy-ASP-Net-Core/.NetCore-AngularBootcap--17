using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Models;

public partial class Skill
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<JobSeekerProfileSkill> JobSeekerProfileSkills { get; set; } = new List<JobSeekerProfileSkill>();
}
