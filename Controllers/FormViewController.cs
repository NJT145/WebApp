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

        // GET: FormView
        public ActionResult Index()
        {
            DbSet<Form> forms = db.Forms;
            return View(forms.ToList());
        }

        // GET: FormView/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FormView/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormView/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FormId,FirstMidName,LastName,BirthDate,PhoneNumber,Address,MilitaryService,TshirtSize,PantSize,ShoesSize,DrivingLicence,DrivingLicenceClass,ForkliftLicence,CraneOperationLicense,WorkingNow,JobChangeReason,Ok4Overtime,Ok4ShiftWork")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Forms.Add(form);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(form);
        }
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here
        //
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: FormView/Edit/5
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

        // POST: FormView/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FormId,FirstMidName,LastName,BirthDate,PhoneNumber,Address,MilitaryService,TshirtSize,PantSize,ShoesSize,DrivingLicence,DrivingLicenceClass,ForkliftLicence,CraneOperationLicense,WorkingNow,JobChangeReason,Ok4Overtime,Ok4ShiftWork")] Form form)
        {
            if (ModelState.IsValid)
            {
                db.Entry(form).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(form);
        }
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here
        //
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: FormView/Delete/5
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

        // POST: FormView/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Form form = db.Forms.Find(id);
            db.Forms.Remove(form);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here
        //
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
