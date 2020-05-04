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
    public class loginFormsController : Controller
    {
        private ProjectWorkEntities db = new ProjectWorkEntities();

        // GET: loginForms
        public ActionResult Index()
        {
            return View(db.loginForms.ToList());
        }

        // GET: loginForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loginForm loginForm = db.loginForms.Find(id);
            if (loginForm == null)
            {
                return HttpNotFound();
            }
            return View(loginForm);
        }

        // GET: loginForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: loginForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Log_id,Name,Email,Pass")] loginForm loginForm)
        {
            if (ModelState.IsValid)
            {
                db.loginForms.Add(loginForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loginForm);
        }

        // GET: loginForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loginForm loginForm = db.loginForms.Find(id);
            if (loginForm == null)
            {
                return HttpNotFound();
            }
            return View(loginForm);
        }

        // POST: loginForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Log_id,Name,Email,Pass")] loginForm loginForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loginForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loginForm);
        }

        // GET: loginForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            loginForm loginForm = db.loginForms.Find(id);
            if (loginForm == null)
            {
                return HttpNotFound();
            }
            return View(loginForm);
        }

        // POST: loginForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            loginForm loginForm = db.loginForms.Find(id);
            db.loginForms.Remove(loginForm);
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
