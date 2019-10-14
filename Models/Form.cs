using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public enum MilitaryServiceEnum
    {
        [Display(Name = "Yapıldı")]
        value1,
        [Display(Name = "Terhis")]
        value2,
        [Display(Name = "Tecil")]
        value3,
        [Display(Name = "Muaf")]
        value4
    }

    public enum LangInfoEnum
    {
        [Display(Name = "Az")]
        value1,
        [Display(Name = "Orta")]
        value2,
        [Display(Name = "İyi")]
        value3
    }

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
        public string PhoneNumber { get; set; }

        [Required, StringLength(250, MinimumLength = 5)]
        public string Address { get; set; }

        [StringLength(10, MinimumLength = 0)]
        public string MilitaryService { get; set; }
        public MilitaryServiceEnum? MilitaryServiceEnum { get; set; }
        public float? TshirtSize { get; set; }
        public float? PantSize { get; set; }
        public float? ShoesSize { get; set; }
        public bool? DrivingLicence { get; set; }

        [StringLength(10, MinimumLength = 0)]
        public string DrivingLicenceClass { get; set; }

        public bool? ForkliftLicence { get; set; }
        public bool? CraneOperationLicense { get; set; }

        public bool? PrimarySchool_bool { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string PrimarySchool_name { get; set; }

        public bool? SecondarySchool_bool { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string SecondarySchool_name { get; set; }
        public bool? HighSchool_bool { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string HighSchool_name { get; set; }
        public bool? AssociateDegree_bool { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string AssociateDegree_name { get; set; }
        public bool? BachelorDegree_bool { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string BachelorDegree_name { get; set; }
        public bool? MasterDegree_bool { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string MasterDegree_name { get; set; }

        public virtual CourseNSeminar CourseNSeminar { get; set; }
        //#region: remove these part after make it dynamic
        [StringLength(250, MinimumLength = 0)]
        public string CourseNSeminar1_Certificate { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string CourseNSeminar1_Topic { get; set; }
        [StringLength(250, MinimumLength = 0)]
        public string CourseNSeminar2_Certificate { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string CourseNSeminar2_Topic { get; set; }
        [StringLength(250, MinimumLength = 0)]
        public string CourseNSeminar3_Certificate { get; set; }

        [StringLength(250, MinimumLength = 0)]
        public string CourseNSeminar3_Topic { get; set; }
        //#endregion: remove these part after make it dynamic
        public virtual LangInfo LangInfo { get; set; }
        //#region: remove these part after make it dynamic
        public LangInfoEnum? LangInfo_eng { get; set; }
        public LangInfoEnum? LangInfo_de { get; set; }
        public LangInfoEnum? LangInfo_fr { get; set; }
        public LangInfoEnum? LangInfo_other { get; set; }
        public string LangInfo_other_name { get; set; }
        //#endregion: remove these part after make it dynamic
        public virtual ComputerSkill ComputerSkill { get; set; }
        //#region: remove these part after make it dynamic
        
        //#endregion: remove these part after make it dynamic
        // sağlık durumu ## 4.SAYFA ## ekle
        public bool? WorkingNow { get; set; }

        public string JobChangeReason { get; set; }
        public virtual JobHistory JobHistory { get; set; }
        public bool? Ok4Overtime { get; set; }
        public bool? Ok4ShiftWork { get; set; }
        public virtual FormResult FormResult { get; set; }
    }
}
