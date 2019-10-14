using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web;
using WebApp.DAL;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FormViewController : Controller
    {
        private FormDbContext db = new FormDbContext();

        // GET: FormView
        public ActionResult Index()
        {
            return View();
        }


        // GET: FormView/_Index
        public ActionResult _Index()
        {
            return PartialView(db.Forms.ToList());
        }

        // GET: FormView/_Details/5
        public ActionResult _Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Form form = db.Forms.Find(id);
            if (form == null)
            {
                return HttpNotFound();
            }
            return PartialView(form);
        }

        // GET: FormView/_Create
        public ActionResult _Create()
        {
            return PartialView();
        }

        // POST: FormView/_Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Create([Bind(Include = "FormId,FirstMidName,LastName,BirthDate,PhoneNumber,Address,MilitaryService,MilitaryServiceEnum,TshirtSize,PantSize,ShoesSize,DrivingLicence,DrivingLicenceClass,ForkliftLicence,CraneOperationLicense,PrimarySchool_bool,PrimarySchool_name,SecondarySchool_bool,SecondarySchool_name,HighSchool_bool,HighSchool_name,AssociateDegree_bool,AssociateDegree_name,BachelorDegree_bool,BachelorDegree_name,MasterDegree_bool,MasterDegree_name,CourseNSeminar1_Certificate,CourseNSeminar1_Topic,CourseNSeminar2_Certificate,CourseNSeminar2_Topic,CourseNSeminar3_Certificate,CourseNSeminar3_Topic,LangInfo_eng,LangInfo_de,LangInfo_fr,LangInfo_other,LangInfo_other_name,ComputerSkill_word,ComputerSkill_excel,ComputerSkill_powerpoint,ComputerSkill_other1,ComputerSkill_other2,ComputerSkill_other3,HealthQuestion1,HealthQuestion2,HealthQuestion3,HealthQuestion4,HealthQuestion5,HealthQuestion6,LegalObstacle,WorkingNow,JobChangeReason,JobHistoryName1,JobHistoryMission1,JobHistoryWorkDays1,JobHistoryReason4Leaving1,JobHistoryName2,JobHistoryMission2,JobHistoryWorkDays2,JobHistoryReason4Leaving2,JobHistoryName3,JobHistoryMission3,JobHistoryWorkDays3,JobHistoryReason4Leaving3,Ok4Overtime,Ok4ShiftWork")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Forms.Add(form);
                db.SaveChanges();
                return RedirectToAction("_Index");
            }

            return PartialView(form);
        }

        // GET: FormView/_Edit/5
        public ActionResult _Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Form form = db.Forms.Find(id);
            if (form == null)
            {
                return HttpNotFound();
            }
            return PartialView(form);
        }

        // POST: FormView/_Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Edit([Bind(Include = "FormId,FirstMidName,LastName,BirthDate,PhoneNumber,Address,MilitaryService,MilitaryServiceEnum,TshirtSize,PantSize,ShoesSize,DrivingLicence,DrivingLicenceClass,ForkliftLicence,CraneOperationLicense,PrimarySchool_bool,PrimarySchool_name,SecondarySchool_bool,SecondarySchool_name,HighSchool_bool,HighSchool_name,AssociateDegree_bool,AssociateDegree_name,BachelorDegree_bool,BachelorDegree_name,MasterDegree_bool,MasterDegree_name,CourseNSeminar1_Certificate,CourseNSeminar1_Topic,CourseNSeminar2_Certificate,CourseNSeminar2_Topic,CourseNSeminar3_Certificate,CourseNSeminar3_Topic,LangInfo_eng,LangInfo_de,LangInfo_fr,LangInfo_other,LangInfo_other_name,ComputerSkill_word,ComputerSkill_excel,ComputerSkill_powerpoint,ComputerSkill_other1,ComputerSkill_other2,ComputerSkill_other3,HealthQuestion1,HealthQuestion2,HealthQuestion3,HealthQuestion4,HealthQuestion5,HealthQuestion6,LegalObstacle,WorkingNow,JobChangeReason,JobHistoryName1,JobHistoryMission1,JobHistoryWorkDays1,JobHistoryReason4Leaving1,JobHistoryName2,JobHistoryMission2,JobHistoryWorkDays2,JobHistoryReason4Leaving2,JobHistoryName3,JobHistoryMission3,JobHistoryWorkDays3,JobHistoryReason4Leaving3,Ok4Overtime,Ok4ShiftWork")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("_Index");
            }
            return PartialView(form);
        }

        // GET: FormView/_Delete/5
        public ActionResult _Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Form form = db.Forms.Find(id);
            if (form == null)
            {
                return HttpNotFound();
            }
            return PartialView(form);
        }

        // POST: FormView/_Delete/5
        [HttpPost, ActionName("_Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult _DeleteConfirmed(int id)
        {
            Form form = db.Forms.Find(id);
            db.Forms.Remove(form);
            db.SaveChanges();
            return RedirectToAction("_Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
