using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class FormViewController : Controller
    {
        // GET: FormView
        public ActionResult Index()
        {
            return View();
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
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FormView/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FormView/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FormView/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FormView/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EmploymentApplicationForm()
        {
            return View();
        }

    }
}
