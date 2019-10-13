using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    [Table("CourseNSeminars")]
    public class CourseNSeminar
    {
        [Key]
        public int CourseNSeminarId { get; set; }
        [StringLength(250, MinimumLength = 0)]
        public string Certificate { get; set; }
        [StringLength(250, MinimumLength = 0)]
        public string Topic { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}