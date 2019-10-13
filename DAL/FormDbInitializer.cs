using System;
using WebApp.Models;

namespace WebApp.DAL
{
    public class FormDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FormDbContext>
    {
        protected override void Seed(FormDbContext context)
        {
            // default values for empty values
            context.ComputerSkills.Add(new ComputerSkill { Name = "", Level = 0 });
            context.CourseNSeminars.Add(new CourseNSeminar { Certificate = "", Topic = "" });
            context.JobHistories.Add(new JobHistory { Name = "", Mission = "", WorkDays = 0, Reason4Leaving = "" });
            context.LangInfos.Add(new LangInfo { Name = "", Level = 0 });
            context.SaveChanges();

            var form1 = new Form
            {
                FirstMidName = "Adam",
                LastName = "AdamPie",
                BirthDate = DateTime.Parse("2005-09-01"),
                PhoneNumber = "(530) 300-3030",
                Address = "KISIKLI MAH., Alemdag Cad., Yanyol Sok., No 6-8, 34692, ÜSKÜDAR / ISTANBUL / TURKEY",
                MilitaryService = "Yapıldı",
                TshirtSize = float.Parse("53,5"),
                PantSize = float.Parse("64,5"),
                ShoesSize = float.Parse("64,5"),
                DrivingLicence=true,
                DrivingLicenceClass="A",
                ForkliftLicence=true,
            };
            context.Forms.Add(form1);
            context.SaveChanges();
        }
    }
}
