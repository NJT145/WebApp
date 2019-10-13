using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [Table("JobHistories")]
    public class JobHistory
    {
        [Key]
        public int JobHistoryId { get; set; }
        [StringLength(250, MinimumLength = 0)]
        public string JobHistoryName { get; set; }
        [StringLength(250, MinimumLength = 0)]
        public string Mission { get; set; }
        [Range(0,1000000)]
        public int WorkDays { get; set; }
        [StringLength(250, MinimumLength = 0)]
        public string Reason4Leaving { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}