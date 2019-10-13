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
    public class CourseNSeminarsController : Controller
    {
        private FormDbContext db = new FormDbContext();

        // GET: CourseNSeminars
        public ActionResult Index()
        {
            return View(db.CourseNSeminars.ToList());
        }

        // GET: CourseNSeminars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseNSeminar courseNSeminar = db.CourseNSeminars.Find(id);
            if (courseNSeminar == null)
            {
                return HttpNotFound();
            }
            return View(courseNSeminar);
        }

        // GET: CourseNSeminars/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseNSeminars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseNSeminarId,Certificate,Topic")] CourseNSeminar courseNSeminar)
        {
            if (ModelState.IsValid)
            {
                db.CourseNSeminars.Add(courseNSeminar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseNSeminar);
        }

        // GET: CourseNSeminars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseNSeminar courseNSeminar = db.CourseNSeminars.Find(id);
            if (courseNSeminar == null)
            {
                return HttpNotFound();
            }
            return View(courseNSeminar);
        }

        // POST: CourseNSeminars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseNSeminarId,Certificate,Topic")] CourseNSeminar courseNSeminar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseNSeminar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseNSeminar);
        }

        // GET: CourseNSeminars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseNSeminar courseNSeminar = db.CourseNSeminars.Find(id);
            if (courseNSeminar == null)
            {
                return HttpNotFound();
            }
            return View(courseNSeminar);
        }

        // POST: CourseNSeminars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseNSeminar courseNSeminar = db.CourseNSeminars.Find(id);
            db.CourseNSeminars.Remove(courseNSeminar);
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
