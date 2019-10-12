using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class JobHistory
    {
        [Key]
        public int JobHistoryId { get; set; }
        [ForeignKey("Form")]
        public int FormId { get; set; }
        public string Name { get; set; }
        public string Mission { get; set; }
        public int WorkDays { get; set; }
        public string Reason4Leaving { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}