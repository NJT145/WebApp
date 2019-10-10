using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FormsController : Controller
    {
        private FormDbContext db = new FormDbContext();

        // GET: Forms
        public ActionResult Index()
        {
            var forms = db.Forms.Include(f => f.ComputerSkill).Include(f => f.CourseNSeminar).Include(f => f.JobHistory).Include(f => f.LangInfo);
            return View(forms.ToList());
        }

        // GET: Forms/Details/5
        public ActionResult Details(int? id)
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
            return View(form);
        }

        // GET: Forms/Create
        public ActionResult Create()
        {
            ViewBag.ComputerSkillId = new SelectList(db.ComputerSkills, "ComputerSkillId", "Name");
            ViewBag.CourseNSeminarId = new SelectList(db.CourseNSeminars, "CourseNSeminarId", "Certificate");
            ViewBag.JobHistoryId = new SelectList(db.JobHistorys, "JobHistoryId", "Name");
            ViewBag.LangInfoId = new SelectList(db.LangInfos, "LangInfoId", "Name");
            return View();
        }

        // POST: Forms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FormId,FirstMidName,LastName,BirthDate,PhoneNumber,Address,MilitaryService,TshirtSize,PantSize,ShoesSize,DrivingLicence,DrivingLicenceClass,ForkliftLicence,CraneOperationLicense,CourseNSeminarId,LangInfoId,ComputerSkillId,WorkingNow,JobChangeReason,JobHistoryId,Ok4Overtime,Ok4ShiftWork")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Forms.Add(form);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ComputerSkillId = new SelectList(db.ComputerSkills, "ComputerSkillId", "Name", form.ComputerSkillId);
            ViewBag.CourseNSeminarId = new SelectList(db.CourseNSeminars, "CourseNSeminarId", "Certificate", form.CourseNSeminarId);
            ViewBag.JobHistoryId = new SelectList(db.JobHistorys, "JobHistoryId", "Name", form.JobHistoryId);
            ViewBag.LangInfoId = new SelectList(db.LangInfos, "LangInfoId", "Name", form.LangInfoId);
            return View(form);
        }

        // GET: Forms/Edit/5
        public ActionResult Edit(int? id)
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
            ViewBag.ComputerSkillId = new SelectList(db.ComputerSkills, "ComputerSkillId", "Name", form.ComputerSkillId);
            ViewBag.CourseNSeminarId = new SelectList(db.CourseNSeminars, "CourseNSeminarId", "Certificate", form.CourseNSeminarId);
            ViewBag.JobHistoryId = new SelectList(db.JobHistorys, "JobHistoryId", "Name", form.JobHistoryId);
            ViewBag.LangInfoId = new SelectList(db.LangInfos, "LangInfoId", "Name", form.LangInfoId);
            return View(form);
        }

        // POST: Forms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FormId,FirstMidName,LastName,BirthDate,PhoneNumber,Address,MilitaryService,TshirtSize,PantSize,ShoesSize,DrivingLicence,DrivingLicenceClass,ForkliftLicence,CraneOperationLicense,CourseNSeminarId,LangInfoId,ComputerSkillId,WorkingNow,JobChangeReason,JobHistoryId,Ok4Overtime,Ok4ShiftWork")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ComputerSkillId = new SelectList(db.ComputerSkills, "ComputerSkillId", "Name", form.ComputerSkillId);
            ViewBag.CourseNSeminarId = new SelectList(db.CourseNSeminars, "CourseNSeminarId", "Certificate", form.CourseNSeminarId);
            ViewBag.JobHistoryId = new SelectList(db.JobHistorys, "JobHistoryId", "Name", form.JobHistoryId);
            ViewBag.LangInfoId = new SelectList(db.LangInfos, "LangInfoId", "Name", form.LangInfoId);
            return View(form);
        }

        // GET: Forms/Delete/5
        public ActionResult Delete(int? id)
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
            return View(form);
        }

        // POST: Forms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Form form = db.Forms.Find(id);
            db.Forms.Remove(form);
            db.SaveChanges();
            return RedirectToAction("Index");
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
