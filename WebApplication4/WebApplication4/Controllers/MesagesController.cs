using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class MesagesController : Controller
    {
        private OnlineChatingEntities db = new OnlineChatingEntities();

        // GET: Mesages
        public ActionResult Index()
        {
            var mesages = db.Mesages.Include(m => m.Signup);
            return View(mesages.ToList());
        }

        // GET: Mesages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mesage mesage = db.Mesages.Find(id);
            if (mesage == null)
            {
                return HttpNotFound();
            }
            return View(mesage);
        }

        // GET: Mesages/Create
        public ActionResult Create()
        {
            ViewBag.msg_Signup = new SelectList(db.Signups, "sig_id", "sig_username");
            return View();
        }

        // POST: Mesages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "msg_id,msg_Signup,msg_Text")] Mesage mesage)
        {
            if (ModelState.IsValid)
            {
                db.Mesages.Add(mesage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.msg_Signup = new SelectList(db.Signups, "sig_id", "sig_username", mesage.msg_Signup);
            return View(mesage);
        }

        // GET: Mesages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mesage mesage = db.Mesages.Find(id);
            if (mesage == null)
            {
                return HttpNotFound();
            }
            ViewBag.msg_Signup = new SelectList(db.Signups, "sig_id", "sig_username", mesage.msg_Signup);
            return View(mesage);
        }

        // POST: Mesages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "msg_id,msg_Signup,msg_Text")] Mesage mesage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mesage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.msg_Signup = new SelectList(db.Signups, "sig_id", "sig_username", mesage.msg_Signup);
            return View(mesage);
        }

        // GET: Mesages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mesage mesage = db.Mesages.Find(id);
            if (mesage == null)
            {
                return HttpNotFound();
            }
            return View(mesage);
        }

        // POST: Mesages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mesage mesage = db.Mesages.Find(id);
            db.Mesages.Remove(mesage);
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
