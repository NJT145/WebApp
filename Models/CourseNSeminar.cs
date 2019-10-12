using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class CourseNSeminar
    {
        [Key]
        public int CourseNSeminarId { get; set; }
        [ForeignKey("Form")]
        public int FormId { get; set; }
        public string Certificate { get; set; }
        public string Topic { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}