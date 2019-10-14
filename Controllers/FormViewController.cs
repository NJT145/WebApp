using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.DAL;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FormViewController : Controller
    {
        private FormDbContext db = new FormDbContext();

        // GET: Forms
        public ActionResult Index()
        {
            return View(db.Forms.ToList());
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
            return View();
        }

        // POST: Forms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FormId,FirstMidName,LastName,BirthDate,PhoneNumber,Address,MilitaryService,MilitaryServiceEnum,TshirtSize,PantSize,ShoesSize,DrivingLicence,DrivingLicenceClass,ForkliftLicence,CraneOperationLicense,PrimarySchool_bool,PrimarySchool_name,SecondarySchool_bool,SecondarySchool_name,HighSchool_bool,HighSchool_name,AssociateDegree_bool,AssociateDegree_name,BachelorDegree_bool,BachelorDegree_name,MasterDegree_bool,MasterDegree_name,CourseNSeminar1_Certificate,CourseNSeminar1_Topic,CourseNSeminar2_Certificate,CourseNSeminar2_Topic,CourseNSeminar3_Certificate,CourseNSeminar3_Topic,LangInfo_eng,LangInfo_de,LangInfo_fr,LangInfo_other,LangInfo_other_name,WorkingNow,JobChangeReason,Ok4Overtime,Ok4ShiftWork")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Forms.Add(form);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

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
            return View(form);
        }

        // POST: Forms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FormId,FirstMidName,LastName,BirthDate,PhoneNumber,Address,MilitaryService,MilitaryServiceEnum,TshirtSize,PantSize,ShoesSize,DrivingLicence,DrivingLicenceClass,ForkliftLicence,CraneOperationLicense,PrimarySchool_bool,PrimarySchool_name,SecondarySchool_bool,SecondarySchool_name,HighSchool_bool,HighSchool_name,AssociateDegree_bool,AssociateDegree_name,BachelorDegree_bool,BachelorDegree_name,MasterDegree_bool,MasterDegree_name,CourseNSeminar1_Certificate,CourseNSeminar1_Topic,CourseNSeminar2_Certificate,CourseNSeminar2_Topic,CourseNSeminar3_Certificate,CourseNSeminar3_Topic,LangInfo_eng,LangInfo_de,LangInfo_fr,LangInfo_other,LangInfo_other_name,WorkingNow,JobChangeReason,Ok4Overtime,Ok4ShiftWork")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
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
