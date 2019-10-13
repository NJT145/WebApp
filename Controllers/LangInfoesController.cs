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
    public class LangInfoesController : Controller
    {
        private FormDbContext db = new FormDbContext();

        // GET: LangInfoes
        public ActionResult Index()
        {
            return View(db.LangInfos.ToList());
        }

        // GET: LangInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LangInfo langInfo = db.LangInfos.Find(id);
            if (langInfo == null)
            {
                return HttpNotFound();
            }
            return View(langInfo);
        }

        // GET: LangInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LangInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LangInfoId,LangInfoName,LangInfoLevel")] LangInfo langInfo)
        {
            if (ModelState.IsValid)
            {
                db.LangInfos.Add(langInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(langInfo);
        }

        // GET: LangInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LangInfo langInfo = db.LangInfos.Find(id);
            if (langInfo == null)
            {
                return HttpNotFound();
            }
            return View(langInfo);
        }

        // POST: LangInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LangInfoId,LangInfoName,LangInfoLevel")] LangInfo langInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(langInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(langInfo);
        }

        // GET: LangInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LangInfo langInfo = db.LangInfos.Find(id);
            if (langInfo == null)
            {
                return HttpNotFound();
            }
            return View(langInfo);
        }

        // POST: LangInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LangInfo langInfo = db.LangInfos.Find(id);
            db.LangInfos.Remove(langInfo);
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
