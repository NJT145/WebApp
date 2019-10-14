using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WebApp.Models
{
    [Table("Forms")]
    public class Form
    {
        [Key]
        public int FormId { get; set; }

        [Required, StringLength(60, MinimumLength = 2)]
        public string FirstMidName { get; set; }

        [Required, StringLength(60, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required, DataType(DataType.PhoneNumber), DisplayFormat(DataFormatString = "{0: (###) ###-####}", ApplyFormatInEditMode = true)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        [Required, StringLength(250, MinimumLength = 5)]
        public string Address { get; set; }
        [StringLength(10, MinimumLength = 0)]
        public string MilitaryService { get; set; }
        public float? TshirtSize { get; set; }
        public float? PantSize { get; set; }
        public float? ShoesSize { get; set; }
        public bool? DrivingLicence { get; set; }

        [StringLength(10, MinimumLength = 0)]
        public string DrivingLicenceClass { get; set; }
        public bool? ForkliftLicence { get; set; }
        public bool? CraneOperationLicense { get; set; }
        public virtual CourseNSeminar CourseNSeminar { get; set; }
        public virtual LangInfo LangInfo { get; set; }
        public virtual ComputerSkill ComputerSkill { get; set; }

        // sağlık durumu ## 4.SAYFA ## ekle
        public bool? WorkingNow { get; set; }
        public string JobChangeReason { get; set; }
        public virtual JobHistory JobHistory { get; set; }
        public bool? Ok4Overtime { get; set; }
        public bool? Ok4ShiftWork { get; set; }
        public virtual FormResult FormResult { get; set; }
    }
}
