using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [Table("ComputerSkills")]
    public class ComputerSkill
    {
        [Key]
        public int ComputerSkillId { get; set; }
        [StringLength(250, MinimumLength = 0)]
        public string ComputerSkillName { get; set; }
        [Range(0, 4), DefaultValue(0)]
        public int ComputerSkillLevel { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}