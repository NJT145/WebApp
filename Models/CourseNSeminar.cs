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
        public int CourseNSeminarId { get; set; }
        public string Certificate { get; set; }
        public string Topic { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}