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
    public class ComputerSkillsController : Controller
    {
        private FormDbContext db = new FormDbContext();

        // GET: ComputerSkills
        public ActionResult Index()
        {
            return View(db.ComputerSkills.ToList());
        }

        // GET: ComputerSkills/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComputerSkill computerSkill = db.ComputerSkills.Find(id);
            if (computerSkill == null)
            {
                return HttpNotFound();
            }
            return View(computerSkill);
        }

        // GET: ComputerSkills/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ComputerSkills/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ComputerSkillId,ComputerSkillName,ComputerSkillLevel")] ComputerSkill computerSkill)
        {
            if (ModelState.IsValid)
            {
                db.ComputerSkills.Add(computerSkill);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(computerSkill);
        }

        // GET: ComputerSkills/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComputerSkill computerSkill = db.ComputerSkills.Find(id);
            if (computerSkill == null)
            {
                return HttpNotFound();
            }
            return View(computerSkill);
        }

        // POST: ComputerSkills/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ComputerSkillId,ComputerSkillName,ComputerSkillLevel")] ComputerSkill computerSkill)
        {
            if (ModelState.IsValid)
            {
                db.Entry(computerSkill).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(computerSkill);
        }

        // GET: ComputerSkills/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ComputerSkill computerSkill = db.ComputerSkills.Find(id);
            if (computerSkill == null)
            {
                return HttpNotFound();
            }
            return View(computerSkill);
        }

        // POST: ComputerSkills/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComputerSkill computerSkill = db.ComputerSkills.Find(id);
            db.ComputerSkills.Remove(computerSkill);
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
