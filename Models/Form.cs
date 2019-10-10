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
        public virtual CourseNSeminar CourseNSeminar { get; set; }
        public virtual LangInfo LangInfo { get; set; }
        public virtual ComputerSkill ComputerSkill { get; set; }
        // sağlık durumu ## 4.SAYFA ## ekle
        public bool WorkingNow { get; set; }
        public string JobChangeReason { get; set; }
        public virtual JobHistory JobHistory { get; set; }
        public bool Ok4Overtime { get; set; }
        public bool Ok4ShiftWork { get; set; }
        // 5.SAYFA gerisi eklenecek
    }

    public class FormDbContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }
        public DbSet<CourseNSeminar> CourseNSeminars { get; set; }
        public DbSet<LangInfo> LangInfos { get; set; }
        public DbSet<ComputerSkill> ComputerSkills { get; set; }
        public DbSet<JobHistory> JobHistorys { get; set; }
    }
}
