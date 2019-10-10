using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WebApp.Models
{
    public class Form
    {
        public int FormID { get; set; }

        [Required, StringLength(60, MinimumLength = 2)]
        public string FirstMidName { get; set; }

        [Required, StringLength(60, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required]//, DataType(DataType.PhoneNumber), DisplayFormat(DataFormatString = "{0: (###) ###-####}", ApplyFormatInEditMode = true)]
        public string PhoneNumber { get; set; }

        [Required, StringLength(60, MinimumLength = 5)]
        public string Address { get; set; }

        public string MilitaryService { get; set; }
        public decimal TshirtSize { get; set; }
        public decimal PantSize { get; set; }
        public decimal ShoesSize { get; set; }
        public bool DrivingLicence { get; set; }

        [StringLength(10, MinimumLength = 0)]
        public string DrivingLicenceClass { get; set; }

        public bool ForkliftLicence { get; set; }
        public bool CraneOperationLicense { get; set; }
        [Key]
        [ForeignKey("CourseNSeminar")]
        public int CourseNSeminarID { get; set; }
        public virtual CourseNSeminar CourseNSeminar { get; set; }
        [Key]
        [ForeignKey("LangInfo")]
        public int LangInfoID { get; set; }
        public virtual LangInfo LangInfo { get; set; }
        [Key]
        [ForeignKey("ComputerSkill")]
        public int ComputerSkillID { get; set; }
        public virtual ComputerSkill ComputerSkill { get; set; }
        // sağlık durumu ## 4.SAYFA ## ekle
        public bool WorkingNow { get; set; }
        public string JobChangeReason { get; set; }
        [Key]
        [ForeignKey("JobHistory")]
        public int JobHistoryID { get; set; }
        public virtual JobHistory JobHistory { get; set; }
        public bool Ok4Overtime { get; set; }
        public bool Ok4ShiftWork { get; set; }
    }

    public class FormDbContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }
        public DbSet<CourseNSeminar> CourseNSeminar { get; set; }
        public DbSet<LangInfo> LangInfo { get; set; }
        public DbSet<ComputerSkill> ComputerSkill { get; set; }
        public DbSet<JobHistory> JobHistory { get; set; }
    }
}
