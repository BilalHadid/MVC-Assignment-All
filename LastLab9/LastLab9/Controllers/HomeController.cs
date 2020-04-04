using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LastLab9.Models;

namespace LastLab9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        // GET: Home
        public ActionResult Index(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Message");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult Message()
        {

            return View();
        }
        
    }
}