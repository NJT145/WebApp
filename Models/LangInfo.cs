using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class LangInfo
    {
        [Key]
        public int LangInfoId { get; set; }
        [ForeignKey("Form")]
        public int FormId { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}