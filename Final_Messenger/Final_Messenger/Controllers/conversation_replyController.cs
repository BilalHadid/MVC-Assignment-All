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
    public class conversation_replyController : Controller
    {
        private MesengerEntities db = new MesengerEntities();

        // GET: conversation_reply
        public ActionResult Index()
        {
            var conversation_reply = db.conversation_reply.Include(c => c.conversation).Include(c => c.user);
            return View(conversation_reply.ToList());
        }

        // GET: conversation_reply/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            conversation_reply conversation_reply = db.conversation_reply.Find(id);
            if (conversation_reply == null)
            {
                return HttpNotFound();
            }
            return View(conversation_reply);
        }

        // GET: conversation_reply/Create
        public ActionResult Create()
        {
            ViewBag.c_id_fk = new SelectList(db.conversations, "c_id", "ip");
            ViewBag.user_id_fk = new SelectList(db.users, "user_id", "username");
            return View();
        }

        // POST: conversation_reply/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cr_id,reply,user_id_fk,ip,times,c_id_fk")] conversation_reply conversation_reply)
        {
            if (ModelState.IsValid)
            {
                db.conversation_reply.Add(conversation_reply);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.c_id_fk = new SelectList(db.conversations, "c_id", "ip", conversation_reply.c_id_fk);
            ViewBag.user_id_fk = new SelectList(db.users, "user_id", "username", conversation_reply.user_id_fk);
            return View(conversation_reply);
        }

        // GET: conversation_reply/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            conversation_reply conversation_reply = db.conversation_reply.Find(id);
            if (conversation_reply == null)
            {
                return HttpNotFound();
            }
            ViewBag.c_id_fk = new SelectList(db.conversations, "c_id", "ip", conversation_reply.c_id_fk);
            ViewBag.user_id_fk = new SelectList(db.users, "user_id", "username", conversation_reply.user_id_fk);
            return View(conversation_reply);
        }

        // POST: conversation_reply/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cr_id,reply,user_id_fk,ip,times,c_id_fk")] conversation_reply conversation_reply)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conversation_reply).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.c_id_fk = new SelectList(db.conversations, "c_id", "ip", conversation_reply.c_id_fk);
            ViewBag.user_id_fk = new SelectList(db.users, "user_id", "username", conversation_reply.user_id_fk);
            return View(conversation_reply);
        }

        // GET: conversation_reply/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            conversation_reply conversation_reply = db.conversation_reply.Find(id);
            if (conversation_reply == null)
            {
                return HttpNotFound();
            }
            return View(conversation_reply);
        }

        // POST: conversation_reply/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            conversation_reply conversation_reply = db.conversation_reply.Find(id);
            db.conversation_reply.Remove(conversation_reply);
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
