using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProfileSkill
    {
        public Guid ProfileId { get; set; }
        public JobSeekerProfile Profile { get; set; } = null!;

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; } = null!;

        public DateTime AddedOn { get; set; }
    }

}
