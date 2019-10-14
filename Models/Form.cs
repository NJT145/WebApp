using System;
using System.ComponentModel;
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

    public enum LevelEnum
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
        [Display(Name = "Ad")]
        public string FirstMidName { get; set; }

        [Required, StringLength(60, MinimumLength = 2)]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }

        [Required, DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }

        [Required, DataType(DataType.PhoneNumber), DisplayFormat(DataFormatString = "{0: (###) ###-####}", ApplyFormatInEditMode = true)]
        [Display(Name = "Cep Tel. No")]
        public string PhoneNumber { get; set; }

        [Required, StringLength(250, MinimumLength = 5)]
        [Display(Name = "İkametgah Adresi")]
        public string Address { get; set; }
        [Display(Name = "Askerlik Durumu")]
        public MilitaryServiceEnum? MilitaryServiceEnum { get; set; }
        [Display(Name = "T-Shırt Bedeni")]
        public float? TshirtSize { get; set; }
        [Display(Name = "Pantolon Bedeni")]
        public float? PantSize { get; set; }
        [Display(Name = "Ayakkabı No")]
        public float? ShoesSize { get; set; }
        [Display(Name = "Oto Ehliyeti")]
        public bool? DrivingLicence { get; set; }

        [StringLength(10, MinimumLength = 0)]
        [Display(Name = "Sınıfı")]
        public string DrivingLicenceClass { get; set; }
        [Display(Name = "Forklift Ehliyeti")]
        public bool? ForkliftLicence { get; set; }
        [Display(Name = "Vinç Kullanma Ehliyeti")]
        public bool? CraneOperationLicense { get; set; }
        
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "İlkokul")]
        public string PrimarySchool_name { get; set; }

        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Ortaokul")]
        public string SecondarySchool_name { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Lise")]
        public string HighSchool_name { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Ön Lisans")]
        public string AssociateDegree_name { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Lisans")]
        public string BachelorDegree_name { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Yüksek Lisans")]
        public string MasterDegree_name { get; set; }

        //#region: remove these part after make it dynamic
        [StringLength(250, MinimumLength = 0)][Display(Name = "Sertifika1")]
        public string CourseNSeminar1_Certificate { get; set; }

        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Konu1")]
        public string CourseNSeminar1_Topic { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Sertifika2")]
        public string CourseNSeminar2_Certificate { get; set; }

        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Konu2")]
        public string CourseNSeminar2_Topic { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Sertifika3")]
        public string CourseNSeminar3_Certificate { get; set; }

        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Konu3")]
        public string CourseNSeminar3_Topic { get; set; }
        //#endregion: remove these part after make it dynamic
        //#region: remove these part after make it dynamic
        [Display(Name = "İNGİLİZCE")]
        public LevelEnum? LangInfo_eng { get; set; }
        [Display(Name = "ALMANCA")]
        public LevelEnum? LangInfo_de { get; set; }
        [Display(Name = "FRANSIZCA")]
        public LevelEnum? LangInfo_fr { get; set; }
        [Display(Name = "DİĞER")]
        public LevelEnum? LangInfo_other { get; set; }
        [Display(Name = "DİĞER - adı")]
        public string LangInfo_other_name { get; set; }
        //#endregion: remove these part after make it dynamic
        //#region: remove these part after make it dynamic
        [Display(Name = "WORD")]
        public LevelEnum? ComputerSkill_word { get; set; }
        [Display(Name = "EXCEL")]
        public LevelEnum? ComputerSkill_excel { get; set; }
        [Display(Name = "POWERPOINT")]
        public LevelEnum? ComputerSkill_powerpoint { get; set; }
        [Display(Name = "DİĞER1")]
        public string ComputerSkill_other1 { get; set; }
        [Display(Name = "DİĞER2")]
        public string ComputerSkill_other2 { get; set; }
        [Display(Name = "DİĞER3")]
        public string ComputerSkill_other3 { get; set; }
        //#endregion: remove these part after make it dynamic
        //#region: manage here at a separate table
        [Display(Name = "Görevinizi yapmanıza engel bir sağlık probleminiz var mı ?")]
        public bool? HealthQuestion1 { get; set; }
        [Display(Name = "Sigara kullanıyormusunuz?")]
        public bool? HealthQuestion2 { get; set; }
        [Display(Name = "Göz rahatsızlığınız var mı ?")]
        public bool? HealthQuestion3 { get; set; }
        [Display(Name = "Beliniz ile ilgili bir probleminiz var mı?")]
        public bool? HealthQuestion4 { get; set; }
        [Display(Name = "Psikolojik bir rahatsızlık geçirdiniz mi?")]
        public bool? HealthQuestion5 { get; set; }
        [Display(Name = "Ameliyat oldunuz mu?")]
        public bool? HealthQuestion6 { get; set; }
        //#endregion: manage here at a separate table
        [Display(Name = "Aleyhinizde kesinleşmiş herhangi bir hukuki ceza varmı? ")]
        public bool? LegalObstacle { get; set; }
        [Display(Name = "Şu anda bir yerde çalışıyormusunuz?")]
        public bool? WorkingNow { get; set; }
        [Display(Name = "İşinizi neden değiştirmek istiyorsunuz?")]
        public string JobChangeReason { get; set; }
        //#region: remove these part after make it dynamic
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "İş Yeri Adı")]
        public string JobHistoryName1 { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Görevi")]
        public string JobHistoryMission1 { get; set; }
        [Range(0, 1000000), DefaultValue(0)]
        [Display(Name = "Çalışma Süresi")]
        public int? JobHistoryWorkDays1 { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Ayrılma Nedeni")]
        public string JobHistoryReason4Leaving1 { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "İş Yeri Adı")]
        public string JobHistoryName2 { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Görevi")]
        public string JobHistoryMission2 { get; set; }
        [Range(0, 1000000), DefaultValue(0)]
        [Display(Name = "Çalışma Süresi")]
        public int? JobHistoryWorkDays2 { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Ayrılma Nedeni")]
        public string JobHistoryReason4Leaving2 { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "İş Yeri Adı")]
        public string JobHistoryName3 { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Görevi")]
        public string JobHistoryMission3 { get; set; }
        [Range(0, 1000000), DefaultValue(0)]
        [Display(Name = "Çalışma Süresi")]
        public int? JobHistoryWorkDays3 { get; set; }
        [StringLength(250, MinimumLength = 0)]
        [Display(Name = "Ayrılma Nedeni")]
        public string JobHistoryReason4Leaving3 { get; set; }
        //#endregion: remove these part after make it dynamic
        [Display(Name = "Gereğinde Fazla Mesai Yapabilir misiniz")]
        public bool? Ok4Overtime { get; set; }
        [Display(Name = "Vardiyalı Çalışabilir misiniz ")]
        public bool? Ok4ShiftWork { get; set; }
        public FormResult FormResult { get; set; }
    }
}
