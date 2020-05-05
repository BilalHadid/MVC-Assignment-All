using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Final_Messenger.Models;

namespace Final_Messenger.Controllers
{
    public class conversationsController : Controller
    {
        private MesengerEntities db = new MesengerEntities();

        // GET: conversations
        public ActionResult Index()
        {
            var conversations = db.conversations.Include(c => c.user).Include(c => c.user1);
            return View(conversations.ToList());
        }

        // GET: conversations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            conversation conversation = db.conversations.Find(id);
            if (conversation == null)
            {
                return HttpNotFound();
            }
            return View(conversation);
        }

        // GET: conversations/Create
        public ActionResult Create()
        {
            ViewBag.user_one = new SelectList(db.users, "user_id", "username");
            ViewBag.user_two = new SelectList(db.users, "user_id", "username");
            return View();
        }

        // POST: conversations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "c_id,user_one,user_two,ip,times")] conversation conversation)
        {
            if (ModelState.IsValid)
            {
                db.conversations.Add(conversation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.user_one = new SelectList(db.users, "user_id", "username", conversation.user_one);
            ViewBag.user_two = new SelectList(db.users, "user_id", "username", conversation.user_two);
            return View(conversation);
        }

        // GET: conversations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            conversation conversation = db.conversations.Find(id);
            if (conversation == null)
            {
                return HttpNotFound();
            }
            ViewBag.user_one = new SelectList(db.users, "user_id", "username", conversation.user_one);
            ViewBag.user_two = new SelectList(db.users, "user_id", "username", conversation.user_two);
            return View(conversation);
        }

        // POST: conversations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "c_id,user_one,user_two,ip,times")] conversation conversation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conversation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.user_one = new SelectList(db.users, "user_id", "username", conversation.user_one);
            ViewBag.user_two = new SelectList(db.users, "user_id", "username", conversation.user_two);
            return View(conversation);
        }

        // GET: conversations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            conversation conversation = db.conversations.Find(id);
            if (conversation == null)
            {
                return HttpNotFound();
            }
            return View(conversation);
        }

        // POST: conversations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            conversation conversation = db.conversations.Find(id);
            db.conversations.Remove(conversation);
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
