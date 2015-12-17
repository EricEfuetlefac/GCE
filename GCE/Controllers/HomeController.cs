using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GCE.Models;

namespace GCE.Controllers
{
    public class HomeController : Controller
    {
        private ResultContext db = new ResultContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(db.GCEresults.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            GCEresult gceresult = db.GCEresults.Find(id);
            if (gceresult == null)
            {
                return HttpNotFound();
            }
            return View(gceresult);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GCEresult gceresult)
        {
            if (ModelState.IsValid)
            {
                int i = 50000;

                while (i < 150000)
                {

                    gceresult.Name = "Candidate" + i;
                    db.GCEresults.Add(gceresult);
                    db.SaveChanges();
                    i++;

                }

                
                return RedirectToAction("Index");
            }

            return View(gceresult);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            GCEresult gceresult = db.GCEresults.Find(id);
            if (gceresult == null)
            {
                return HttpNotFound();
            }
            return View(gceresult);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GCEresult gceresult)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gceresult).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gceresult);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            GCEresult gceresult = db.GCEresults.Find(id);
            if (gceresult == null)
            {
                return HttpNotFound();
            }
            return View(gceresult);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GCEresult gceresult = db.GCEresults.Find(id);
            db.GCEresults.Remove(gceresult);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}