using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [Table("FormResults")]
    public class FormResult
    {
        [Key]
        public int FormResultId { get; set; }
        public bool Confirmed { get; set; }
        public string Price { get; set; }
        public string ShiftWork { get; set; }
        public string ShiftWork2 { get; set; }
        public string MilitaryService { get; set; }
        public string EduStatus { get; set; }
        public string Address { get; set; }
        [ForeignKey("Form")]
        public virtual Form Form { get; set; }
    }
}