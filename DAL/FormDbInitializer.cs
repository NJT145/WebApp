using System;
using WebApp.Models;

namespace WebApp.DAL
{
    public class FormDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<FormDbContext>
    {
        protected override void Seed(FormDbContext context)
        {
            var emptyComputerSkill = new ComputerSkill { ComputerSkillName = "", ComputerSkillLevel = 0 };
            var emptyCourseNSeminar = new CourseNSeminar { Certificate = "", Topic = "" };
            var emptyJobHistory = new JobHistory { JobHistoryName = "", Mission = "", WorkDays = 0, Reason4Leaving = "" };
            var emptyLangInfo = new LangInfo { LangInfoName = "", LangInfoLevel = 0 };
            var form1 = new Form
            {
                FirstMidName = "Adam",
                LastName = "AdamPie",
                BirthDate = DateTime.Parse("2005-09-01"),
                PhoneNumber = "5303003030",
                Address = "KISIKLI MAH., Alemdag Cad., Yanyol Sok., No 6-8, 34692, ÜSKÜDAR / ISTANBUL / TURKEY",
                MilitaryService = "Yapıldı",
                TshirtSize = float.Parse("53,5"),
                PantSize = float.Parse("64,5"),
                ShoesSize = float.Parse("64,5"),
                DrivingLicence = true,
                DrivingLicenceClass = "A",
                ForkliftLicence = true,
            };
            form1.ComputerSkill = emptyComputerSkill;
            form1.CourseNSeminar = emptyCourseNSeminar;
            form1.JobHistory = emptyJobHistory;
            form1.LangInfo = emptyLangInfo;
            context.Forms.Add(form1);
            context.SaveChanges();
        }
    }
}
