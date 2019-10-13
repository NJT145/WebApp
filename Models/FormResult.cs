using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class FormResult
    {
        [Key]
        public int FormResultId { get; set; }
        [ForeignKey("Form")]
        public int FormId { get; set; }
        public bool Confirmed { get; set; }
        public string Price { get; set; }
        public string ShiftWork { get; set; }
        public string ShiftWork2 { get; set; }
        public string MilitaryService { get; set; }
        public string EduStatus { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Form> Forms { get; set; }
    }
}