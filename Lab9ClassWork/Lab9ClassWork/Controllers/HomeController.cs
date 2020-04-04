using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab9ClassWork.Models;

namespace Lab9ClassWork.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(First emp)
        {
            if (!string.IsNullOrEmpty(emp.UserName))
            {
                return RedirectToAction("Message");
            }
            else
            {
                ModelState.AddModelError("UserName", "Field Required.......");
                return View();
            }
        }
        public ActionResult Message()
        {
            return View();
        }
    }
}