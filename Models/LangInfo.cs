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
        [StringLength(120, MinimumLength = 0)]
        public string LangInfoName { get; set; }
        [Range(0, 4)]
        public int LangInfoLevel { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}