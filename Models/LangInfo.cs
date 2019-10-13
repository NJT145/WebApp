using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [Table("LangInfos")]
    public class LangInfo
    {
        [Key]
        public int LangInfoId { get; set; }
        [StringLength(30, MinimumLength = 0)]
        public string Name { get; set; }
        [Range(0, 4)]
        public int Level { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}