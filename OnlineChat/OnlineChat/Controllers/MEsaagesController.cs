using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineChat.Models;

namespace OnlineChat.Controllers
{
    public class MEsaagesController : Controller
    {
        private ProjectWorkEntities db = new ProjectWorkEntities();

        // GET: MEsaages
        public ActionResult Index()
        {
            var mEsaages = db.MEsaages.Include(m => m.loginForm);
            return View(mEsaages.ToList());
        }

        // GET: MEsaages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MEsaage mEsaage = db.MEsaages.Find(id);
            if (mEsaage == null)
            {
                return HttpNotFound();
            }
            return View(mEsaage);
        }

        // GET: MEsaages/Create
        public ActionResult Create()
        {
            ViewBag.UserName = new SelectList(db.loginForms, "Log_id", "Name");
            return View();
        }

        // POST: MEsaages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,UserName,texts,whens")] MEsaage mEsaage)
        {
            if (ModelState.IsValid)
            {
                db.MEsaages.Add(mEsaage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserName = new SelectList(db.loginForms, "Log_id", "Name", mEsaage.UserName);
            return View(mEsaage);
        }

        // GET: MEsaages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MEsaage mEsaage = db.MEsaages.Find(id);
            if (mEsaage == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserName = new SelectList(db.loginForms, "Log_id", "Name", mEsaage.UserName);
            return View(mEsaage);
        }

        // POST: MEsaages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,UserName,texts,whens")] MEsaage mEsaage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mEsaage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserName = new SelectList(db.loginForms, "Log_id", "Name", mEsaage.UserName);
            return View(mEsaage);
        }

        // GET: MEsaages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MEsaage mEsaage = db.MEsaages.Find(id);
            if (mEsaage == null)
            {
                return HttpNotFound();
            }
            return View(mEsaage);
        }

        // POST: MEsaages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MEsaage mEsaage = db.MEsaages.Find(id);
            db.MEsaages.Remove(mEsaage);
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
