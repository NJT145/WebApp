using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.DAL;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FormResultsController : Controller
    {
        private FormDbContext db = new FormDbContext();

        // GET: FormResults
        public ActionResult Index()
        {
            var formResults = db.FormResults.Include(f => f.Form);
            return View(formResults.ToList());
        }

        // GET: FormResults/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormResult formResult = db.FormResults.Find(id);
            if (formResult == null)
            {
                return HttpNotFound();
            }
            return View(formResult);
        }

        // GET: FormResults/Create
        public ActionResult Create()
        {
            ViewBag.FormResultId = new SelectList(db.Forms, "FormId", "FirstMidName");
            return View();
        }

        // POST: FormResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FormResultId,FormResultConfirmed,FormResultPrice,FormResultShiftWork,FormResultShiftWork2,FormResultMilitaryService,FormResultEduStatus,FormResultAddress")] FormResult formResult)
        {
            if (ModelState.IsValid)
            {
                db.FormResults.Add(formResult);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FormResultId = new SelectList(db.Forms, "FormId", "FirstMidName", formResult.FormResultId);
            return View(formResult);
        }

        // GET: FormResults/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormResult formResult = db.FormResults.Find(id);
            if (formResult == null)
            {
                return HttpNotFound();
            }
            ViewBag.FormResultId = new SelectList(db.Forms, "FormId", "FirstMidName", formResult.FormResultId);
            return View(formResult);
        }

        // POST: FormResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FormResultId,FormResultConfirmed,FormResultPrice,FormResultShiftWork,FormResultShiftWork2,FormResultMilitaryService,FormResultEduStatus,FormResultAddress")] FormResult formResult)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formResult).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FormResultId = new SelectList(db.Forms, "FormId", "FirstMidName", formResult.FormResultId);
            return View(formResult);
        }

        // GET: FormResults/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormResult formResult = db.FormResults.Find(id);
            if (formResult == null)
            {
                return HttpNotFound();
            }
            return View(formResult);
        }

        // POST: FormResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FormResult formResult = db.FormResults.Find(id);
            db.FormResults.Remove(formResult);
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
