using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DefaultValue(false)]
        public bool FormResultConfirmed { get; set; }
        public string FormResultPrice { get; set; }
        public string FormResultShiftWork { get; set; }
        public string FormResultShiftWork2 { get; set; }
        public string FormResultMilitaryService { get; set; }
        public string FormResultEduStatus { get; set; }
        public string FormResultAddress { get; set; }
        public virtual Form Form { get; set; }
    }
}