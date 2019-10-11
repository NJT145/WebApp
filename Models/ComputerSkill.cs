﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class ComputerSkill
    {
        public int ComputerSkillId { get; set; }
        public string Name { get; set; }
        [Range(0, 3)]
        public int Level { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}